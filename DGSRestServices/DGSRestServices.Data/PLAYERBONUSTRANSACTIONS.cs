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
    
    public partial class PLAYERBONUSTRANSACTIONS
    {
        public int IdPlayerBonusTransactions { get; set; }
        public Nullable<int> IdWager { get; set; }
        public int IdPlayer { get; set; }
        public string Description { get; set; }
        public byte Type { get; set; }
        public decimal BonusPoints { get; set; }
        public System.DateTime BonusDate { get; set; }
        public int IdWagerType { get; set; }
        public decimal PrevBalance { get; set; }
        public decimal CurrBalance { get; set; }
        public System.DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }
    }
}
