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
    
    public partial class PLAYERSTATISTIC
    {
        public int IdPlayer { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal AmountAtRisk { get; set; }
        public decimal AvailBalance { get; set; }
        public Nullable<decimal> BonusPoints { get; set; }
        public decimal YTDWin { get; set; }
        public decimal YTDLose { get; set; }
        public decimal LifeTimeWin { get; set; }
        public decimal LifeTimeLose { get; set; }
        public decimal LifeTimeNetCasino { get; set; }
        public decimal LifeTimeNetHorses { get; set; }
        public decimal ThisWeekSports { get; set; }
        public decimal LastWeekSports { get; set; }
        public decimal ThisWeekCasino { get; set; }
        public decimal LastWeekCasino { get; set; }
        public decimal ThisWeekHorses { get; set; }
        public decimal LastWeekHorses { get; set; }
        public Nullable<System.DateTime> LastCall { get; set; }
        public System.DateTime AccountOpened { get; set; }
        public Nullable<System.DateTime> LastWager { get; set; }
        public Nullable<System.DateTime> LastGrade { get; set; }
        public decimal LifeTimeFreePlays { get; set; }
        public decimal LifeTimeBonus { get; set; }
        public decimal LifeTimeFees { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    }
}
