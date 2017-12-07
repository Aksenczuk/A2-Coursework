using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace A2_Courswork.Classes
{
    public class Database
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader rdr;

        public Database()
        { }

        public bool connect()
        {
            SqlConnectionStringBuilder scStrBuild = new SqlConnectionStringBuilder(); //Declare and initialise object

            //Sets properties of the object to the database 
            scStrBuild.DataSource = "(LocalDB)\\v11.0";
            scStrBuild.AttachDBFilename = "|DataDirectory|Database.mdf";
            scStrBuild.IntegratedSecurity = true;

            conn = new SqlConnection(scStrBuild.ToString());

            try
            {
                conn.Open(); //open a SqlConnection
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            if (conn.State == System.Data.ConnectionState.Open)
                return true; //return true if able to open
            else
                return false; //return false if not
        }

        public SqlCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public SqlDataReader Rdr
        {
            get { return rdr; }
            set { rdr = value; }
        }
    }
}
