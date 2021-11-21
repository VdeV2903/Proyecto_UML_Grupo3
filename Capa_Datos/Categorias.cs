using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Capa_Datos
{
    public class Categorias
    {
        ConexionBD conn = new ConexionBD();
        public DataTable verCategorias()
        {
            try
            {
                SqlCommand lstCliente = new SqlCommand("VerCategorias", conn.Connection);
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
        public string verificarCategoria(string nombre)
        {
            try
            {
                SqlCommand idcl = new SqlCommand("VerificarCategoria", conn.Connection);
                idcl.CommandType = CommandType.StoredProcedure;
                    idcl.Parameters.AddWithValue("@nombre", nombre);
                
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
        public DataTable cargarCategorias()
        {
            try
            {
                SqlCommand addCat = new SqlCommand("CargarCategorias", conn.Connection);
                addCat.CommandType = CommandType.StoredProcedure;
                

                conn.OpenConnection();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(addCat);
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
        public void insertarCategoria(string nombrecat)
        {
            try
            {
                SqlCommand addCat= new SqlCommand("AnadirCategoria", conn.Connection);
                addCat.CommandType = CommandType.StoredProcedure;
                    addCat.Parameters.AddWithValue("@nombre", nombrecat);

                conn.OpenConnection();

                addCat.ExecuteNonQuery();


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
        public void modificarCategoria(string ID,string nombre,string estado)
        {
            try
            {
                SqlCommand modcat = new SqlCommand("EditarCategoria", conn.Connection);
                modcat.CommandType = CommandType.StoredProcedure;
                    modcat.Parameters.AddWithValue("@ID", ID);
                    modcat.Parameters.AddWithValue("@nombre", nombre);
                    modcat.Parameters.AddWithValue("@estado", estado);

                conn.OpenConnection();

                modcat.ExecuteNonQuery();

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
        public void eliminarCategoria(string ID)
        {
            try
            {
                SqlCommand delCat = new SqlCommand("EliminarCategoria", conn.Connection);
                delCat.CommandType = CommandType.StoredProcedure;
                    delCat.Parameters.AddWithValue("@ID", ID);

                conn.OpenConnection();

                delCat.ExecuteNonQuery();

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
