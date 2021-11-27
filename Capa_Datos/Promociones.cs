using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class Promociones
    {
        ConexionBD conn = new ConexionBD();

        public DataTable listaPromos(string word)
        {
            try
            {
                SqlCommand lstCliente = new SqlCommand("verPromos", conn.Connection);
                lstCliente.CommandType = CommandType.StoredProcedure;
                lstCliente.Parameters.AddWithValue("@word", word);

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
        public void crearPromo(int ID, string nombre, string fechafin, double precioa,double porcentaje,double precion)
        {
            try
            {
                SqlCommand idact = new SqlCommand("crearPromo", conn.Connection);
                idact.CommandType = CommandType.StoredProcedure;              
                idact.Parameters.AddWithValue("@nombrepromo", nombre);
                idact.Parameters.AddWithValue("@fechafin", fechafin);
                idact.Parameters.Add("@precioanterior",SqlDbType.Float).Value = precioa;
                idact.Parameters.Add("@porcentaje", SqlDbType.Float).Value = porcentaje;
                idact.Parameters.Add("@nuevoprecio", SqlDbType.Float).Value = precion;
                idact.Parameters.AddWithValue("@ID", ID);


                conn.OpenConnection();

                idact.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }
        public void eliminarPromo(string ID)
        {
            try
            {
                SqlCommand idact = new SqlCommand("eliminarPromo", conn.Connection);
                idact.CommandType = CommandType.StoredProcedure;               
                idact.Parameters.AddWithValue("@ID", ID);

                conn.OpenConnection();

                idact.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }
    }
}
