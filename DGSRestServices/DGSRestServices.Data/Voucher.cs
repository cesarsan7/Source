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
    
    public partial class Voucher
    {
        public int VoucherID { get; set; }
        public string VoucherNum { get; set; }
        public byte VoucherType { get; set; }
        public int LocationID { get; set; }
        public int IssuedTerminalID { get; set; }
        public byte VoucherStatus { get; set; }
        public System.DateTime IssuedDateTime { get; set; }
        public Nullable<System.DateTime> RedeemedDateTime { get; set; }
        public string CurrCode { get; set; }
        public decimal CurrBalance { get; set; }
        public decimal CurrOriginalBalance { get; set; }
        public Nullable<decimal> CurrRedeemedBalance { get; set; }
        public System.DateTime IssuedOpDate { get; set; }
        public Nullable<System.DateTime> RedeemedOpDate { get; set; }
    }
}
