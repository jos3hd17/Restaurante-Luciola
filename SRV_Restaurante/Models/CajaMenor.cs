//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRV_Restaurante.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CajaMenor
    {
        public int idCajaMenor { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string tipoMov { get; set; }
        public Nullable<int> valor { get; set; }
        public string ciudad { get; set; }
        public string persona { get; set; }
        public string concepto { get; set; }
        public string usuario { get; set; }
    }
}
