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
    
    public partial class Reportes
    {
        public int ID_Reporte { get; set; }
        public string Titulo_Reporte { get; set; }
        public System.DateTime Fecha_Reporte { get; set; }
        public string Tipo_Reporte { get; set; }
        public int ID_Empleado { get; set; }
    
        public virtual Empleados Empleados { get; set; }
    }
}
