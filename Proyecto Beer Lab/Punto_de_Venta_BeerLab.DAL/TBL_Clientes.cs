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
    
    public partial class TBL_Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Clientes()
        {
            this.TBL_Direcciones_cliente = new HashSet<TBL_Direcciones_cliente>();
            this.TBL_Factura = new HashSet<TBL_Factura>();
            this.TBL_Devoluciones = new HashSet<TBL_Devoluciones>();
        }
    
        public int Id_cliente { get; set; }
        public string Tipo_identificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Tipo_cliente { get; set; }
        public Nullable<System.DateTime> Fecha_nacimiento { get; set; }
        public System.DateTime Fecha_creacion { get; set; }
        public System.DateTime Fecha_modificacion { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string Correo { get; set; }
        public Nullable<int> Puntos_acumulados { get; set; }
        public Nullable<int> Id_estado { get; set; }
    
        public virtual TBL_Estado TBL_Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Direcciones_cliente> TBL_Direcciones_cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Factura> TBL_Factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Devoluciones> TBL_Devoluciones { get; set; }
    }
}
