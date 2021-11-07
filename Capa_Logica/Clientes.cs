using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Configuration;

namespace Capa_Logica
{
    public class Clientes
    {
        //
        private string word;
        private string estado;
        private int busquedapor;

        public string Word { get => word; set => word = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Busquedapor { get => busquedapor; set => busquedapor = value; }
        

        public DataTable ObtenerClientes()
        {
            
            DataTable dt = new DataTable();

            using (Models.Tec_Shop_UMLG3Entities mdl = new Models.Tec_Shop_UMLG3Entities())
            {
                var ds = mdl.VerClientes(word, estado, busquedapor);
                IEnumerable<DataRow> datos = (IEnumerable<DataRow>)ds;
                dt = datos.CopyToDataTable<DataRow>();
            }


            return dt;
        }
        

    }
}
