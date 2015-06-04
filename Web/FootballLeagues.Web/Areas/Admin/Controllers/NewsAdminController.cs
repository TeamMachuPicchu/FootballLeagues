namespace FootballLeagues.Web.Areas.Admin.Controllers
{
    using System.Web.Mvc;
    using Data.Common.UnitOfWork;
    using Data.Models;
    using Infrastructure.Sanitizer;
    using Models.News;
    using Web.Controllers;

    public class NewsAdminController : BaseController
    {
        private readonly ISanitizer sanitizer;


        public NewsAdminController(IFootballData data, ISanitizer sanitizer)
            : base(data)
        {
            this.sanitizer = sanitizer;
        }
        
        [HttpGet]
        public ActionResult PostNews()
        {
            var model = new NewsInputModel();
            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostNews(NewsInputModel model)
        {
            if (ModelState.IsValid)
            {
                var news = new News()
                {
                    Title = model.Title,
                    Content = sanitizer.Sanitize(model.Content),
                    User = this.User
                };

                base.Data.News.Add(news);

                base.Data.News.SaveChanges();
                return this.RedirectToAction("Details", "News", new { area = "", news.Id });
            }

            return this.View(model);
        }
    }
}