using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace DAL
{
    public class DBConnection
    {
        public static SQLiteConnection GetDBConnection()
        {
            SQLiteConnection con = new SQLiteConnection();
            string path = Directory.GetCurrentDirectory().ToString() + @"\db.sqlite";
            con.ConnectionString = "Data Source=" + path + ";Version=3;";
            Console.WriteLine(path);
            return con;
        }
    }
}
