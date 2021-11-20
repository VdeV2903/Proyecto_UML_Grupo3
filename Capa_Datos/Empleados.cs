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
        private string ID = "";
        public string traerID(string cliente, string correop)
        {
            try
            {
                SqlCommand idcl = new SqlCommand("traerIDEmpleado", conn.Connection);
                idcl.CommandType = CommandType.StoredProcedure;
                idcl.Parameters.AddWithValue("@nombre", cliente);
                idcl.Parameters.AddWithValue("@correop", correop);
                conn.OpenConnection();

                ID = Convert.ToString(idcl.ExecuteScalar());
                return ID;
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
        private int OKInsert = 0;
        public int verificarEmpleado(string nombre, string correo)
        {
            try
            {
                SqlCommand vericli = new SqlCommand("VerificarEmpleado", conn.Connection);
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
        public void insertarEmpleado(string user, string pass,string carnet,string nombre, string apellido,string telefono, string correo,string roll)
        {
            try
            {
                SqlCommand idinse = new SqlCommand("AnadirUsuarioEmpleado", conn.Connection);
                idinse.CommandType = CommandType.StoredProcedure;
                    idinse.Parameters.AddWithValue("@user", user);
                    idinse.Parameters.AddWithValue("@contrasenia", pass);
                    idinse.Parameters.AddWithValue("@carnet", carnet);
                    idinse.Parameters.AddWithValue("@nombre", nombre);
                    idinse.Parameters.AddWithValue("@apellido", apellido);
                    idinse.Parameters.AddWithValue("@telefono", telefono);
                    idinse.Parameters.AddWithValue("@correo", correo);
                    idinse.Parameters.AddWithValue("@roll", roll);
                conn.OpenConnection();

                idinse.ExecuteNonQuery();

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
        public void actualizarEmpleado(string carnet, string nombre, string apellido, string telefono, string correo, string roll,string estado)
        {
            try
            {
                SqlCommand idact = new SqlCommand("EditarEmpleado", conn.Connection);
                idact.CommandType = CommandType.StoredProcedure;
                    idact.Parameters.AddWithValue("@carnet", carnet);
                    idact.Parameters.AddWithValue("@nombre", nombre);
                    idact.Parameters.AddWithValue("@apellido", apellido);
                    idact.Parameters.AddWithValue("@telefono", telefono);
                    idact.Parameters.AddWithValue("@correo", correo);
                    idact.Parameters.AddWithValue("@roll", roll);
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
        public void eliminarEmpleado(string carnet)
        {
            try
            {
                SqlCommand ideli = new SqlCommand("EliminarEmpleado", conn.Connection);
                ideli.CommandType = CommandType.StoredProcedure;
                ideli.Parameters.AddWithValue("@carnet", carnet);
                
                conn.OpenConnection();

                ideli.ExecuteNonQuery();

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
