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
    
    public partial class CARDDEF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARDDEF()
        {
            this.CARDDEFODDS = new HashSet<CARDDEFODDS>();
            this.CARDDEFSPORTS = new HashSet<CARDDEFSPORTS>();
            this.CARDHEADER = new HashSet<CARDHEADER>();
        }
    
        public int IdCardDef { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public decimal MaxPayout { get; set; }
        public decimal MinRisk { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARDDEFODDS> CARDDEFODDS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARDDEFSPORTS> CARDDEFSPORTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARDHEADER> CARDHEADER { get; set; }
    }
}