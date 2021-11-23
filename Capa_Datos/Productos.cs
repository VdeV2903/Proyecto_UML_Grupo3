using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class Productos
    {
        ConexionBD conn = new ConexionBD();
        public DataTable verProductos()
        {
            try
            {
                SqlCommand lstCliente = new SqlCommand("VerProductos", conn.Connection);
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
                dtex.Rows.Add(0, ex);
                return dtex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
        public DataTable cargarProductos()
        {
            try
            {
                SqlCommand lstCliente = new SqlCommand("cargarProductos", conn.Connection);
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
                dtex.Rows.Add(0, ex);
                return dtex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
        public DataTable ventaProductos()
        {
            try
            {
                SqlCommand lstCliente = new SqlCommand("VerProductosVenta", conn.Connection);
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
                dtex.Rows.Add(0, ex);
                return dtex;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
        private string ID_C = "";
        public string verificarProducto(string nombre,string marca)
        {
            try
            {
                SqlCommand idcl = new SqlCommand("VerificarProducto", conn.Connection);
                idcl.CommandType = CommandType.StoredProcedure;
                    idcl.Parameters.AddWithValue("@nombre", nombre);
                    idcl.Parameters.AddWithValue("@marca", marca);

                conn.OpenConnection();

                ID_C = Convert.ToString(idcl.ExecuteScalar());
                return ID_C;
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
        public void insertarProducto(string nombreProd,string marcaProd,string proveedor,string categoria,double preciocom,double precioven)//faltan parametros
        {
            try
            {
                SqlCommand addProd = new SqlCommand("insertarProducto", conn.Connection);
                addProd.CommandType = CommandType.StoredProcedure;
                    addProd.Parameters.AddWithValue("@nombre", nombreProd);
                    addProd.Parameters.AddWithValue("@marca", marcaProd);
                    addProd.Parameters.AddWithValue("@distribuidor", proveedor);
                    addProd.Parameters.AddWithValue("@categoria", categoria);
                    addProd.Parameters.AddWithValue("@precioc", preciocom);
                    addProd.Parameters.AddWithValue("@preciov", precioven);

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
        public void modificarProducto(int ID, string nombreProd, string marcaProd, string proveedor, string categoria, string preciocom, string precioven)//faltan parametros
        {
            try
            {
                SqlCommand addProd = new SqlCommand("modificarProducto", conn.Connection);
                addProd.CommandType = CommandType.StoredProcedure;
                    addProd.Parameters.AddWithValue("@ID", ID);
                    addProd.Parameters.AddWithValue("@nombre", nombreProd);
                    addProd.Parameters.AddWithValue("@marca", marcaProd);
                    addProd.Parameters.AddWithValue("@proveedor", proveedor);
                    addProd.Parameters.AddWithValue("@categoria", categoria);
                    addProd.Parameters.AddWithValue("@precioc", preciocom);
                    addProd.Parameters.AddWithValue("@preciov", precioven);

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
        public void eliminarProducto(int ID)
        {
            try
            {
                SqlCommand delProd = new SqlCommand("eliminarProducto", conn.Connection);
                delProd.CommandType = CommandType.StoredProcedure;
                    delProd.Parameters.AddWithValue("@ID", ID);
                
                conn.OpenConnection();

                delProd.ExecuteNonQuery();

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
