//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Punto_de_Venta_BeerLab.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_CuentasCobrar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_CuentasCobrar()
        {
            this.TBL_RprtCuentasxCobrar = new HashSet<TBL_RprtCuentasxCobrar>();
        }
    
        public int Id_CuentaCobrar { get; set; }
        public System.DateTime Fecha_Facturacion { get; set; }
        public System.DateTime Fecha_Vencimiento { get; set; }
        public string Identificacion_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public decimal Interes_Mora { get; set; }
        public decimal Total_Facturado { get; set; }
        public Nullable<int> Id_factura { get; set; }
    
        public virtual TBL_Factura TBL_Factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_RprtCuentasxCobrar> TBL_RprtCuentasxCobrar { get; set; }
    }
}
