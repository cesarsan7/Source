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
    
    public partial class AGENTLOGONS
    {
        public int IdAgentLogons { get; set; }
        public int IdAgent { get; set; }
        public System.DateTime PlacedDate { get; set; }
        public string IP { get; set; }
    
        public virtual AGENT AGENT { get; set; }
    }
}
