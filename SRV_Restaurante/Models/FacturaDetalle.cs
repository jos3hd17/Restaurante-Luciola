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
    
    public partial class FacturaDetalle
    {
        public int idDetralleFac { get; set; }
        public Nullable<int> idFactura { get; set; }
        public Nullable<int> idPorducto { get; set; }
        public Nullable<int> precio { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> cant { get; set; }
        public Nullable<int> descuento { get; set; }
    
        public virtual Factura Factura { get; set; }
    }
}
