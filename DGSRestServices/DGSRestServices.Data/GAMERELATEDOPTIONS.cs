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
    
    public partial class GAMERELATEDOPTIONS
    {
        public short IdProfile { get; set; }
        public string IdSport { get; set; }
        public byte IdPeriod { get; set; }
        public bool MLFav_Over { get; set; }
        public bool MLFav_Under { get; set; }
        public bool MLDog_Over { get; set; }
        public bool MLDog_Under { get; set; }
        public bool SprFav_Over { get; set; }
        public bool SprFav_Under { get; set; }
        public bool SprDog_Over { get; set; }
        public bool SprDog_Under { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    }
}