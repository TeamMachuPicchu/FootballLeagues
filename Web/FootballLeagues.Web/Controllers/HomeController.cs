namespace FootballLeagues.Web.Controllers
{
    using System.Web.Mvc;
    using Data.Common.UnitOfWork;

    public class HomeController : BaseController
    {
        public HomeController(IFootballData data)
            :base(data)
        {
            
        }

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}