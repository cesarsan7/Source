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
    
    public partial class SYSTEMPREFERENCESDEFAULTLOG
    {
        public int IdSystemPreferencesDefaultManagerLog { get; set; }
        public short IdBook { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public short IdUser { get; set; }
        public System.DateTime PlacedDate { get; set; }
        public short PhoneLine { get; set; }
        public string IP { get; set; }
    }
}
