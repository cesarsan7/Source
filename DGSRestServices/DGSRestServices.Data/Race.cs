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
    
    public partial class Race
    {
        public int RaceID { get; set; }
        public int TrackID { get; set; }
        public System.DateTime RaceDate { get; set; }
        public short RaceNumber { get; set; }
        public string RaceStatus { get; set; }
        public System.DateTime PostTime { get; set; }
        public System.DateTime SystemRaceDateTime { get; set; }
        public byte CloseMethod { get; set; }
        public short PostCutoff { get; set; }
        public Nullable<System.DateTime> OffTime { get; set; }
        public Nullable<System.DateTime> SystemOffDateTime { get; set; }
        public string RaceDescription { get; set; }
        public string RaceShortDesc { get; set; }
        public bool Double1 { get; set; }
        public bool Double2 { get; set; }
        public bool PK3_1 { get; set; }
        public bool PK3_3 { get; set; }
        public bool PK4_1 { get; set; }
        public bool PK4_4 { get; set; }
        public bool PK6_1 { get; set; }
        public bool PK6_6 { get; set; }
        public bool Win { get; set; }
        public bool Place { get; set; }
        public bool Show { get; set; }
        public bool Exacta { get; set; }
        public bool Trifecta { get; set; }
        public bool Superfecta { get; set; }
        public bool Quinella { get; set; }
        public bool HouseQ { get; set; }
        public bool Euro { get; set; }
        public bool Post { get; set; }
        public Nullable<byte> MTP { get; set; }
        public string Distance { get; set; }
        public string Surface { get; set; }
        public string Class { get; set; }
        public Nullable<decimal> Purse { get; set; }
        public string TrackCond { get; set; }
        public string RaceDesc { get; set; }
        public Nullable<byte> ActualCloseMethod { get; set; }
    }
}
