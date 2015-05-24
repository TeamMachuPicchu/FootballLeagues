namespace FootballLeagues.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Data.Common.UnitOfWork;
    using Data.Models;
    using Models;

    public class GameController : Controller
    {
        private FootballData data = new FootballData();

        // GET: Game
        public ActionResult Index(int id)
        {
            var game = this.data.Games
                .All()
                .Project()
                .To<GameViewModel>()
                .FirstOrDefault(g => g.Id == id);

            return View(game);
        }
    }
}