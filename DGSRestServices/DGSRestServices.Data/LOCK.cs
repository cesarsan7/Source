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
    
    public partial class LOCK
    {
        public int LockID { get; set; }
        public byte LockType { get; set; }
        public int LockTypeID { get; set; }
        public short IdUser { get; set; }
        public int LogonSessionID { get; set; }
        public System.DateTime Acquired { get; set; }
    }
}
