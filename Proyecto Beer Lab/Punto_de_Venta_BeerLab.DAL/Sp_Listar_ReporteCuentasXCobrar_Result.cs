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
    
    public partial class Sp_Listar_ReporteCuentasXCobrar_Result
    {
        public int Id_CuentaCobrar { get; set; }
        public System.DateTime Fecha_Facturacion { get; set; }
        public System.DateTime Fecha_Vencimiento { get; set; }
        public string Identificacion_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public decimal Interes_Mora { get; set; }
        public decimal Total_Facturado { get; set; }
    }
}
