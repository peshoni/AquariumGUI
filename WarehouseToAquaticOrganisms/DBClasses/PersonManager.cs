using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseToAquaticOrganisms.Classes;

namespace WarehouseToAquaticOrganisms.DBClasses
{
    public class PersonManager : List<Person>
    {
       // private readonly List<Person> _list = new List<Person>();
        private string ConnectionString;
        public PersonManager() {
           // this._list = new List<Person>();
            ConnectionString = DBManager.GetConnectionString();
            this.AddRange(SelectAllPersons());
        }

        public List<Person> List
        {
            get
            {
                return this;
            }
        }

        public new void Add(Person person )
        {
            base.Add(person);
            InsertPersonIntoDBtablePerson(person);
        }

        public new void Remove( Person person ) {
            base.Remove(person);
            deletePersonFromDB(person);
        }
        //}
        /// <summary>
        /// Insert <see cref="Person"/> into table Person.
        /// </summary>
        /// <param name="person"> Object of type Person </param>
        /// <returns> primaryKey </returns>
        private int InsertPersonIntoDBtablePerson( Person person )
        {
            int primaryKey = 0;
            if (person != null)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"
        INSERT INTO Person(
             Name
            ,EGN
            ,Address
            ,Phone)

        OUTPUT INSERTED.ID

        VALUES 
           (@Name
           ,@EGN
           ,@Address
           ,@Phone)", con))
                    {
                        command.Parameters.AddWithValue("@Name", person.Name);
                        command.Parameters.AddWithValue("@EGN", person.Egn);
                        command.Parameters.AddWithValue("@Address", person.Address);
                        command.Parameters.AddWithValue("@Phone", person.PhoneNumber);
                        primaryKey = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            return primaryKey;
        }
        /// <summary>
        /// Gets all Person entrys from table Person.
        /// </summary>
        /// <returns> List<Person> with Objects </returns>
        private List<Person> SelectAllPersons()
        {
            List<Person> list = new List<Person>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(@"
                        SELECT 
                            ID
                            ,Name
                            ,EGN
                            ,Address
                            ,Phone
                        FROM Person", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Person person = new Person();
                        person.ID = reader.GetInt32(0);
                        person.Name = reader.GetString(1);
                        person.Egn = reader.GetInt32(2);
                        person.Address = reader.GetString(3);
                        person.PhoneNumber = reader.GetString(4);
                        list.Add(person);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// Update <Person> object in DB
        /// </summary>
        /// <param name="person"></param>
        public void updateObjectPropertiesIntoDB( Person person )
        {
           // (_list.Find(element => element.ID == person.ID)).;
            if (person != null)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"
        UPDATE Person SET 
             Name= @Name
            ,EGN = @EGN
            ,Address = @Address
            ,Phone =@Phone
        WHERE 
             ID = @ID;", con))
                    {
                        command.Parameters.AddWithValue("@ID", person.ID);
                        command.Parameters.AddWithValue("@Name", person.Name);
                        command.Parameters.AddWithValue("@EGN", person.Egn); 
                        command.Parameters.AddWithValue("@Address", person.Address);
                        command.Parameters.AddWithValue("@Phone", person.PhoneNumber);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
      
        private void deletePersonFromDB( Person person )
        {
            if (person != null)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(@"DELETE from Person WHERE ID = @ID", con))
                    {
                        command.Parameters.AddWithValue("@ID", person.ID);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        //internal void updateList()
        //{
        //    this.Clear();
        //    this.AddRange(SelectAllPersons());
        //}
    }
}
