using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Models;

namespace Data.UnitOfWork
{
    public interface IFootballData
    {
        IRepository<Comment> Comments { get;  }

        IRepository<Country> Countries { get;  }

        IRepository<Game> Games { get;  }
        IRepository<GameStats> GamesStats { get;  }
        IRepository<League> Leagues { get;  }
        IRepository<Manager> Managers { get;  }
        IRepository<News> News { get;  }
        IRepository<Owner> Owners { get;  }
        IRepository<Player> Players { get;  }
        IRepository<Round> Rounds { get;  }
        IRepository<Season> Seasons { get;  }
        IRepository<Stadium> Stadiums { get;  }
        IRepository<Tag> Tags { get;  }
        IRepository<Team> Teams { get;  }

        IRepository<Town> Towns { get;  }

        IRepository<AppUser> AppUsers { get; }

        void SaveChanges();
    }
}
