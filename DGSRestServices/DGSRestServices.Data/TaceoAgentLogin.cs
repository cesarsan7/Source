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
    
    public partial class TaceoAgentLogin
    {
        public int IdAgent { get; set; }
        public bool RestrictMultipleLogin { get; set; }
        public int FailedAttempts { get; set; }
        public Nullable<bool> Cents { get; set; }
    }
}
