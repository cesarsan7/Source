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
    
    public partial class PlayerClaims_GetInfo_Result
    {
        public int IdClaim { get; set; }
        public string Player { get; set; }
        public int IdWager { get; set; }
        public string Description { get; set; }
        public short IdUser { get; set; }
        public Nullable<System.DateTime> Placed { get; set; }
        public Nullable<short> IdOffice { get; set; }
        public Nullable<int> IdCall { get; set; }
        public Nullable<short> PhoneLine { get; set; }
        public Nullable<short> Unit { get; set; }
        public Nullable<short> Channel { get; set; }
        public Nullable<System.DateTime> TapeTime { get; set; }
        public Nullable<short> SolvedBy { get; set; }
        public string Comments { get; set; }
        public string Results { get; set; }
        public Nullable<byte> Status { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    }
}
