//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DGSRestServices.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class WEBCOLUMN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WEBCOLUMN()
        {
            this.BOOK = new HashSet<BOOK>();
        }
    
        public int IdWebColumn { get; set; }
        public string Description { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOK> BOOK { get; set; }
    }
}
