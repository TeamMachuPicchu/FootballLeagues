namespace FootballLeagues.Web.Models.Comments
{
    using System.Security.AccessControl;
    using Data.Models;
    using Infrastructure.Mapping;

    public class CommentViewModel : IMapFrom<Comment>
    {
        public string Content { get; set; }

        public int TargetId { get; set; }

        public Target Target { get; set; }

        public ApplicationUser User { get; set; }
    }
}