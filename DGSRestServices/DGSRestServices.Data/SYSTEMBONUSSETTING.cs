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
    
    public partial class SYSTEMBONUSSETTING
    {
        public int MaxWager { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string FuncStraightBets { get; set; }
        public string FuncParlays { get; set; }
        public string FuncTeasers { get; set; }
        public Nullable<bool> EnableWinBets { get; set; }
        public Nullable<bool> EnableLostBets { get; set; }
        public Nullable<bool> EnablePushBets { get; set; }
        public Nullable<bool> EnableNABets { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    }
}