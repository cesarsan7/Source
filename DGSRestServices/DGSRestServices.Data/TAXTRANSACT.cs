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
    
    public partial class TAXTRANSACT
    {
        public int TaxTransactID { get; set; }
        public int TaxID { get; set; }
        public Nullable<int> ActiveTillID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> IdBook { get; set; }
        public Nullable<int> IdPlayer { get; set; }
        public Nullable<int> IdWager { get; set; }
        public int MoneyChange { get; set; }
        public System.DateTime TransactDateTime { get; set; }
        public decimal TransactAmount { get; set; }
        public System.DateTime OpDate { get; set; }
    }
}
