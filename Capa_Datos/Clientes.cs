using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos.Model;


namespace Capa_Datos
{
    
    public class Clientes
    {
        Tec_Shop_UMLG3Entities db = new Tec_Shop_UMLG3Entities();
        
        public List<VerClientes_Result> ListaClientes(string word,string estado)
        {
            
            var query = (db.VerClientes(word,estado)).ToList();

            return query;
        }

        public void insertarCliente(string nombre,string telefono, string correo)
        {
            db.AnadirCliente(nombre, telefono, correo);
        }
    }
}
