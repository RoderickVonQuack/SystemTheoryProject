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
    
    public partial class TBL_Devoluciones
    {
        public int Id_Devolucion { get; set; }
        public string Razon_Devolucion { get; set; }
        public string Estado_Fisico { get; set; }
        public decimal MontoDevolucion { get; set; }
        public string Estado_Inventario { get; set; }
        public string Descripcion { get; set; }
        public int Id_factura { get; set; }
        public int Id_cliente { get; set; }
        public int Id_Estado { get; set; }
    
        public virtual TBL_Clientes TBL_Clientes { get; set; }
        public virtual TBL_Estado TBL_Estado { get; set; }
        public virtual TBL_Factura TBL_Factura { get; set; }
    }
}
