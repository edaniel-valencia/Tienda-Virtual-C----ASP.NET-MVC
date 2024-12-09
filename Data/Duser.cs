using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;

using MySql.Data.MySqlClient; 
using System.Data;
using System.Collections;
using System.Data.SqlTypes;
using System.Data.SqlClient;



namespace Data
{
    public class Duser
    {
        public List<User> ListUser() {
            List<User> list = new List<User>();
            try{
                using (MySqlConnection oconexion = new MySqlConnection(Connection.conexion))
                {
                    //string query = "SELECT Uid, Uname, Ulastname, Uemail, Uphone, Upassword, Ureset, Ustatus FROM user";
                    //MySqlCommand cmd = new MySqlCommand(query, oconexion); 
                    //cmd.CommandType = CommandType.Text;
                    //oconexion.Open();
                    string query = "SELECT Uid, Uname, Ulastname, Uemail, Uphone, Upassword, Ureset, Ustatus FROM user";
                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read())
                        {
                            list.Add(new User(){
                                Uid = Convert.ToInt32(dr["Uid"]),
                                Uname = dr["Uname"].ToString(),
                                Ulastname = dr["Ulastname"].ToString(),
                                Uemail = dr["Uemail"].ToString(),
                                Uphone= dr["Uphone"].ToString(),
                                Upassword= dr["Upassword"].ToString(),
                                Ureset = Convert.ToInt32(dr["Ureset"]),
                                Ustatus = Convert.ToInt32(dr["Ustatus"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { 
                Console.WriteLine($"Error: {ex.Message}");
                list = new List<User>();
            }

            return list;
        }


        public int Create(User obj, out string Message)
        {
            int idAutoIncrement = 0;
            Message = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Connection.conexion))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_CreateUser", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros de entrada
                    cmd.Parameters.AddWithValue("Uname", obj.Uname);
                    cmd.Parameters.AddWithValue("Ulastname", obj.Ulastname);
                    cmd.Parameters.AddWithValue("Uemail", obj.Uemail);
                    cmd.Parameters.AddWithValue("Uphone", obj.Uphone);
                    cmd.Parameters.AddWithValue("Upassword", obj.Upassword);
                    cmd.Parameters.AddWithValue("Ustatus", obj.Ustatus);

                    // Agregar los parámetros de salida
                    cmd.Parameters.Add("Result", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Message", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    // Ejecutar el comando
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    // Recuperar los valores de los parámetros de salida
                    idAutoIncrement = Convert.ToInt32(cmd.Parameters["Result"].Value);
                    Message = cmd.Parameters["Message"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idAutoIncrement = 0;
                Message = $"Error al ejecutar el procedimiento: {ex.Message}";
            }

            return idAutoIncrement;
        }



        public bool Edit(User obj, out string Message)
        {

            bool Result = false;
            Message = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Connection.conexion))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_EditUser", oconexion);
                    cmd.Parameters.AddWithValue("Uid", obj.Uid);
                    cmd.Parameters.AddWithValue("Uname", obj.Uname);
                    cmd.Parameters.AddWithValue("Ulastname", obj.Ulastname);
                    cmd.Parameters.AddWithValue("Uemail", obj.Uemail);
                    cmd.Parameters.AddWithValue("Uphone", obj.Uphone);
                    cmd.Parameters.AddWithValue("Ustatus", obj.Ustatus);
                    cmd.Parameters.Add("Result", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Message", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();


                    Result = Convert.ToBoolean(cmd.Parameters["Result"].Value);
                    Message = cmd.Parameters["Message"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Result = false;
                Message = ex.Message;
            }

            return Result;
        }
        public bool Delete(int Uid, out string Message)
        {

            bool Result = false;
            Message = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Connection.conexion))
                {
                    MySqlCommand cmd = new MySqlCommand("Delete top (1) from user where Uid = @Uid", oconexion);
                    cmd.Parameters.AddWithValue("Uid", Uid);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    Result = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                Result = false;
                Message = ex.Message;
            }

            return Result;
        }
    }
}
