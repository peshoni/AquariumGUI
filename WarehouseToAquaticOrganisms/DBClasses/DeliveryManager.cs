using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using AquariumGUI;
using Observer;
using WarehouseToAquaticOrganisms.Classes;

namespace WarehouseToAquaticOrganisms.DBClasses
{
    public class DeliveryManager 
    {  
        public List<Delivery> getProducts() {
            return getListWithProducts();
        }

        public List<Delivery> GetListWithCategories()
        {
            return getCategories();
        }

        private List<Delivery> getCategories()
        { 
                 List<Delivery> list = new List<Delivery>();
            using (SqlConnection con = DBManager.GetConnection())
            {
                con.Open(); 
                string sql = @"SELECT*
  FROM  Category;";

                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Delivery product = new Delivery();
                        product.CategoryId = reader.GetInt32(0);
                        product.Category = reader.GetString(1); 
                        list.Add(product);
                    }
                }
            }
            return list; 
        }

        /// <summary>
        /// Getts list with available articles.
        /// </summary>
        /// <returns><see cref="List<see cref=" Delivery"/>>"/></returns>
        public List <Delivery> GetAvailableProductsproperties() {
            return getAvailable();
        }
        /// <summary>
        /// Getts list with available articles.
        /// </summary>
        /// <returns></returns>
        private List<Delivery> getAvailable()
        {
            List<Delivery> list = new List<Delivery>();
            using (SqlConnection con = DBManager.GetConnection())
            {
                con.Open();
                //                string sql = @"
                //select 
                //        pro.ID,
                //        pro.Name,
                //        SUM(row.Quantity) available,
                //        AVG(row.SalePrice) average 
                //from 
                //        Document doc, RowOfDocuments row, Product pro
                //where 
                //        doc.ID = row.DocumentID and row.ProdutID = pro.ID
                //GROUP BY pro.ID,pro.Name; ";


                string sql = @"
                select cat.Id,
		cat.Name,
        pro.ID,
        pro.Name,
        SUM(row.Quantity) available,
        AVG(row.SalePrice) average
from
        Document doc, RowOfDocuments row, Product pro, Category cat
where
        doc.ID = row.DocumentID and row.ProdutID = pro.ID and pro.CategoryID = cat.Id
GROUP BY cat.Id,cat.Name,pro.ID,pro.Name;";

                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Delivery product = new Delivery();
                        product.CategoryId = reader.GetInt32(0);
                        product.Category = reader.GetString(1); 
                        product.ProductID = reader.GetInt32(2);
                        product.ProductName = reader.GetString(3);
                        product.Quantity  = reader.GetInt32(4);
                        var de = reader.GetDecimal(5);
                        product.DeliveryPrice = (decimal)de; 
                        list.Add(product);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Delivery> getListWithProducts()
        {
            List<Delivery> list = new List<Delivery>();
            using (SqlConnection con = DBManager.GetConnection())
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
                        Delivery product = new Delivery();
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
        public List<Delivery> getListWithDeliveryDetails( int DocID )
        {
            List<Delivery> list = new List<Delivery>();
            using (SqlConnection con = DBManager.GetConnection())
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
                        Delivery test = new Delivery();
                        test.ProductName = reader.GetString(0);
                        test.DocID = reader.GetInt32(1);
                        test.Quantity = reader.GetInt32(2);
                        test.DeliveryPrice = reader.GetDecimal(3); 
                        list.Add(test);
                    }
                }
            } 
            return list;
        }
        /// <summary>
        /// Gets list with all deliveries.
        /// </summary>
        /// <returns> List with <see cref="Delivery"/></returns>
        public List<Delivery> getList(DateTime dateTime, string nameKey)
        {
            CultureInfo current = Thread.CurrentThread.CurrentCulture;
            string whereTimeClause = "";
            string nameClause  = "";
            if (nameKey!=null)
            {
                nameClause = String.Format("where Provider.Name LIKE '{0}%'", nameKey); 
            } else     
            // If is today make standard query..
            if (!dateTime.Equals(DateTime.Today))
            { 
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                DateTime tomorow = dateTime.AddDays(1);
               // whereTimeClause = "Where [Document].Date Between '"+ dateTime.ToShortDateString() +"' and '"+ tomorow.ToShortDateString()+"'";
                whereTimeClause= string.Format("Where [Document].Date Between '{0}' and '{1}'", dateTime.ToShortDateString(), tomorow.ToShortDateString());
                Thread.CurrentThread.CurrentUICulture = current;
            }
           
            List<Delivery> list = new List<Delivery>();
            using (SqlConnection con = DBManager.GetConnection())
            {
                con.Open();
                string sql =string.Format(@"
SELECT       
    [Document].ID,
    [Document].isDelivery, 
    [Document].ProviderID, 
    Provider.Name, 
    Provider.Phone, 
    Provider.Account_person, 
    Provider.Bulstat,
    [Document].Date,
    [Document].isPaid
FROM            [Document] INNER JOIN
                         Provider ON [Document].ProviderID = Provider.ID  {0}{1}",whereTimeClause,nameClause);

                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader()) 
                { 
                    while (reader.Read())
                    {
                        Delivery test = new Delivery(); 
                        test.DocID = reader.GetInt32(0);
                        test.ProviderName = reader.GetString(3); 
                        test.Phone = reader.GetString(4);
                        test.AccountablePerson = reader.GetString(5);
                        test.Bulstat = reader.GetString(6);
                        test.DateTime = reader.GetDateTime(7);
                        test.IsPaid = reader.GetBoolean(8);
                        list.Add(test);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Makes delivery from given provider.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="delivery"></param>
        public void makeDelivery( Company provider, List<Delivery> delivery ) {
            addProduct(provider, delivery);
        }
      
        private void addProduct( Company provider, List<Delivery> delivery )
        {
            if (delivery != null)
            {
                using (SqlConnection con = DBManager.GetConnection())
                {
                    con.Open();

                    using (var transaction = con.BeginTransaction("DeliveryTransaction"))
                    {
                        Delivery del = new Delivery();
                        
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
                                command.ExecuteNonQuery();
                            }
                        });
                        transaction.Commit(); 
                    }
                }
            }
        }

        private int saveDocumentandGetID( Company provider, Delivery delivery )
        {
            int primaryKey = 0;
            if (delivery != null)
            {
                using (SqlConnection con = DBManager.GetConnection())
                {
                    con.Open();
                    string sql = @"
        INSERT INTO Document(
             isDelivery
            ,ProviderID 
            ,isPaid
            ,Date
)
        OUTPUT INSERTED.ID

        VALUES 
           (@isDelivery
           ,@ProviderID
           ,@isPaid
           ,@Date
            )";
                    using (SqlCommand command = new SqlCommand(sql, con))
                    { 
                        command.Parameters.AddWithValue("@isDelivery", true);
                        command.Parameters.AddWithValue("@ProviderID", provider.ID);
                        command.Parameters.AddWithValue("@isPaid", false);
                        command.Parameters.AddWithValue("@Date", System.DateTime.Now); 
                        primaryKey = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            return primaryKey;
        }
    }
}
