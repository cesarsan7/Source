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
    
    public partial class GRADEDGAMECHANGE
    {
        public int IdGame { get; set; }
        public Nullable<System.DateTime> DateTimeBefore { get; set; }
        public Nullable<System.DateTime> DateTimeAfter { get; set; }
        public string OldStatus { get; set; }
        public string NewStatus { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    }
}
