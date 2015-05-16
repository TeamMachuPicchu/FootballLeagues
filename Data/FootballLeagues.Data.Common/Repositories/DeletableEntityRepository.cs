﻿namespace FootballLeagues.Data.Common.Repository
{
    using FootballLeagues.Data.Common.Repositories;
    using FootballLeagues.Data.Models.Contracts;
    using System.Data.Entity;
    using System.Linq;

    public class DeletableEntityRepository<T> : GenericRepository<T>, IDeletableEntityRepository<T>
        where T : class, IDeletableEntity
    {
        public DeletableEntityRepository(DbContext context)
            : base(context)
        {
        }

        public override IQueryable<T> All()
        {
            return base.All().Where(x => !x.IsDeleted);
        }

        public IQueryable<T> AllWithDeleted()
        {
            return base.All();
        }
    }
}