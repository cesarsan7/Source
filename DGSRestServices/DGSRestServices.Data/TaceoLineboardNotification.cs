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
    
    public partial class TaceoLineboardNotification
    {
        public int IdNotification { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateTimeNotification { get; set; }
        public Nullable<bool> Cleared { get; set; }
        public Nullable<System.DateTime> DateTimeCleared { get; set; }
        public Nullable<int> UserCleared { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> DateTimeCreated { get; set; }
    }
}