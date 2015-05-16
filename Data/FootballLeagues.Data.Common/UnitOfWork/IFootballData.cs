using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballLeagues.Data.Common.Repositories;
using FootballLeagues.Data.Models;
using FootballLeagues.Data.Common.Repository;

namespace FootballLeagues.Data.Common.UnitOfWork
{
    public interface IFootballData
    {
        IDeletableEntityRepository<Comment> Comments { get;  }

        IDeletableEntityRepository<Country> Countries { get;  }

        IDeletableEntityRepository<Game> Games { get;  }
        IDeletableEntityRepository<GameStats> GamesStats { get;  }
        IDeletableEntityRepository<League> Leagues { get;  }
        IDeletableEntityRepository<Manager> Managers { get;  }
        IDeletableEntityRepository<News> News { get;  }
        IDeletableEntityRepository<Owner> Owners { get;  }
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
