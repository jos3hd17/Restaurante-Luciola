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
    
    public partial class Pago
    {
        public int idPago { get; set; }
        public Nullable<int> idFactura { get; set; }
        public Nullable<int> idMedioPago { get; set; }
        public Nullable<int> valor { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual MedioPago MedioPago { get; set; }
    }
}
