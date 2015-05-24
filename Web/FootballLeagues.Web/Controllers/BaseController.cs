namespace FootballLeagues.Web.Controllers
{
    using System.Web.Mvc;
    using Data.Common.UnitOfWork;

    public abstract class BaseController : Controller
    {
        private FootballData data;

        protected FootballData Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
    }
}