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
    
    public partial class GAMEIMPORTERSOURCES
    {
        public string ScheduleURL { get; set; }
        public byte ScheduleRefresh { get; set; }
        public string ScoresURL { get; set; }
        public byte ScoresRefresh { get; set; }
        public string LineChangesURL { get; set; }
        public byte LineChangesRefresh { get; set; }
        public bool ImportSchedule { get; set; }
        public bool ImportScores { get; set; }
        public bool ImportLineChanges { get; set; }
    }
}