//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Promociones
    {
        public int ID_Promoción { get; set; }
        public string Nombre_Promocion { get; set; }
        public System.DateTime Fecha_Inicio { get; set; }
        public System.DateTime Fecha_Fin { get; set; }
        public decimal Porcentaje { get; set; }
        public int ID_Producto { get; set; }
    
        public virtual Productos Productos { get; set; }
    }
}
