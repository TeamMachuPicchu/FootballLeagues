namespace FootballLeagues.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Data.Common.UnitOfWork;
    using Models;

    public class RoundsController : Controller
    {
        private FootballData data = new FootballData();

        public ActionResult View(int roundId, int number, string season, string leagueName)
        {
            var games = this.data.Games
                .All()
                .Project()
                .To<GameViewModel>()
                .Where(g => g.Round.Id == roundId)
                .ToList();

            foreach (var game in games)
            {
                game.Season = season;
            }

            

            return this.View(games);
        }
    }
}