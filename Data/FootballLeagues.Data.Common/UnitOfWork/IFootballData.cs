namespace FootballLeagues.Data.Common.UnitOfWork
{
    using Models;
    using Repositories;

    public interface IFootballData
    {
        IDeletableEntityRepository<Comment> Comments { get;  }

        IDeletableEntityRepository<Country> Countries { get;  }

        IDeletableEntityRepository<Game> Games { get;  }

        IDeletableEntityRepository<GameStats> GamesStats { get;  }

        IDeletableEntityRepository<League> Leagues { get;  }

        IDeletableEntityRepository<Manager> Managers { get;  }

        IDeletableEntityRepository<News> News { get;  }

        // IDeletableEntityRepository<Owner> Owners { get;  }

        IDeletableEntityRepository<Player> Players { get;  }

        IDeletableEntityRepository<Round> Rounds { get;  }

        IDeletableEntityRepository<Season> Seasons { get;  }

        IDeletableEntityRepository<Stadium> Stadiums { get;  }

        IDeletableEntityRepository<Tag> Tags { get;  }

        IDeletableEntityRepository<Team> Teams { get;  }

        IDeletableEntityRepository<Town> Towns { get;  }

        IDeletableEntityRepository<ApplicationUser> ApplicationUsers { get; }

        void SaveChanges();
    }
}
