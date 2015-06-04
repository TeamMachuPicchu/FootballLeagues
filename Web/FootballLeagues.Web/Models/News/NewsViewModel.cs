namespace FootballLeagues.Web.Models.News
{
    using System.Collections;
    using Data.Models;
    using Infrastructure.Mapping;
    using System;

    public class NewsViewModel : IMapFrom<News>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public string Author { get; set; }

        public DateTime CreatedOn { get; set; }

        public IEnumerable Tags { get; set; }
    }
}