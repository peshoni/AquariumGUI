using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WarehouseToAquaticOrganisms.Classes;

namespace WarehouseToAquaticOrganisms.DBClasses
{
   public class CompanyManager:List<Company>
    { 
        private string ConnectionString;
        private const string TABLE_PROVIDER = "Provider";
        private const string TABLE_COMPANY="Company";
        private bool _isProvider;
        private string _tableName; 

        public CompanyManager(bool isProvider)
        {
            this._isProvider = isProvider; 
            this._tableName = (_isProvider ? TABLE_PROVIDER : TABLE_COMPANY);
            ConnectionString = DBManager.GetConnectionString();
            this.AddRange(SelectAllCompanies());
        }

        public List<Company> List
        {
            get
            {
                return this;
            }
        }
 

        public new void Add( Company company )
        {
            base.Add(company);
            InsertCompanyIntoDBtablePerson(company);
        }

        public new void Remove( Company company )
        { 
            base.Remove(company); 
            deleteCompanyFromDB(company);
        }
        //}
        /// <summary>
        /// Insert <see cref="Company"/> into table Person.
        /// </summary>
        /// <param name="person"> Object of type <see cref="Company"/> </param>
        /// <returns> primaryKey </returns>
        private int InsertCompanyIntoDBtablePerson( Company company )
        { 
            int primaryKey = 0;
            if (company != null)
            {                
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string sql = string.Format(@"
        INSERT INTO {0}(
             Name
            ,Bulstat
            ,Account_person
            ,Address
            ,Phone)

        OUTPUT INSERTED.ID

        VALUES 
           (@Name
           ,@Bulstat
           ,@Account_person
           ,@Address
           ,@Phone)", _tableName); 
                    using (SqlCommand command = new SqlCommand(sql, con))
                    { 
                        command.Parameters.AddWithValue("@Name", company.Name);
                        command.Parameters.AddWithValue("@Bulstat", company.Bulstat);                       
                        command.Parameters.AddWithValue("@Account_person", company.AcountablePerson);
                        command.Parameters.AddWithValue("@Address", company.Address);
                        command.Parameters.AddWithValue("@Phone", company.PhoneNumber);
                        primaryKey = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            return primaryKey;
        }
        /// <summary>
        /// Gets all Companies entrys from table Company.
        /// </summary>
        /// <returns> List<Company> with Objects </returns>
        private List<Company> SelectAllCompanies()
        {
            List<Company> list = new List<Company>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string sql = string.Format(
                    @"SELECT ID
                            ,Name
                            ,Bulstat
                            ,Account_person
                            ,Address
                            ,Phone
                        FROM {0}"
                   ,_tableName);
                using (SqlCommand command = new SqlCommand(sql, con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Company company = new Company();
                        company.ID = reader.GetInt32(0);
                        company.Name = reader.GetString(1);
                        company.Bulstat = reader.GetString(2);
                        company.AcountablePerson = reader.GetString(3); 
                        company.Address = reader.GetString(4);
                        company.PhoneNumber = reader.GetString(5);
                        list.Add(company);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Update <Company> object in DB
        /// </summary>
        /// <param name="person"></param>
        public void updateObjectPropertiesIntoDB( Company company )
        {
            // (_list.Find(element => element.ID == person.ID)).;
            if (company != null)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string sql = string.Format(
                    @"UPDATE {0} SET 
                         Name= @Name
                        ,Bulstat = @Bulstat 
                        ,Account_person = @Account_person
                        ,Address = @Address
                        ,Phone =@Phone
                    WHERE 
                         ID = @ID;", _tableName);
                    using (SqlCommand command = new SqlCommand(sql, con))
                    {
                        command.Parameters.AddWithValue("@ID", company.ID);
                        command.Parameters.AddWithValue("@Name", company.Name);
                        command.Parameters.AddWithValue("@Bulstat", company.Bulstat);
                        command.Parameters.AddWithValue("@Account_person", company.AcountablePerson);
                        command.Parameters.AddWithValue("@Address", company.Address);
                        command.Parameters.AddWithValue("@Phone", company.PhoneNumber);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void deleteCompanyFromDB( Company company )
        {
            if (company != null)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = string.Format(@"DELETE from {0} WHERE ID = @ID",_tableName);
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@ID", company.ID);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        internal void updateList()
        {
            this.Clear();
            this.AddRange(SelectAllCompanies()); 
        } 
    }
}
