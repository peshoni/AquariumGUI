using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer;
using WarehouseToAquaticOrganisms;
using WarehouseToAquaticOrganisms.Classes;

namespace WarehouseToAquaticOrganisms.DBClasses
{
   public class SaleManager 
    {
        const string company ="Company";
        const string person = "Person";
        public SaleManager() {

        }
        public List<Sale> getListWithCompanySales()
        {
            List<Sale> list = new List<Sale>();
            using (SqlConnection con = DBManager.GetConnection())
            {
                con.Open();
                string sql = @"
select 
    doc.ID,
    com.Name,
    com.Bulstat,
    doc.isPaid
from 
    Document doc, Company com
where 
   doc.CompanyID IS NOT NULL and doc.CompanyID = com.ID"; 
                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sale sale = new Sale();
                        sale.DocID = reader.GetInt32(0);
                        sale.CompanyName = reader.GetString(1);
                        sale.CompanyBulstat = reader.GetString(2);
                        sale.IsPaid = reader.GetBoolean(3);

                        list.Add(sale);
                    }
                }
            }
            return list;
        }

        public List<Sale> getListWithPersonSales()
        {
            List<Sale> list = new List<Sale>();
            using (SqlConnection con = DBManager.GetConnection())
            {
                con.Open();
                string sql = @"
select 
    doc.ID,
    pers.Name,
    pers.EGN,
    doc.isPaid
from 
    Document doc,Person pers
where 
   doc.PersonID IS NOT NULL and doc.PersonID = pers.ID";
                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sale sale = new Sale();
                        sale.DocID = reader.GetInt32(0);
                        sale.PersonName = reader.GetString(1);
                        sale.Egn = reader.GetInt64(2);
                        sale.IsPaid = reader.GetBoolean(3);
                        list.Add(sale);
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
        public List<Sale> getListWithSaleCompanyDetails( int DocID )
        {
            List<Sale> list = new List<Sale>();
            using (SqlConnection con = DBManager.GetConnection())
            {
                con.Open();
                string sql = String.Format(@"
SELECT  
prod.Name,
doc.ID, 
row.Quantity,
row.SalePrice
from Document doc, RowOfDocuments row,Product prod
where 
doc.id = row.DocumentID and row.ProdutID = prod.ID and doc.id = {0} 
", DocID);


                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sale sale = new Sale();
                        sale.ProductName = reader.GetString(0);
                        sale.DocID = reader.GetInt32(1);
                        sale.Quantity = reader.GetInt32(2)*-1;
                        sale.SalePrice = reader.GetDecimal(3);
                        list.Add(sale);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Sale operation
        /// </summary>
        /// <param name="partner"></param>
        /// <param name="delivery"></param>
        public void makeSale( Partner partner, List<Sale> sale )
        {
            saveSaleIntoDB( partner, sale);
        }
        private void saveSaleIntoDB( Partner patrner, List<Sale> sale )
        {
            if (sale != null)
            {
                using (SqlConnection con = DBManager.GetConnection())
                {
                    con.Open();
                    
                    using (var transaction = con.BeginTransaction("SaleTransaction"))
                    {
                        Sale del = new Sale();

                        //del.
                        int DocID = saveDocumentandGetID(patrner, del);
                        // Start a local transaction.                    
                        //// For each...
                        sale.ForEach(element =>
                        {
                            string comm = @" 
        INSERT INTO RowOfDocuments(
            DocumentID 
            ,Quantity
            ,DeliveryPrice
            ,ProdutID
            ,SalePrice
            )

        VALUES 
           (@DocumentID
            ,@Quantity
            ,@DeliveryPrice
            ,@ProductID
            ,@SalePrice)";
                            using (SqlCommand command = new SqlCommand(comm, con))
                            {
                                command.Transaction = transaction;
                                command.Parameters.AddWithValue("@DocumentID", DocID);
                                command.Parameters.AddWithValue("@Quantity", element.Quantity);
                                command.Parameters.AddWithValue("@DeliveryPrice", element.DeliveryPrice);
                                command.Parameters.AddWithValue("@ProductID", element.ProductId);
                                command.Parameters.AddWithValue("@SalePrice", element.SalePrice);
                                command.ExecuteNonQuery();
                            }
                        });
                        transaction.Commit();
                    }
                }
            }
        }

        private int saveDocumentandGetID( Partner partner, Sale sale )
        {
         //   string com = typeof(Company).Name.ToString();
            string BuyerID =null;
            switch (partner.GetType().Name)
            {
                case company:
                    BuyerID = "CompanyID";
                    break;

                case person:
                    BuyerID = "PersonID";
                    break;
                default:
                    break;
            }
            int primaryKey = 0;
            if (sale != null)
            {
                using (SqlConnection con = DBManager.GetConnection())
                {
                    con.Open();
                    string sql =string.Format( @"
        INSERT INTO Document(
             isDelivery
            ,{0}
            ,isPaid
            ,Date
           
)
        OUTPUT INSERTED.ID

        VALUES 
           (@isDelivery
           ,@BuyerID
           ,@isPaid
           ,@Date
            )",BuyerID );
                    using (SqlCommand command = new SqlCommand(sql, con))
                    {
                        command.Parameters.AddWithValue("@isDelivery", false);
                        command.Parameters.AddWithValue("@BuyerID", partner.ID);
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
