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
    
    public partial class SYSTEMPROCESSLOGDETAIL
    {
        public int IdSystemProcessDetail { get; set; }
        public int IdSystemProcess { get; set; }
        public string Step { get; set; }
        public Nullable<System.DateTime> TotalTime { get; set; }
    }
}