namespace FootballLeagues.Web.Infrastructure.Sanitizer
{
    using Ganss.XSS;

    public class Sanitizer : ISanitizer
    {
        public string Sanitize(string html)
        {
            var sanitizer = new HtmlSanitizer();

            return html;
        }
    }
}
