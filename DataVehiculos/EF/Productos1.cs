//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataVehiculos.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos1
    {
        public string Productos { get; set; }
        public string CveGpo { get; set; }
        public string Estatus { get; set; }
        public string Descripcion { get; set; }
        public string Auto { get; set; }
        public Nullable<int> AñoInicio { get; set; }
        public Nullable<int> AñoFin { get; set; }
        public string Proveedor { get; set; }
        public Nullable<decimal> Costo { get; set; }
    
        public virtual Grupo Grupo { get; set; }
    }
}
