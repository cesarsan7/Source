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
    
    public partial class PAYMENTS
    {
        public short IdPayment { get; set; }
        public int IdPlayer { get; set; }
        public Nullable<byte> TransType { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> FinalAmount { get; set; }
        public string RequestData { get; set; }
        public string ResponseData { get; set; }
        public Nullable<byte> PaymentType { get; set; }
        public string PaymentMethod { get; set; }
    }
}