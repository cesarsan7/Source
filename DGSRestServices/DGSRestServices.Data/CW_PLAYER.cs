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
    
    public partial class CW_PLAYER
    {
        public int Idplayer { get; set; }
        public Nullable<int> Idagent { get; set; }
        public string Player { get; set; }
        public decimal CurrentBalance { get; set; }
        public byte IdCurrency { get; set; }
        public decimal CW_Total { get; set; }
        public decimal CW_Sports { get; set; }
        public decimal CW_Casino { get; set; }
        public decimal CW_Horses { get; set; }
        public bool CW_PlayTotal { get; set; }
        public bool CW_PlaySports { get; set; }
        public bool CW_PlayCasino { get; set; }
        public bool CW_PlayHorses { get; set; }
        public decimal CW_AfterCWTotal { get; set; }
        public decimal CW_AfterCWSports { get; set; }
        public decimal CW_AfterCWCasino { get; set; }
        public decimal CW_AfterCWHorses { get; set; }
        public decimal CW_SettledFigure { get; set; }
    }
}
