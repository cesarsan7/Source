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
    
    public partial class PLAYERPROFILEPARLAYLIMITDETAIL
    {
        public short IdProfile { get; set; }
        public string IdSport { get; set; }
        public byte NumTeams { get; set; }
        public byte MaxGames { get; set; }
        public byte MaxDogs { get; set; }
        public Nullable<bool> UseFormula { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
        public byte MaxMoneyLines { get; set; }
    }
}
