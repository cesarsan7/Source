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
    
    public partial class TaceoMatchPinnGame
    {
        public int IdTaceoMatchPinnGame { get; set; }
        public int IdGame { get; set; }
        public int IdPinnGame { get; set; }
        public string tSportId { get; set; }
        public string tVisitorTeam { get; set; }
        public string tHomeTeam { get; set; }
        public string pAwayTeam { get; set; }
        public string pHomeTeam { get; set; }
        public Nullable<int> pSportId { get; set; }
        public Nullable<int> pLeagueId { get; set; }
        public Nullable<int> tLeagueId { get; set; }
        public Nullable<int> soEventId { get; set; }
        public Nullable<int> soLeagueId { get; set; }
        public string soVisitorTeam { get; set; }
        public string soHomeTeam { get; set; }
    }
}
