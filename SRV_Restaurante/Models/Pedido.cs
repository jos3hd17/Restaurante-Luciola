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
    
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            this.PedidoDetalle = new HashSet<PedidoDetalle>();
        }
    
        public int idPedido { get; set; }
        public Nullable<int> idCliente { get; set; }
        public string pedido1 { get; set; }
        public Nullable<int> idMesa { get; set; }
        public Nullable<int> estado { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string idUsuario { get; set; }
    
        public virtual Mesa Mesa { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoDetalle> PedidoDetalle { get; set; }
    }
}
