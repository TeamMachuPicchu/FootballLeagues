namespace FootballLeagues.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using Data;
    using Data.Common.UnitOfWork;
    using Data.Models;
    using Models.League;
    using Models.LeagueSeason;
    using Models.News;
    using Models.Rounds;
    using Models.Teams;
    using Utils;
    using LeaguesSeasons = Utils.LeaguesSeasons;

    public class LeaguesController : Controller
    {
        private FootballData data = new FootballData();

        [OutputCache(Duration = 30 * 60)]
        public ActionResult Index()
        {
            var leagues = this.data
                .Leagues
                .All()
                .Project()
                .To<LeagueViewModel>()
                .ToList();

            return View(leagues);
        }

        // GET: Leagues/Details/5
        public ActionResult Details(int id)
        {
            var league = data.Leagues.GetById(id);
            var season = this.data.Seasons.All().OrderByDescending(s => s.EndYear).FirstOrDefault();

            if (league == null || season == null)
            {
                return HttpNotFound();
            }
            // TODO Get the teams per leagueSeason

            var leagueSeason = LeaguesSeasons.GetLeaguesSeasons(id, season.Id);
            var roundsIds = Rounds.GetIdsByLeaguesSeasonsId(leagueSeason.Id);
            var rounds = new List<RoundsViewModel>();
            var leaguesSeasons = this.data.LeaguesSeasons
                .All()
                .Where(ls => ls.LeagueId == league.Id)
                .Select(ls => new LeaguesSeasonsViewModel{ LeagueId = ls.LeagueId, StartYear = ls.Season.StartYear, EndYear = ls.Season.EndYear})
                .ToList();

            foreach (var rnd in roundsIds)
            {
                var round = this.data.Rounds.All().Project().To<RoundsViewModel>().FirstOrDefault(r => r.Id == rnd);
                round.LeagueName = league.Name;
                round.Season = string.Format("{0}-{1}", season.StartYear, season.EndYear);
                rounds.Add(round);
            }

            // RedirectToAction("Index", "Rounds");
            return View(Tuple.Create(rounds, leaguesSeasons));
        }
    }
}
