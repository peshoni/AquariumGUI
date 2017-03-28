using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseToAquaticOrganisms.Classes;
using WarehouseToAquaticOrganisms.DBClasses; 

namespace Observer
{
    public class DeliveryManager : ObserverPattern
    { 
        private Hashtable _table;
        private int ID;
        private string ConnectionString;
       // private readonly List<DeliveryRow> _deliveryList;
        private readonly List<Delivery> _deliveryList;
        private readonly List<Product> _listWithProducts;
        private CompanyManager _companyManager;

        public DeliveryManager( Warehouse warehouse ,CompanyManager companyManager )
        { 
            this._table = new Hashtable();
            this._warehouse = warehouse;
            this._warehouse.attachObserver(this);
          //  _deliveryList = new List<DeliveryRow>();
            _deliveryList = new List<Delivery>();
            this._listWithProducts = new List<Product>();
            this._companyManager = companyManager;
            ConnectionString = DBManager.GetConnectionString();

            this._deliveryList.AddRange(selectAllDeliveries());
           // this._deliveryList.AddRange(SelectAllCompanies());
            this._listWithProducts.AddRange(getListWithProducts());
        }

        private List<Delivery> selectAllDeliveries()
        {


//            Select ware.ID, product.Name , providers.Name , ware.Quantity, ware.DeliveryPrice, ware.DateTime
//From AquariumDatabase.dbo.Product product, AquariumDatabase.dbo.Provider providers, AquariumDatabase.dbo.Warehouse ware
//where ware.isDelivery = 1 and ware.ProductID = product.ID and ware.ProviderID = providers.ID;
            List<Delivery> list = new List<Delivery>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql =
                    @"Select 
ware.ID
, product.Name 
, providers.Name 
, ware.Quantity
, ware.DeliveryPrice
, ware.DateTime

From AquariumDatabase.dbo.Product product, AquariumDatabase.dbo.Provider providers, AquariumDatabase.dbo.Warehouse ware
where 
ware.isDelivery = 1 and ware.ProductID = product.ID and ware.ProviderID = providers.ID;";

 
                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {                   
                        
                        Delivery delivery = new Delivery( );
                        delivery.Id = reader.GetInt32(0);
                      
                        delivery.ProductName = reader.GetString(1);
                        delivery.ProviderName = reader.GetString(2);
                        delivery.Quantity = reader.GetInt32(3);
                        delivery.Price = reader.GetDecimal(4);

                        list.Add(delivery);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Product> getListWithProducts()
        {
            List<Product> list = new List<Product>();
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
                        Product product = new Product();
                        product.Id = reader.GetInt32(0);
                        product.Name = reader.GetString(1);    
                        list.Add(product);
                    }
                }
            }
            return list;
        }

        //private List<DeliveryRow> SelectAllCompanies()
        //{
        //    List<DeliveryRow> list = new List<DeliveryRow>();
        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {
        //        con.Open();
        //        string sql =  
        //            @"SELECT ID
        //                    ,Provider
        //                    ,Product
        //                    ,Quantity
        //                    ,DeliveryPrice                             
        //                FROM Delivery" ;
        //        using (SqlCommand command = new SqlCommand(sql, con))
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                DeliveryRow row = new DeliveryRow();
        //                row.Id = reader.GetInt32(0);
        //                row.Provider= reader.GetString(1);
        //                row.Product = reader.GetString(2);
        //                row.Quantity= reader.GetInt32(3);
        //                row.Price =  reader.GetDecimal(4);
                        
        //                list.Add(row);
        //            }
        //        }
        //    }
        //    return list;
        //}

        public Hashtable Table
        {
            get
            {
                return _table;
            } 
        }
 
        internal List<Product> ListWithProducts
        {
            get
            {
                return _listWithProducts;
            }
        }

        public List<Delivery> DeliveryList
        {
            get
            {
                return _deliveryList;
            }
        }

        /// <summary>
        /// Adds product into suplylist.
        /// </summary> 
        public override void update()
        {
           // addProduct(_warehouse.Delivery);
        }

        private void addProduct( List<Delivery> delivery)
        {
            if (delivery!=null) {
                Table.Add(++ID, delivery);
                InsertDeliveryIntoDBtableDelivery(delivery);
            } 
        }
        private void InsertDeliveryIntoDBtableDelivery( List<Delivery> delivery )
        {            
            if (delivery != null)
            { 
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    using (var transaction = con.BeginTransaction("DeliveryTransaction"))
                    {
                        // Start a local transaction.                    
                        //// For each...
                        delivery.ForEach(element =>
                        {
                            string comm = @"
        INSERT INTO Warehouse(
             isDelivery
            ,ProviderID
            ,ProductID
            ,Quantity
            ,DeliveryPrice)

        VALUES 
           ( 
            @isDelivery
           ,@ProviderID
           ,@ProductID
           ,@Quantity
           ,@DeliveryPrice)";
                            using (SqlCommand command = new SqlCommand(comm, con))
                            {
                                command.Transaction = transaction;
                                command.Parameters.AddWithValue("@isDelivery", true);
                                command.Parameters.AddWithValue("@ProviderID", element.ProviderID);
                                command.Parameters.AddWithValue("@ProductID", element.ProductID);
                                command.Parameters.AddWithValue("@Quantity", element.Quantity);
                                command.Parameters.AddWithValue("@DeliveryPrice", element.Price);
                                command.ExecuteNonQuery();
                            }
                        }); 
                        transaction.Commit();
                    } 
                }
            } 
        } 
    }
}
