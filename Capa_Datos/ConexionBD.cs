using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class ConexionBD
    {
        private string con = "Data Source=DESKTOP-D997A5M;Initial Catalog=Tec_Shop_UMLG3;Integrated Security=True";

        private SqlConnection connection;

        public SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(con);
                }
                return connection;
            }
        }

        public void OpenConnection()
        {
            Connection.Open();
        }

        public void CloseConnection()
        {
            Connection.Close();
        }
    }
}
