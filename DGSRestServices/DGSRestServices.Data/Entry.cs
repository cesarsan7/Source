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
    
    public partial class Entry
    {
        public int EntryID { get; set; }
        public int RaceID { get; set; }
        public string SaddleNum { get; set; }
        public Nullable<byte> EntryNum { get; set; }
        public string CoupleChar { get; set; }
        public string EntryName { get; set; }
        public string RiderName { get; set; }
        public Nullable<short> FinishPos { get; set; }
        public Nullable<double> ML { get; set; }
        public string BkColor { get; set; }
        public string FkColor { get; set; }
        public string TrainerName { get; set; }
        public string OwnerName { get; set; }
        public Nullable<int> Weight { get; set; }
        public string Equipment { get; set; }
        public string Medication { get; set; }
    }
}
