namespace FootballLeagues.Web.Controllers
{
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;

    using Microsoft.AspNet.Identity;

    using Data.Common.UnitOfWork;
    using Data.Models;

    [HandleError]
    public abstract class BaseController : Controller
    {
        public BaseController(IFootballData data)
        {
            this.Data = data;
        }

        protected ApplicationUser User { get; set; }

        protected IFootballData Data { get; set; }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            this.User = this.Data.ApplicationUsers.GetById(requestContext.HttpContext.User.Identity.GetUserId());

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}