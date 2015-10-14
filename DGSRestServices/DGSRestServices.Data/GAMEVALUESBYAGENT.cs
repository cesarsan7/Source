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
    
    public partial class GAMEVALUESBYAGENT
    {
        public int IdAgent { get; set; }
        public int IdGame { get; set; }
        public Nullable<int> VisitorOdds { get; set; }
        public Nullable<int> HomeOdds { get; set; }
        public Nullable<float> TotalOver { get; set; }
        public Nullable<int> OverOdds { get; set; }
        public Nullable<float> TotalUnder { get; set; }
        public Nullable<int> UnderOdds { get; set; }
        public Nullable<float> VisitorSpread { get; set; }
        public Nullable<int> VisitorSpreadOdds { get; set; }
        public Nullable<float> HomeSpread { get; set; }
        public Nullable<int> HomeSpreadOdds { get; set; }
        public Nullable<float> VisitorSpecial { get; set; }
        public Nullable<int> VisitorSpecialOdds { get; set; }
        public Nullable<float> HomeSpecial { get; set; }
        public Nullable<int> HomeSpecialOdds { get; set; }
        public bool HideGame { get; set; }
        public bool HideSpread { get; set; }
        public bool HideTotal { get; set; }
        public bool HideMoneyLine { get; set; }
        public bool Follow { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    }
}