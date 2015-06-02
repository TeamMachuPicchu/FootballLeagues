namespace FootballLeagues.Web.Utils
{
    using System.Linq;
    using Data.Common.UnitOfWork;
    using Data.Models;
    using Models;

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

        public static int GetIdByPeriod(string period)
        {
            var years = period.Split('-');
            int startYear = int.Parse(years[0]);
            int endYear = int.Parse(years[1]);
            var id = data.Seasons.All().FirstOrDefault(p => p.StartYear == startYear && p.EndYear == endYear).Id;

            return id;
        }

        public static Season GetSeasonByEndYear(int endYear)
        {
            return data.Seasons.All().FirstOrDefault(s => s.EndYear == endYear);
        }
    }
}