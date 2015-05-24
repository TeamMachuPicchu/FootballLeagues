using FootballLeagues.Data.Common.UnitOfWork;
using FootballLeagues.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballLeagues.Web.Utils
{
    using Data.Models;

    public static class Seasons
    {
        private static readonly FootballData data = new FootballData();

        public static SeasonPeriod GetSeasonPeriodFromUrlParameter(string parameter, char delimeter)
        {
            var periodData = parameter.Split(delimeter).Select(x => int.Parse(x)).ToArray();

            var seasonPeriod = new SeasonPeriod { StartYear = periodData[0], EndYear = periodData[1] };

            return seasonPeriod;
        }

        public static int GetIdByPeriod(SeasonPeriod period)
        {
            var id = data.Seasons.All().FirstOrDefault(p => p.StartYear == period.StartYear && p.EndYear == period.EndYear).Id;

            return id;
        }

        public static Season GetSeasonByEndYear(int endYear)
        {
            return data.Seasons.All().FirstOrDefault(s => s.EndYear == endYear);
        }
    }
}