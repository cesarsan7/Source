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
    
    public partial class PLAYERDELETED
    {
        public int Idplayer { get; set; }
        public Nullable<int> IdAgent { get; set; }
        public short IdCurrency { get; set; }
        public string Player { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string LastName2 { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal ThisWeekSports { get; set; }
        public decimal LastWeekSports { get; set; }
        public decimal ThisWeekCasino { get; set; }
        public decimal LastWeekCasino { get; set; }
        public decimal ThisWeekHorses { get; set; }
        public decimal LastWeekHorses { get; set; }
        public Nullable<System.DateTime> LastCall { get; set; }
        public System.DateTime AccountOpened { get; set; }
        public Nullable<System.DateTime> LastWager { get; set; }
        public Nullable<System.DateTime> LastModification { get; set; }
        public Nullable<short> LastModificationUser { get; set; }
    }
}
