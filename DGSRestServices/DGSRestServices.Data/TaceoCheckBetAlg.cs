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
    
    public partial class TaceoCheckBetAlg
    {
        public int TaceoCheckBetAlgId { get; set; }
        public bool ResultActive { get; set; }
        public int Version { get; set; }
        public Nullable<decimal> RoiBet { get; set; }
        public Nullable<decimal> RoiOverAll { get; set; }
        public Nullable<decimal> WinRatio { get; set; }
        public string SportId { get; set; }
        public string Plays { get; set; }
        public string Description { get; set; }
        public string DetailDescription { get; set; }
        public Nullable<System.DateTime> LastBetTimeStamp { get; set; }
        public Nullable<int> sharpTypeId { get; set; }
        public Nullable<int> takeNumSharps { get; set; }
        public Nullable<int> minWagerCount { get; set; }
        public Nullable<decimal> minRoi { get; set; }
        public Nullable<int> numMonthsHistory { get; set; }
        public Nullable<int> minBet { get; set; }
        public Nullable<int> maxBet { get; set; }
        public Nullable<int> betalgTypeId { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public Nullable<int> wagerCount { get; set; }
        public Nullable<int> wagerWinCount { get; set; }
        public Nullable<int> wagerLostCount { get; set; }
    }
}
