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
    
    public partial class PlayerMessages_GetInfo_Result
    {
        public int IdPlayerMessage { get; set; }
        public int IdPlayer { get; set; }
        public string Message { get; set; }
        public bool MessageType { get; set; }
        public bool UseExpirationDate { get; set; }
        public bool UseDisplayCounter { get; set; }
        public bool UseCloseOption { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public byte DisplayCounter { get; set; }
        public bool Closed { get; set; }
    }
}