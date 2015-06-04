using FootballLeagues.Data.Common.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace FootballLeagues.Web.Controllers
{
    public class PlayersController : BaseController
    {
        public PlayersController(IFootballData data)
            : base(data)
        {
            
        }

        //
        // GET: /Players/
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.NickameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var players = this.Data.Players.All();

            if (!String.IsNullOrEmpty(searchString))
            {
                players = players.Where(p => p.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    players = players.OrderByDescending(p => p.Name);
                    break;
                case "nickname_desc":
                    players = players.OrderBy(s => s.Nickname);
                    break;
                default:  // Name ascending  
                    players = players.OrderByDescending(p => p.Name);
                    break;
            }

            int pageSize = 20;
            int pageNumber = (page ?? 1);
            return View(players.ToPagedList(pageNumber, pageSize));
        } 
	}
}