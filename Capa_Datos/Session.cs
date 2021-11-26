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
        private string  _nombre = "";
        private string  _apellidos = "";
        private string  _carnet = "";
        private string _roll = "";
        ConexionBD conn = new ConexionBD();
        private string nombreCompleto = "";
        public string getNombre()
        {
            nombreCompleto = _nombre + " " + _apellidos;
            return nombreCompleto;
        }
        public bool authUser(string usuario,string contrasenia)
        {
            bool ok = true;
            try
            {
                
                SqlCommand auth = new SqlCommand("AutenticarUsuario", conn.Connection);
                auth.CommandType = CommandType.StoredProcedure;
                auth.Parameters.AddWithValue("@user", usuario);
                auth.Parameters.AddWithValue("@contrasenia", contrasenia);

                conn.OpenConnection();

                SqlDataReader dr = auth.ExecuteReader();
                if(dr.Read())
                {
                    ok = true;
                }
                else
                {
                    ok = false;
                }                
                
            }
            catch (SqlException ex)
            {
                ok = false;
            }
            finally
            {
                conn.CloseConnection();
            }
            return ok;
        }

        public void getSession(string usuario)
        {
            try
            {
                SqlCommand session = new SqlCommand("getSession", conn.Connection);
                session.CommandType = CommandType.StoredProcedure;
                session.Parameters.AddWithValue("@usuario", usuario);
                conn.OpenConnection();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(session);
                da.Fill(dt);

                _id = Convert.ToInt32(dt.Rows[0][0]);
                _nombre = dt.Rows[0][1].ToString();
                _apellidos = dt.Rows[0][2].ToString();
                _carnet = dt.Rows[0][3].ToString();
                _roll = dt.Rows[0][4].ToString();
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

        public string getRoll()
        {
            return _roll;
        }

        public void clearSession()
        {
            _id = 0;
            _nombre = "";
            _apellidos = "";
            _carnet = "";
            _roll = "";
        }
    }
}
