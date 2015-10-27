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
    
    public partial class GRADEDWAGERDETAIL
    {
        public int IdWagerDetail { get; set; }
        public int IdWager { get; set; }
        public string IdSport { get; set; }
        public Nullable<int> IdGame { get; set; }
        public int Play { get; set; }
        public byte Period { get; set; }
        public Nullable<float> Points { get; set; }
        public int Odds { get; set; }
        public byte Stat { get; set; }
        public string VisitorPitcher { get; set; }
        public string HomePitcher { get; set; }
        public Nullable<byte> ListedPitcher { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> GameDateTime { get; set; }
        public float PointsPurchased { get; set; }
        public bool Graded { get; set; }
        public byte PitcherStat { get; set; }
        public byte Result { get; set; }
        public string CompleteDescription { get; set; }
        public Nullable<int> VScore { get; set; }
        public Nullable<int> HScore { get; set; }
        public Nullable<bool> IsPastPost { get; set; }
        public float Juice { get; set; }
        public bool KeyDetail { get; set; }
        public decimal ChartDetailRisk { get; set; }
        public decimal ChartDetailWin { get; set; }
        public decimal IfBetAmount { get; set; }
        public byte RiskWin { get; set; }
        public bool ShortGame { get; set; }
        public bool PitcherChange { get; set; }
        public short IdEvent { get; set; }
        public bool LineFromAgent { get; set; }
    }
}
