namespace FootballLeagues.Data.Common.UnitOfWork
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using Models;
    using Repositories;
    using Repositories;

    public class FootballData : IFootballData
    {
        private readonly DbContext dbContext;

        private readonly IDictionary<Type, object> repositories;

        public FootballData()
            : this(new FootballDbContext())
        {
        }

        public FootballData(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.repositories = new Dictionary<Type, object>();
        }

        public IDeletableEntityRepository<Comment> Comments
        {
            get { return this.GetRepository<Comment>(); }
        }

        public IDeletableEntityRepository<Country> Countries
        {
            get { return this.GetRepository<Country>(); }
        }

        public IDeletableEntityRepository<Game> Games
        {
            get { return this.GetRepository<Game>(); }
        }

        public IDeletableEntityRepository<GameStats> GamesStats
        {
            get { return this.GetRepository<GameStats>(); }
        }

        public IDeletableEntityRepository<League> Leagues
        {
            get { return this.GetRepository<League>(); }
        }

        public IDeletableEntityRepository<Manager> Managers
        {
            get { return this.GetRepository<Manager>(); }
        }

        public IDeletableEntityRepository<News> News
        {
            get { return this.GetRepository<News>(); }
        }

        public IDeletableEntityRepository<Owner> Owners
        {
            get { return this.GetRepository<Owner>(); }
        }

        public IDeletableEntityRepository<Player> Players
        {
            get { return this.GetRepository<Player>(); }
        }

        public IDeletableEntityRepository<Round> Rounds
        {
            get { return this.GetRepository<Round>(); }
        }

        public IDeletableEntityRepository<Season> Seasons
        {
            get { return this.GetRepository<Season>(); }
        }

        public IDeletableEntityRepository<Stadium> Stadiums
        {
            get { return this.GetRepository<Stadium>(); }
        }

        public IDeletableEntityRepository<Tag> Tags
        {
            get { return this.GetRepository<Tag>(); }
        }

        public IDeletableEntityRepository<Team> Teams
        {
            get { return this.GetRepository<Team>(); }
        }

        public IDeletableEntityRepository<Town> Towns
        {
            get { return this.GetRepository<Town>(); }
        }

        public IDeletableEntityRepository<ApplicationUser> ApplicationUsers
        {
            get { return this.GetRepository<ApplicationUser>(); }
        }

        public IDeletableEntityRepository<LeaguesSeasons> LeaguesSeasons
        {
            get { return this.GetRepository<LeaguesSeasons>(); }
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }

        private IDeletableEntityRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);
                this.repositories.Add(typeof(T),
                    Activator.CreateInstance(type, this.dbContext));
            }

            return (IDeletableEntityRepository<T>)this.repositories[typeof(T)];
        }
    }
}
