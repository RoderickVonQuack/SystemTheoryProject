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
    
    public partial class TBL_Usuarios
    {
        public int Id_usuario { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public Nullable<System.DateTime> Fecha_creacion { get; set; }
        public Nullable<System.DateTime> Fecha_modificacion { get; set; }
        public Nullable<int> Id_Tiempo { get; set; }
        public Nullable<int> Id_Rol { get; set; }
        public Nullable<int> Id_estado { get; set; }
        public Nullable<int> Id_Empresa { get; set; }
    
        public virtual TBL_BeerLab TBL_BeerLab { get; set; }
        public virtual TBL_Estado TBL_Estado { get; set; }
        public virtual TBL_Roles TBL_Roles { get; set; }
        public virtual TBL_Tiempos_Usuario TBL_Tiempos_Usuario { get; set; }
    }
}
