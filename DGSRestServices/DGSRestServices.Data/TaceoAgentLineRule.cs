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
    
    public partial class TaceoAgentLineRule
    {
        public int TaceoAgentLineRuleId { get; set; }
        public string Description { get; set; }
        public string EmailAdresses { get; set; }
        public bool EmailAlert { get; set; }
        public bool Enabled { get; set; }
        public bool HideGame { get; set; }
        public bool HideML { get; set; }
        public bool HideSpread { get; set; }
        public bool HideTotal { get; set; }
        public Nullable<int> IdAgent { get; set; }
        public Nullable<int> IdLineType { get; set; }
        public string IdSport { get; set; }
        public Nullable<int> OddsML { get; set; }
        public Nullable<int> OddsSpread { get; set; }
        public Nullable<int> OddsTotal { get; set; }
        public Nullable<decimal> PointsSpread { get; set; }
        public Nullable<decimal> PointsTotal { get; set; }
        public Nullable<decimal> ActionSpread { get; set; }
        public Nullable<decimal> ActionTotal { get; set; }
        public Nullable<decimal> ActionML { get; set; }
        public Nullable<int> Period { get; set; }
        public string Title { get; set; }
        public bool Deleted { get; set; }
    }
}
