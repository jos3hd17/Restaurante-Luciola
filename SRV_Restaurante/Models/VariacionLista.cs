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
    
    public partial class VariacionLista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VariacionLista()
        {
            this.Variacion1 = new HashSet<Variacion>();
        }
    
        public int idVariacionLista { get; set; }
        public string variacion { get; set; }
        public int precio { get; set; }
        public Nullable<int> idRestaurante { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Variacion> Variacion1 { get; set; }
    }
}
