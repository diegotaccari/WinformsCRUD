using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace WinformsCRUD
{ 
    public class DataAccesLayer
    {
        private SqlConnection data = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=DESKTOP-AJ848G2");
        
        public void InsertContac (Contact contact) 
        {
            try
            {
                data.Open();
                string query = @"INSERT INTO Contacts ( FirstName, LastName, Phone,Address)
                                VALUES (@FirstName, @LastName, @Phone, @Adress)";
                //declarar parametro forma larga
                SqlParameter firstName = new SqlParameter();
                firstName.ParameterName = "@FirstName";
                firstName.Value = contact.FirstName;
                firstName.DbType = System.Data.DbType.String; 
                // forma corta parametros 
                SqlParameter lastName  = new SqlParameter("@LastName",contact.LastName);
                SqlParameter phone  = new SqlParameter("@Phone",contact.Phone);
                SqlParameter Adress  = new SqlParameter("@Adress",contact.Address);

                SqlCommand command = new SqlCommand(query, data);
                command.Parameters.Add(firstName); 
                command.Parameters.Add(lastName); 
                command.Parameters.Add(phone); 
                command.Parameters.Add(Adress); 

                command.ExecuteNonQuery();

            }   
                
            catch (Exception)
            {

                throw;
            }
            finally
            {
                data.Close();
            }
        
        }
        public void  UpdateContact (Contact contact)
        {
            try
            {
                 data.Open();
                string query = @" UPDATE Contacts 
                                   SET  FirstName = @Firstname,
                                        LastName = @Lastname,
                                        Phone = @Phone,
                                        Address = @Address
                                        WHERE Id = @Id";
                SqlParameter Id = new SqlParameter("@Id", contact.Id);
                SqlParameter FirstName = new SqlParameter("@FirstName", contact.FirstName);
                SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter Address = new SqlParameter("@Address", contact.Address);

                SqlCommand command = new SqlCommand(query, data);
                command.Parameters.Add(Id);
                command.Parameters.Add(FirstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(Address);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { data.Close();}
        }

        public void DeleteContact (int id)
        {
            try
            {
                data.Open();
                String query = @"DELETE FROM Contacts WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, data);
                command.Parameters.Add(new SqlParameter("@Id", id));
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { data.Close();}    
        }
        public List<Contact> GetContacts(string search = null)
        {
           List<Contact> contacts = new List<Contact>();    
            try
            {
                data.Open();
                string query = @" SELECT Id, FirstName, LastName, Phone,Address
                                      FROM Contacts ";
                SqlCommand command = new SqlCommand (query, data);
                if (!string.IsNullOrEmpty(search)) 
                {
                    query += @" WHERE FirstName LIKE @Search OR 
                                      LastName LIKE @Search OR 
                                      Phone LIKE @Search  OR   
                                      Address LIKE @Search ";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                } 
                command.CommandText = query;
                command.Connection = data; 


                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    contacts.Add(new Contact
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString (),
                        Phone = reader["Phone"].ToString (),
                        Address = reader["Address"].ToString ()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                data.Close();
            }
            return contacts;
        }


   
    }

}
