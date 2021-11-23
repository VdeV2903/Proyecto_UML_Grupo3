using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{

    public class Ventas
    {
        ConexionBD conn = new ConexionBD();
        public void insertarProductosVenta(string nombre,string marca,int cantidad,double subtotal)
        {
            /*
            agregar.Parameters.Clear();

            agregar.Parameters.AddWithValue("@clave", Convert.ToString(row.Cells["Column1"].Value));
            agregar.Parameters.AddWithValue("@nombre", Convert.ToString(row.Cells["Column2"].Value));
            agregar.Parameters.AddWithValue("@apellido", Convert.ToString(row.Cells["Column3"].Value));

            agregar.ExecuteNonQuery();
            */
        }
        public void insertarVenta(string codigo,string fecha,double subtotal,double total,double adeudo,string fechap,double pagado,string cliente,string vendedor,double totalA)
        {

        }
        private string ID = "";
        public string trarIDCliente(string nombre, string correo)
        {

            return ID;
        }
    }
}
