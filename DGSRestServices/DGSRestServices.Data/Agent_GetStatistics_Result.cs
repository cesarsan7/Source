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
    
    public partial class Agent_GetStatistics_Result
    {
        public int IdAgent { get; set; }
        public decimal CurrentBalance { get; set; }
        public Nullable<decimal> ThisWeek { get; set; }
        public Nullable<decimal> LastWeek { get; set; }
        public decimal YTDWin { get; set; }
        public decimal YTDLose { get; set; }
        public decimal YTDComm { get; set; }
        public decimal LifetimeWin { get; set; }
        public decimal LifeTimeLose { get; set; }
        public decimal LifeTimeComm { get; set; }
        public decimal MakeUp { get; set; }
        public decimal LastWeekMakeUp { get; set; }
        public System.DateTime AccountOpened { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    }
}