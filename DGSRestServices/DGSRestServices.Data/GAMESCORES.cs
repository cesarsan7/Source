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
    
    public partial class GAMESCORES
    {
        public int IdGameScores { get; set; }
        public int IdSport { get; set; }
        public System.DateTime GameDate { get; set; }
        public int RotationNumber { get; set; }
        public byte Period { get; set; }
        public string Visitor { get; set; }
        public string Home { get; set; }
        public Nullable<int> VisitorScore { get; set; }
        public Nullable<int> HomeScore { get; set; }
        public bool Short { get; set; }
        public bool Cancel { get; set; }
        public bool Final { get; set; }
        public bool Apply { get; set; }
    }
}
