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
    
    public partial class Agent_GetInfoDistributor_Result
    {
        public int IdAgent { get; set; }
        public short IdCurrency { get; set; }
        public short IdBook { get; set; }
        public string Agent { get; set; }
        public byte IdAgentType { get; set; }
        public Nullable<short> IdGrouping { get; set; }
        public bool Enable { get; set; }
        public bool IsDistributor { get; set; }
        public bool DontXferPlayerActivity { get; set; }
        public byte CommSports { get; set; }
        public byte CommCasino { get; set; }
        public byte CommHorses { get; set; }
        public decimal PerHeadSports { get; set; }
        public decimal PerHeadCasino { get; set; }
        public decimal PerHeadHorses { get; set; }
        public Nullable<int> IdDistributor { get; set; }
        public string Distributor { get; set; }
    }
}
