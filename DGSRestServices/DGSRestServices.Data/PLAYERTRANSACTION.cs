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
    
    public partial class PLAYERTRANSACTION
    {
        public int IdTransaction { get; set; }
        public int IdPlayer { get; set; }
        public System.DateTime PlacedDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Reference { get; set; }
        public decimal Fee { get; set; }
        public decimal Bonus { get; set; }
        public byte IdPaymentMethod { get; set; }
        public Nullable<byte> IdAdjustmentType { get; set; }
        public string TransactionType { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    }
}