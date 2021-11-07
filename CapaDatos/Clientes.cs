using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Model;

namespace CapaDatos
{
    public class Clientes
    {
        Tec_Shop_UMLG3Entities3 db = new Tec_Shop_UMLG3Entities3();
        public List<VerClientes_Result> ListaClientes(string word,string estado,int by)
        {
            var query = (db.VerClientes(word,estado,by)).ToList();

            return query;
        }
    }
}
