using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace LibrarySystem
{
    class dbConnect
    {
        public static string connectString = "datasource=127.0.0.1; port = 3306;username = root; password=; database=dbLibrary; convert zero datetime=True;";

        public static MySqlConnection con = new MySqlConnection(connectString);

        public static MySqlDataReader sdr;

        public static MySqlCommand com;


        public static void isOpen()
        {
            if (dbConnect.con != null && dbConnect.con.State == ConnectionState.Open)
            {
                dbConnect.con.Close();
            }
        }
    }
}
