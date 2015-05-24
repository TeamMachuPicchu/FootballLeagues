namespace FootballLeagues.Web.Models.Teams
{
    using System;
    using System.Collections.Generic;
    using Data.Models;
    using Infrastructure.Mapping;

    public class TeamsViewModel : IMapFrom<Team>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public DateTime YearEstablished { get; set; }

        public Stadium Stadium { get; set; }

        public Manager Manager { get; set; }

        public IEnumerable<Player> Players { get; set; }
    }
}