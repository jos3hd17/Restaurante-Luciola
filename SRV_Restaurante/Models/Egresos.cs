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
    
    public partial class Egresos
    {
        public int idEgreso { get; set; }
        public string ciudad { get; set; }
        public string remitente { get; set; }
        public string telefonoRemitente { get; set; }
        public string cedulaRemitente { get; set; }
        public string concepto { get; set; }
        public string direccion { get; set; }
        public string responsable { get; set; }
        public long valor { get; set; }
        public Nullable<int> idFormaPago { get; set; }
        public Nullable<System.DateTime> fechaEgreso { get; set; }
    
        public virtual FormaPago FormaPago { get; set; }
    }
}
