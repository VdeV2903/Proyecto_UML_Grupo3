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
    
    public partial class DocumentosFiscales
    {
        public int ID_Documento { get; set; }
        public System.DateTime Fecha_Doc { get; set; }
        public string Nota { get; set; }
        public string Tipo_Doc { get; set; }
        public string NIT { get; set; }
        public string Registro { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Municipio { get; set; }
        public string Departamento { get; set; }
        public string Condicion { get; set; }
        public int ID_Empleado { get; set; }
        public int ID_Venta { get; set; }
    
        public virtual Empleados Empleados { get; set; }
        public virtual Ventas Ventas { get; set; }
    }
}
