using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseToAquaticOrganisms.DBClasses;

namespace Observer
{
    public class DeliveryManager : Observer 
    { 
        private Hashtable _table;
        private int ID;
        private string ConnectionString;
        private readonly List<DeliveryRow> deliveryList;

        public DeliveryManager( Warehouse warehouse )
        { 
            this._table = new Hashtable();
            this._warehouse = warehouse;
            this._warehouse.attachObserver(this);
            deliveryList = new List<DeliveryRow>();
            
            ConnectionString = DBManager.GetConnectionString();
            this.deliveryList.AddRange(SelectAllCompanies());
        }
        private List<DeliveryRow> SelectAllCompanies()
        {
            List<DeliveryRow> list = new List<DeliveryRow>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql =  
                    @"SELECT ID
                            ,Provider
                            ,Product
                            ,Quantity
                            ,DeliveryPrice                             
                        FROM Delivery" ;
                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DeliveryRow row = new DeliveryRow();
                        row.Id = reader.GetInt32(0);
                        row.Provider= reader.GetString(1);
                        row.Product = reader.GetString(2);
                        row.Quantity=   reader.GetInt32(3)  ;
                        row.Price =  reader.GetDecimal(4);
                        
                        list.Add(row);
                    }
                }
            }
            return list;
        }

        public Hashtable Table
        {
            get
            {
                return _table;
            } 
        }

        public List<DeliveryRow> DeliveryList
        {
            get
            {
                return deliveryList;
            }
        }

        /// <summary>
        /// Adds product into suplylist.
        /// </summary> 
        public override void update()
        {
            addProduct(_warehouse.Delivery);
        }

        private void addProduct( DeliveryRow delivery)
        {
            if (delivery!=null) {
                Table.Add(++ID, delivery);
                InsertDeliveryIntoDBtableDelivery(delivery);
            } 
        }
        private int InsertDeliveryIntoDBtableDelivery( DeliveryRow delivery )
        {
            int primaryKey = 0;
            if (delivery != null)
            { 
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    string comm = @"
        INSERT INTO Delivery(
                Provider
            ,Product
            ,Quantity
            ,DeliveryPrice)

         OUTPUT INSERTED.ID

        VALUES 
           ( @Provider
           ,@Product
           ,@Quantity
           ,@DeliveryPrice)";
                    using (SqlCommand command = new SqlCommand(comm, con))
                    {
                       
                        command.Parameters.AddWithValue("@Provider", delivery.Provider);
                        command.Parameters.AddWithValue("@Product", delivery.Product);
                        command.Parameters.AddWithValue("@Quantity", delivery.Quantity);
                        command.Parameters.AddWithValue("@DeliveryPrice", delivery.Price);
                        primaryKey = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
           return primaryKey;
        }
      
    }
}
