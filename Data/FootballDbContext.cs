using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Models;
using Data.Migrations;

namespace Data
{
    public class FootballDbContext : IdentityDbContext<AppUser>
    {
        public FootballDbContext()
            : base("FootballLeagues")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FootballDbContext, Configuration>());
        }

        public static FootballDbContext Create()
        {
            return new FootballDbContext();
        }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameStats> GamesStats { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Town> Towns { get; set; }

        //public DbSet<AppUser> AppUsers { get; set; }
    }
}