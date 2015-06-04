namespace FootballLeagues.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;
    using Data.Common.UnitOfWork;
    using Infrastructure.Sanitizer;
    using Models.News;

    public class NewsController : BaseController
    {

        public NewsController(IFootballData data) 
            :base(data)
        {
        }

        // GET: News
        public ActionResult Index()
        {
            var news = base.Data.News
                .All()
                .Project()
                .To<NewsViewModel>()
                .OrderByDescending(n => n.CreatedOn)
                .Take(5)
                .ToList();

            return View(news);
        }

        public ActionResult Details(int id)
        {
            var news = base.Data.News
                .All()
                .Project()
                .To<NewsViewModel>()
                .FirstOrDefault(n => n.Id == id);

            return this.View(news);
        }
    }
}