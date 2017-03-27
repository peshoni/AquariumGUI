using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AquariumGUI;
using Observer;
using WarehouseToAquaticOrganisms.Classes;

namespace WarehouseToAquaticOrganisms.DBClasses
{
    public class DeliveryManager2 : ObserverPattern
    {
        private string ConnectionString;
        public DeliveryManager2( Warehouse warehouse ) {
            ConnectionString = DBUtill.GetConnectionString();
            this._warehouse = warehouse;
            this._warehouse.attachObserver(this);
        }
        public List<TestDeliveryClass> getProducts() {
            return getListWithProducts();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<TestDeliveryClass> getListWithProducts()
        {
            List<TestDeliveryClass> list = new List<TestDeliveryClass>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql =
                    @"SELECT ID
                            ,Name                                                       
                        FROM Product";
                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TestDeliveryClass product = new TestDeliveryClass();
                        product.ProductID = reader.GetInt32(0);
                        product.ProductName= reader.GetString(1);
                        list.Add(product);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Gets rows for given document.
        /// </summary>
        /// <param name="DocID">Id of the document.</param>
        /// <returns></returns>
        public List<TestDeliveryClass> getListWithDeliveryDetails( int DocID )
        {
            List<TestDeliveryClass> list = new List<TestDeliveryClass>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql = String.Format(@"
SELECT  
prod.Name,
doc.ID, row.Quantity, row.DeliveryPrice
from Document doc, RowOfDocuments row,Product prod
where 
doc.id = row.DocumentID and row.ProdutID = prod.ID and doc.id = {0} 

", DocID);

    
                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    { 
                        TestDeliveryClass test = new TestDeliveryClass();
                        test.ProductName = reader.GetString(0);
                        test.DocID = reader.GetInt32(1);
                        test.Quantity = reader.GetInt32(2);
                        test.DeliveryPrice = reader.GetDecimal(3);
                         

                        //test.ProviderName = reader.GetString(3);
                        //test.AccountablePerson = reader.GetString(4);
                        //test.Bulstat = reader.GetString(5);
                        //test.Phone = reader.GetString(6);
                        //test.IsPaid = reader.GetBoolean(7);
                        list.Add(test);
                    }
                }
            } 
            return list;
        }
        /// <summary>
        /// Gets list with all deliveries.
        /// </summary>
        /// <returns> List with <see cref="TestDeliveryClass"/></returns>
        public List<TestDeliveryClass> getList()
        { 
            List<TestDeliveryClass> list = new List<TestDeliveryClass>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql = @"
SELECT       
[Document].ID,
[Document].isDelivery, 
[Document].ProviderID, 
Provider.Name, 
Provider.Phone, 
Provider.Account_person, 
[Document].Date,
[Document].isPaid
FROM            [Document] INNER JOIN
                         Provider ON [Document].ProviderID = Provider.ID    ";

                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TestDeliveryClass test = new TestDeliveryClass();
                        
                        test.DocID = reader.GetInt32(0);
                        test.ProviderName = reader.GetString(3); 
                        test.Phone = reader.GetString(4);
                        test.AccountablePerson = reader.GetString(5); 
                        test.IsPaid = reader.GetBoolean(7);
                        list.Add(test);
                    }
                }
            }
            return list;
        }

        public override void update()
        {
            addProduct(_warehouse.Provider, _warehouse.Delivery);
        }
        private void addProduct( Company provider, List<TestDeliveryClass> delivery )
        {
            if (delivery != null)
            {
               // Table.Add(++ID, delivery);
                InsertDeliveryIntoDBtableDelivery(provider, delivery);
            }
        }
        private void InsertDeliveryIntoDBtableDelivery( Company provider, List<TestDeliveryClass> delivery )
        {
            if (delivery != null)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    using (var transaction = con.BeginTransaction("DeliveryTransaction"))
                    {
                        TestDeliveryClass del = new TestDeliveryClass();
                        //del.
                        int DocID = saveDocumentandGetID(provider,del);


                        // Start a local transaction.                    
                        //// For each...
                        delivery.ForEach(element =>
                        {
                            string comm = @" 
        INSERT INTO RowOfDocuments(
            DocumentID 
            ,Quantity
            ,DeliveryPrice
            ,ProdutID
            )

        VALUES 
           (@DocumentID
            ,@Quantity
            ,@DeliveryPrice
            ,@ProductID)";
                            using (SqlCommand command = new SqlCommand(comm, con))
                            {
                                command.Transaction = transaction;
                               
                                command.Parameters.AddWithValue("@DocumentID", DocID);
                                command.Parameters.AddWithValue("@Quantity", element.Quantity);
                                command.Parameters.AddWithValue("@DeliveryPrice", element.DeliveryPrice);
                                command.Parameters.AddWithValue("@ProductID", element.ProductID);

                                //command.Parameters.AddWithValue("@isDelivery", true);
                                //command.Parameters.AddWithValue("@ProviderID", element.ProviderID);
                                //command.Parameters.AddWithValue("@ProductID", element.ProductID);
                                //command.Parameters.AddWithValue("@Quantity", element.Quantity);
                                //command.Parameters.AddWithValue("@DeliveryPrice", element.Price);
                                command.ExecuteNonQuery();
                            }
                        });
                        transaction.Commit();

                    }
                }
            }
        }

        private int saveDocumentandGetID( Company provider, TestDeliveryClass delivery )
        {
            int primaryKey = 0;
            if (delivery != null)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string sql = @"
        INSERT INTO Document(
             isDelivery
            ,ProviderID 
            ,isPaid
)
        OUTPUT INSERTED.ID

        VALUES 
           (@isDelivery
           ,@ProviderID
           ,@isPaid
            )";
                    using (SqlCommand command = new SqlCommand(sql, con))
                    {
                        command.Parameters.AddWithValue("@isDelivery", true);
                        command.Parameters.AddWithValue("@ProviderID", provider.ID);
                        command.Parameters.AddWithValue("@isPaid", false);

                        primaryKey = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            return primaryKey;
        }
    }
}
