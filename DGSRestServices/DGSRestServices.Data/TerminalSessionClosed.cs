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
    
    public partial class TerminalSessionClosed
    {
        public int TermSessID { get; set; }
        public int TerminalID { get; set; }
        public short IdUser { get; set; }
        public int ActiveTillID { get; set; }
        public byte Lang { get; set; }
        public System.DateTime OpenedDateTime { get; set; }
        public System.DateTime ClosedDateTime { get; set; }
    }
}
