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
    
    public partial class TaceoSoEvent_Line
    {
        public int TaceoSoEvent_LineId { get; set; }
        public int sportsbook_id { get; set; }
        public int number { get; set; }
        public string line_type { get; set; }
        public decimal points { get; set; }
        public bool is_latest { get; set; }
        public bool is_last_number { get; set; }
        public bool is_opener { get; set; }
        public bool is_closer { get; set; }
        public string time_stamp { get; set; }
        public int event_number { get; set; }
        public int money { get; set; }
        public bool ML { get; set; }
        public Nullable<int> over_money { get; set; }
        public Nullable<int> under_money { get; set; }
    }
}
