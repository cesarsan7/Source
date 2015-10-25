//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DGSRestServices.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActiveTill
    {
        public int ActiveTillID { get; set; }
        public int TillID { get; set; }
        public int TerminalID { get; set; }
        public int OpenedBy { get; set; }
        public System.DateTime OpenedDateTime { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal Receipts { get; set; }
        public decimal Disbursements { get; set; }
        public Nullable<System.DateTime> ClosedDateTime { get; set; }
        public System.DateTime OpDate { get; set; }
    
        public virtual Terminal Terminal { get; set; }
        public virtual TerminalManager TerminalManager { get; set; }
        public virtual TILL TILL { get; set; }
    }
}
