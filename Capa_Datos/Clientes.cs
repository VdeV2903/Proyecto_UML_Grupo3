using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    
    public class Clientes
    {

        ConexionBD conn = new ConexionBD();
        public DataTable ListaClientes(string word,string estado)
        {
            try
            {
                SqlCommand lstCliente = new SqlCommand("VerClientes", conn.Connection);
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
        private string ID = "";
        
        public string traerID(string cliente, string correop)
        {
            try
            {
                SqlCommand idcl = new SqlCommand("traerIDCliente", conn.Connection);
                idcl.CommandType = CommandType.StoredProcedure;
                    idcl.Parameters.AddWithValue("@nombre", cliente);
                    idcl.Parameters.AddWithValue("@correop", correop);
                conn.OpenConnection();

                ID = Convert.ToString(idcl.ExecuteScalar());
                return ID;
            }
            catch(SqlException ex)
            {
                return ex.Message;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
        private int OKInsert = 0;
        public int verificarCliente(string nombre,string correo)
        {
            try
            {
                SqlCommand vericli = new SqlCommand("AnadirCliente", conn.Connection);
                vericli.CommandType = CommandType.StoredProcedure;
                    vericli.Parameters.AddWithValue("@nombre", nombre);
                    vericli.Parameters.AddWithValue("@correo", correo);

                conn.OpenConnection();
                         
                OKInsert = Convert.ToInt32(vericli.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                conn.CloseConnection();
            }
            return OKInsert;
        }
        public void insertarCliente(string nombre,string telefono, string correo)
        {
            try
            {
                SqlCommand idinse = new SqlCommand("AnadirCliente", conn.Connection);
                idinse.CommandType = CommandType.StoredProcedure;
                    idinse.Parameters.AddWithValue("@nombre", nombre);
                    idinse.Parameters.AddWithValue("@telefono", telefono);
                    idinse.Parameters.AddWithValue("@correo", correo);

                conn.OpenConnection();

                idinse.ExecuteScalar();

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
        
        public void ActualizarCliente(int IDc,string nombre, string tel, string correo,string estado)
        {
            try
            {
                SqlCommand idact = new SqlCommand("ActualizarCliente", conn.Connection);
                idact.CommandType = CommandType.StoredProcedure;
                    idact.Parameters.AddWithValue("@ID", IDc);
                    idact.Parameters.AddWithValue("@nombre", nombre);
                    idact.Parameters.AddWithValue("@telefono", tel);
                    idact.Parameters.AddWithValue("@correo", correo);
                    idact.Parameters.AddWithValue("@estado", estado);
                    

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
