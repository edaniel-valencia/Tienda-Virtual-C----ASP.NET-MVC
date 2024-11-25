using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;

using MySql.Data.MySqlClient; 
using System.Data;
using System.Collections;



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
                                Ureset = Convert.ToBoolean(dr["Ureset"]),
                                Ustatus = Convert.ToBoolean(dr["Ustatus"])
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
    }
}
