using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{

    public class Ventas
    {
        ConexionBD conn = new ConexionBD();
        public void insertarProductosVenta(string nombre,string marca,string codigoventa,int cantidad,double subtotal)
        {
            try
            {
                SqlCommand addProd = new SqlCommand("GenerarProductosVenta", conn.Connection);
                addProd.CommandType = CommandType.StoredProcedure;
                    addProd.Parameters.AddWithValue("@producto", nombre);
                    addProd.Parameters.AddWithValue("@marca", marca);
                    addProd.Parameters.AddWithValue("@venta", codigoventa);
                    addProd.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
                    addProd.Parameters.Add("@subtotal", SqlDbType.Float).Value = subtotal;
                
                conn.OpenConnection();

                addProd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            /*
            agregar.Parameters.Clear();

            agregar.Parameters.AddWithValue("@clave", Convert.ToString(row.Cells["Column1"].Value));
            agregar.Parameters.AddWithValue("@nombre", Convert.ToString(row.Cells["Column2"].Value));
            agregar.Parameters.AddWithValue("@apellido", Convert.ToString(row.Cells["Column3"].Value));

            agregar.ExecuteNonQuery();
            */
        }

        public void insertarVenta(string codigo,string fecha,double subtotal,double total,string cliente,string correo,string vendedor)
        {
            try
            {
                
                SqlCommand addProd = new SqlCommand("GenerarVenta", conn.Connection);
                addProd.CommandType = CommandType.StoredProcedure;
                addProd.Parameters.Clear();
                    addProd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                    addProd.Parameters.Add("@fecha", SqlDbType.VarChar).Value = fecha;
                    addProd.Parameters.Add("@subtotal", SqlDbType.Float).Value = subtotal;
                
                    addProd.Parameters.Add("@cliente", SqlDbType.VarChar).Value = cliente;
                    addProd.Parameters.Add("@correo", SqlDbType.VarChar).Value = correo;
                    addProd.Parameters.Add("@vendedor", SqlDbType.VarChar).Value = vendedor;
                    addProd.Parameters.Add("@totalv", SqlDbType.Float).Value = total;

                conn.OpenConnection();

                addProd.ExecuteNonQuery();

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
        public DataTable verVentas()
        {
            try
            {
                SqlCommand lstCliente = new SqlCommand("verVentas", conn.Connection);
                lstCliente.CommandType = CommandType.StoredProcedure;

                conn.OpenConnection();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(lstCliente);
                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                DataTable dtex = new DataTable();
                Console.WriteLine(ex.Message);
                return dtex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }


    }
}
