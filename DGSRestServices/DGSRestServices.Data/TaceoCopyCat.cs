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
    
    public partial class TaceoCopyCat
    {
        public int TaceoCopyCatId { get; set; }
        public string DGSplayer { get; set; }
        public int DGSplayerId { get; set; }
        public string PinUser { get; set; }
        public string PinPwd { get; set; }
        public decimal SpreadRiskAmount { get; set; }
        public decimal TotalRiskAmount { get; set; }
        public decimal MLRiskAmount { get; set; }
        public bool Enabled { get; set; }
        public Nullable<System.DateTime> LastAction { get; set; }
        public string EmailSendTo { get; set; }
        public bool EmailEnabled { get; set; }
        public int LastWagerId { get; set; }
        public int Period { get; set; }
        public int Prio { get; set; }
        public bool PercOfWagerAmount { get; set; }
        public bool PercOfBalance { get; set; }
        public decimal BalanceAlert { get; set; }
        public decimal MaxBetLimit { get; set; }
        public Nullable<int> LeagueId { get; set; }
        public string LeagueDescription { get; set; }
    }
}
