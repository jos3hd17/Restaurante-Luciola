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
    
    public partial class CompraDetalle
    {
        public int idCompraDetalle { get; set; }
        public Nullable<int> idCompra { get; set; }
        public Nullable<int> idProducto { get; set; }
        public Nullable<int> precioUnit { get; set; }
        public Nullable<int> cant { get; set; }
        public Nullable<int> precioTot { get; set; }
    
        public virtual Compra Compra { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
