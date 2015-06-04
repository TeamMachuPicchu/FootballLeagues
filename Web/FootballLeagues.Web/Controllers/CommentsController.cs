namespace FootballLeagues.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Data.Common.UnitOfWork;
    using Data.Models;
    using Models.Comments;

    public class CommentsController : BaseController
    {
        public CommentsController(IFootballData data)
            :base(data)
        {
        }

        // GET: Comments
        public ActionResult Get(int id, Target target)
        {
            var comments = base.Data.Comments
                .All()
                .Project()
                .To<CommentViewModel>()
                .Select(c => c.TargetId == id && c.Target == target)
                .ToList();

            return PartialView(comments);
        }

        [ValidateAntiForgeryToken]
        public ActionResult Post()
        {

            return PartialView();
        }
    }
}