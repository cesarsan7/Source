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
    
    public partial class TaceoAgentLineTypeRights
    {
        public int IdAgent { get; set; }
        public int IdLineType { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
        public string LoginName { get; set; }
        public string LineType { get; set; }
    }
}