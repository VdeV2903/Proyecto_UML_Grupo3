using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Login
    {
        private string usuario, password;
        private string hash ="";

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        public string Logear()
        {
            //CODIGO DE PRUEBA
            try
            {
                if (usuario == "marcos" && password == "hola")
                {
                    hash = "Correcto";
                }else
                {
                    hash = "Incorrecto";
                }
            }
            catch (Exception ex)
            {

                hash = ex.Message;
            }

            finally
            {

            }
            return hash;
        }
    }
}
