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
    
    public partial class TaceoASLLEAGUE
    {
        public short IdLeague { get; set; }
        public string IdSport { get; set; }
        public Nullable<short> IdLeagueRegion { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public bool DonBest { get; set; }
        public short LeagueOrder { get; set; }
        public Nullable<bool> TeamFKRequired { get; set; }
        public Nullable<System.DateTime> LastModification { get; set; }
        public Nullable<short> LastModificationUser { get; set; }
        public int ASLUserId { get; set; }
    }
}
