using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Entities;

namespace DAL
{
    public class UsersDAL
    {
        SQLiteConnection con = DBConnection.GetDBConnection();

        public string Login(string username)
        {
            try
            {
                con.Open();
                string query = "SELECT password FROM users WHERE username=@username LIMIT 1";
                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetValue(0).ToString();
                    }
                }

                return "";
            }
            catch
            {
                return "";
            }
            finally
            {
                con.Close();
            }
        }
    }
}
