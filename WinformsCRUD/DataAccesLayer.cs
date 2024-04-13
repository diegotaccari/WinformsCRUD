using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
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

        public void InsertContac(Contact contact)
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
                SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter Adress = new SqlParameter("@Adress", contact.Address);

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
        public void UpdateContact(Contact contact)
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
            finally { data.Close(); }
        }

        public void DeleteContact(int id)
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
            finally { data.Close(); }
        }
        public List<Contact> GetContacts(string search = null)
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                data.Open();
                string query = @" SELECT Id, FirstName, LastName, Phone,Address
                                      FROM Contacts ";
                SqlCommand command = new SqlCommand(query, data);
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
                        LastName = reader["LastName"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString()
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
        public void InsertProductoc(Productoc productoc)
        {
            try
            {
                data.Open();
                string query = @"
                                 INSERT INTO Productocs (Denominacion, PrecioVenta, PrecioCosto, Stock)
                                 VALUES ( @Denominacion, @PrecioVenta, @PrecioCosto, @Stock)";

                SqlParameter denominacion = new SqlParameter("@Denominacion", productoc.Denominacion);
                SqlParameter precioVenta = new SqlParameter("@PrecioVenta", productoc.PrecioVenta);
                SqlParameter precioCosto = new SqlParameter("@PrecioCosto", productoc.PrecioCosto);
                SqlParameter stock = new SqlParameter("@Stock", productoc.Stock);

                SqlCommand command = new SqlCommand(query, data);
                command.Parameters.Add(denominacion);
                command.Parameters.Add(precioVenta);
                command.Parameters.Add(precioCosto);
                command.Parameters.Add(stock);

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
        public List<Productoc> GetProductoc(string search = null)
        {
            List<Productoc> productocs = new List<Productoc>();
            try
            {
                data.Open();
                string query = @" SELECT Id,Denominacion, PrecioVenta, PrecioCosto, Stock 
                                FROM Productocs";
                SqlCommand command = new SqlCommand();
                if (!string.IsNullOrEmpty(search))
                {
                    query += @" WHERE Denominacion LIKE @Search 
                        OR CAST(PrecioVenta AS VARCHAR) LIKE @Search 
                        OR CAST(PrecioCosto AS VARCHAR) LIKE @Search 
                        OR CAST(Stock AS VARCHAR) LIKE @Search";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }
                command.CommandText = query;
                command.Connection = data;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productocs.Add(new Productoc
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Denominacion = reader["Denominacion"].ToString(),
                        PrecioVenta = decimal.Parse(reader["PrecioVenta"].ToString()),
                        PrecioCosto = decimal.Parse(reader["PrecioCosto"].ToString()),
                        Stock = int.Parse(reader["Stock"].ToString()),
                    });
                }



            }
            catch (Exception)
            {

                throw;
            }
            finally { data.Close(); }
            return productocs;
        }
        public void UpdateProductoc(Productoc productoc)
        {
            try
            {
                data.Open();
                string query = @"UPDATE Productocs
                                 SET Denominacion = @Denominacion,
                                     PrecioVenta = @PrecioVenta,
                                     PrecioCosto = @PrecioCosto,
                                     Stock = @Stock
                                 WHERE Id = @Id ";
                SqlParameter id = new SqlParameter("@Id", productoc.Id);
                SqlParameter denominacion = new SqlParameter("@Denominacion", productoc.Denominacion);
                SqlParameter precioVenta = new SqlParameter("@PrecioVenta", productoc.PrecioVenta);
                SqlParameter precioCosto = new SqlParameter("@PrecioCosto", productoc.PrecioCosto);
                SqlParameter stock = new SqlParameter("@Stock", productoc.Stock);

                SqlCommand command = new SqlCommand(query, data);
                command.Parameters.Add(id);
                command.Parameters.Add(denominacion);
                command.Parameters.Add(precioVenta);
                command.Parameters.Add(precioCosto);
                command.Parameters.Add(stock);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { data.Close(); }
        }


        public void DeleteProduct(int id)
        {
            try
            {
                data.Open();
                string query = @"DELETE FROM Productocs WHERE Id = @Id ";
                SqlCommand command = new SqlCommand(query, data);
                command.Parameters.Add(new SqlParameter("@Id", id));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { data.Close(); }
        }

        public class ProductoDAL
        {
            private string cadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=DESKTOP-AJ848G2";

            public void ActualizarPrecios(decimal factorAumento)
            {
                string consultaActualizacion = "UPDATE Productocs SET PrecioVenta = PrecioVenta * @FactorAumento";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(consultaActualizacion, conexion))
                    {
                        comando.Parameters.AddWithValue("@FactorAumento", factorAumento);

                        try
                        {
                            conexion.Open();
                            comando.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception($"Error en DAL al actualizar precios: {ex.Message}");
                        }
                    }
                }
            }

        }
        public class ProductoDALPC
        {
            private string cadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=DESKTOP-AJ848G2";

            public void ActualizarPreciosPrecioCosto(decimal factorAumento)
            {
                string consultaActualizacion = "UPDATE Productocs SET PrecioCosto = PrecioCosto * @FactorAumento";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(consultaActualizacion, conexion))
                    {
                        comando.Parameters.AddWithValue("@FactorAumento", factorAumento);

                        try
                        {
                            conexion.Open();
                            comando.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception($"Error en DAL al actualizar precios: {ex.Message}");
                        }
                    }
                }
            }

        }
    }
}
