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
    
    public partial class Ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ventas()
        {
            this.DocumentosFiscales = new HashSet<DocumentosFiscales>();
            this.Productos_Ventas = new HashSet<Productos_Ventas>();
        }
    
        public int ID_Venta { get; set; }
        public string Codigo_Venta { get; set; }
        public System.DateTime Fecha_Venta { get; set; }
        public decimal Sub_Total { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Total { get; set; }
        public decimal Adeudo { get; set; }
        public Nullable<System.DateTime> Fecha_Pago_Adeudo { get; set; }
        public decimal Pagado_Actual { get; set; }
        public int ID_Empleado { get; set; }
        public int ID_Cliente { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosFiscales> DocumentosFiscales { get; set; }
        public virtual Empleados Empleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Ventas> Productos_Ventas { get; set; }
    }
}
