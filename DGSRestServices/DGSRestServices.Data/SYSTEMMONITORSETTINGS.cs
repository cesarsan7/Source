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
    
    public partial class SYSTEMMONITORSETTINGS
    {
        public short IdLineType { get; set; }
        public string DBSIpAddress { get; set; }
        public Nullable<int> DBSPort { get; set; }
        public Nullable<byte> RefreshTime { get; set; }
        public string UserNL { get; set; }
        public string PassNL { get; set; }
        public string UserML { get; set; }
        public string PassML { get; set; }
        public string UserRL { get; set; }
        public string PassRL { get; set; }
        public string User1H { get; set; }
        public string Pass1H { get; set; }
        public Nullable<byte> FBSendNL { get; set; }
        public Nullable<byte> FBSendML { get; set; }
        public Nullable<byte> FBSend1H { get; set; }
        public Nullable<byte> FBLineTotal { get; set; }
        public Nullable<byte> BKSendNL { get; set; }
        public Nullable<byte> BKSendML { get; set; }
        public Nullable<byte> BKSend1H { get; set; }
        public Nullable<byte> BKLineTotal { get; set; }
        public Nullable<byte> BBSendNL { get; set; }
        public Nullable<byte> BBSendRL { get; set; }
        public Nullable<byte> BBSend1H { get; set; }
        public Nullable<byte> BBLineTotal { get; set; }
        public Nullable<byte> HKSendNL { get; set; }
        public Nullable<byte> HKSendML { get; set; }
        public Nullable<byte> HKSend1H { get; set; }
        public Nullable<byte> HKLineTotal { get; set; }
        public Nullable<byte> SendMU { get; set; }
        public Nullable<byte> SendSOC { get; set; }
        public Nullable<byte> HKSendNLA { get; set; }
        public Nullable<byte> HKLineTotalA { get; set; }
        public bool SendToDBS { get; set; }
        public bool SendToText { get; set; }
        public bool SendToXML { get; set; }
    }
}
