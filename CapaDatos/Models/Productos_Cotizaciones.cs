//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos_Cotizaciones
    {
        public int ID_ProductoCotizacion { get; set; }
        public int ID_Cotizacion { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad_Producto { get; set; }
        public decimal Total_Producto { get; set; }
    
        public virtual Cotizaciones Cotizaciones { get; set; }
        public virtual Productos Productos { get; set; }
    }
}