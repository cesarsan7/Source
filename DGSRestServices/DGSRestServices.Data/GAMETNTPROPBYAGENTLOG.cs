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
    
    public partial class GAMETNTPROPBYAGENTLOG
    {
        public int IdGameTNTPROPByAgentLog { get; set; }
        public int IdAgent { get; set; }
        public int IdGame { get; set; }
        public int TeamNumber { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public int Play { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    }
}
