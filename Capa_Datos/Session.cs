using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class Session
    {
        private int _id;
        private string  _nombre = "Marcos";
        private string  _apellidos = "Medina";
        private string  _carnet;
        ConexionBD conn = new ConexionBD();
        private string nombreCompleto = "";
        public string getNombre()
        {
            nombreCompleto = _nombre + " " + _apellidos;
            return nombreCompleto;
        }
        public DataTable getSession(string usuario,string contrasenia)
        {
            try
            {
                
                SqlCommand session = new SqlCommand("AutenticarUsuario", conn.Connection);
                session.CommandType = CommandType.StoredProcedure;
                session.Parameters.AddWithValue("@user", usuario);
                session.Parameters.AddWithValue("@contrasenia", contrasenia);

                conn.OpenConnection();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(session);
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
