using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer;

namespace WarehouseToAquaticOrganisms.DBClasses
{
   public class SaleManager 
    {
        public SaleManager() {

        }
        public List<Sale> getList()
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
   doc.CompanyID IS NOT NULL and doc.CompanyID = com.ID

 "; 
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
        /// <summary>
        /// Gets rows for given document.
        /// </summary>
        /// <param name="DocID">Id of the document.</param>
        /// <returns></returns>
        public List<Sale> getListWithSaleDetails( int DocID )
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
    }
}
