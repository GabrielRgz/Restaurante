using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace Restaurante
{
    public class Conexion
    {
        SqlConnection connection;

        public void Open() 
        {
            try
            {
                string servidor = Dns.GetHostName();

                connection = new SqlConnection("Data Source=DESKTOP-LCJJNOH\\SQLEXPRESS;Initial Catalog=MojodojoDB;Integrated Security=True");

                connection.Open();
                //MessageBox.Show(servidor);
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public void Close() 
        { 
            connection.Close();
        }

        public SqlConnection cadena() 
        {
            return connection;
        }
    }
}
