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
    
    public partial class AggLimitWork
    {
        public int Key { get; set; }
        public int AccountID { get; set; }
        public int RaceID { get; set; }
        public byte TicketType { get; set; }
        public string Selections { get; set; }
        public decimal Amount { get; set; }
        public int TicketID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual RaceTicketMain RaceTicketMain { get; set; }
    }
}