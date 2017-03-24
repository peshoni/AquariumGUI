using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquariumGUI;
using WarehouseToAquaticOrganisms.Contragents;

namespace WarehouseToAquaticOrganisms.DBClasses
{
    public class DeliveryManager2
    {
        private string ConnectionString;
        public DeliveryManager2() {
            ConnectionString = DBUtill.GetConnectionString();
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
                string sql = String.Format(@"Select  
prod.Name 
,row.Quantity 
                    from 
                        Document doc, RowOfDocuments row ,Product prod, Provider pro
                    where 
                       row.DocumentID = {0} and doc.ID = row.DocumentID and row.ProductID = prod.ID and doc.ProviderID=pro.ID;", DocID); 
                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    { 
                        TestDeliveryClass test = new TestDeliveryClass();
                        test.ProductName = reader.GetString(0);
                        test.Quantity = reader.GetInt32(1);

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
Select  
doc.ID,
pro.Name,
row.Quantity,
doc.Date,
pro.Name,
pro.Account_person,
pro.Bulstat,
pro.Phone,
doc.isPaid
 from  Document doc, RowOfDocuments row ,Product prod, Provider pro
 where   
doc.isDelivery=1 and doc.ID = row.DocumentID and row.ProductID = prod.ID and doc.ProviderID=pro.ID;

";

                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TestDeliveryClass test = new TestDeliveryClass();
                        
                        test.DocID = reader.GetInt32(0);
                        test.ProviderName = reader.GetString(1);

                         //test.ProviderName = reader.GetString(3);
                        test.AccountablePerson = reader.GetString(5);
                        test.Bulstat = reader.GetString(6);
                        test.Phone = reader.GetString(7);
                        test.IsPaid = reader.GetBoolean(8);
                        list.Add(test);
                    }
                }
            }
            return list;
        }
    }
}
