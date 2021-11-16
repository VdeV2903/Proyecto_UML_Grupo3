using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class Empleados
    {
        ConexionBD conn = new ConexionBD();
        public DataTable VerEmpleados(string word, string estado)
        {
            try
            {
                SqlCommand lstCliente = new SqlCommand("VerEmpleados", conn.Connection);
                lstCliente.CommandType = CommandType.StoredProcedure;
                lstCliente.Parameters.AddWithValue("@word", word);
                lstCliente.Parameters.AddWithValue("@filtro", estado);

                conn.OpenConnection();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(lstCliente);
                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                DataTable dtex = new DataTable();
                dtex.Rows.Add(0, ex);
                return dtex;
            }
            finally
            {
                conn.CloseConnection();
            }

        }
    }
}
