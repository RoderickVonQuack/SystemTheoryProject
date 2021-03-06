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
    
    public partial class TBL_Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Productos()
        {
            this.TBL_Detalle_Merma = new HashSet<TBL_Detalle_Merma>();
            this.TBL_Detalle_Orden_Fabricacion = new HashSet<TBL_Detalle_Orden_Fabricacion>();
            this.TBL_Reciclaje = new HashSet<TBL_Reciclaje>();
            this.TBL_Ubicaciones = new HashSet<TBL_Ubicaciones>();
        }
    
        public int Id_producto { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion_producto { get; set; }
        public decimal Precio_producto { get; set; }
        public string Tipo_envasado { get; set; }
        public string Nivel_fragilidad { get; set; }
        public int Cantidad_mililitros { get; set; }
        public int Nivel_Alcohol { get; set; }
        public System.DateTime Fecha_emision { get; set; }
        public System.DateTime Fecha_caducidad { get; set; }
        public string Codigo { get; set; }
        public System.DateTime Fecha_ingreso { get; set; }
        public Nullable<System.DateTime> Fecha_Modificacion { get; set; }
        public int Stock_Inicial { get; set; }
        public int Stock_Actual { get; set; }
        public int Punto_Reorden { get; set; }
        public Nullable<int> Id_estado { get; set; }
        public Nullable<int> Id_detalle_factura { get; set; }
    
        public virtual TBL_Detalle_Factura TBL_Detalle_Factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Detalle_Merma> TBL_Detalle_Merma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Detalle_Orden_Fabricacion> TBL_Detalle_Orden_Fabricacion { get; set; }
        public virtual TBL_Estado TBL_Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Reciclaje> TBL_Reciclaje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Ubicaciones> TBL_Ubicaciones { get; set; }
    }
}
