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
    
    public partial class AGENTACCOUNTING
    {
        public int IdAgentAccounting { get; set; }
        public int IdAgent { get; set; }
        public int IdTransaction { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal MoneyChange { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    
        public virtual AGENT AGENT { get; set; }
    }
}
