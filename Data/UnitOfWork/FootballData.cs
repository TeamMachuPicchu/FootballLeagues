using Data.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork
{
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

        public IRepository<Comment> Comments
        {
            get { return this.GetRepository<Comment>(); }
        }

        public IRepository<Country> Countries
        {
            get { return this.GetRepository<Country>(); }
        }

        public IRepository<Game> Games
        {
            get { return this.GetRepository<Game>(); }
        }

        public IRepository<GameStats> GamesStats
        {
            get { return this.GetRepository<GameStats>(); }
        }

        public IRepository<League> Leagues
        {
            get { return this.GetRepository<League>(); }
        }

        public IRepository<Manager> Managers
        {
            get { return this.GetRepository<Manager>(); }
        }

        public IRepository<News> News
        {
            get { return this.GetRepository<News>(); }
        }

        public IRepository<Owner> Owners
        {
            get { return this.GetRepository<Owner>(); }
        }

        public IRepository<Player> Players
        {
            get { return this.GetRepository<Player>(); }
        }

        public IRepository<Round> Rounds
        {
            get { return this.GetRepository<Round>(); }
        }

        public IRepository<Season> Seasons
        {
            get { return this.GetRepository<Season>(); }
        }

        public IRepository<Stadium> Stadiums
        {
            get { return this.GetRepository<Stadium>(); }
        }

        public IRepository<Tag> Tags
        {
            get { return this.GetRepository<Tag>(); }
        }

        public IRepository<Team> Teams
        {
            get { return this.GetRepository<Team>(); }
        }

        public IRepository<Town> Towns
        {
            get { return this.GetRepository<Town>(); }
        }

        public IRepository<AppUser> AppUsers
        {
            get { return this.GetRepository<AppUser>(); }
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericFLRepository<T>);
                this.repositories.Add(typeof(T),
                    Activator.CreateInstance(type, this.dbContext));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
