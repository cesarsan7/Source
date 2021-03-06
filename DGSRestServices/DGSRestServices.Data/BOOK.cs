//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DGSRestServices.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOOK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOOK()
        {
            this.AGENT = new HashSet<AGENT>();
            this.BOOKPREFIX = new HashSet<BOOKPREFIX>();
        }
    
        public short IdBook { get; set; }
        public string Description { get; set; }
        public Nullable<int> IdWebColumn { get; set; }
        public Nullable<System.DateTime> LastModification { get; set; }
        public Nullable<short> LastModificationUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENT> AGENT { get; set; }
        public virtual WEBCOLUMN WEBCOLUMN { get; set; }
        public virtual BOOKCLIENTPREFERENCES BOOKCLIENTPREFERENCES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOKPREFIX> BOOKPREFIX { get; set; }
    }
}
