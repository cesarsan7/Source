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
    
    public partial class TerminalSessionActive
    {
        public int TermSessID { get; set; }
        public int TerminalID { get; set; }
        public int LocationID { get; set; }
        public short IdUser { get; set; }
        public int ActiveTillID { get; set; }
        public byte Lang { get; set; }
        public System.DateTime OpenedDateTime { get; set; }
        public System.DateTime LastActivity { get; set; }
        public int IdPlayer { get; set; }
        public short IdLineType { get; set; }
        public string NHLLine { get; set; }
        public string MLBLine { get; set; }
        public int IdCall { get; set; }
    }
}
