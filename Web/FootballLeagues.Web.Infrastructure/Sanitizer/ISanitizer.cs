﻿namespace FootballLeagues.Web.Infrastructure.Sanitizer
{
    public interface ISanitizer
    {
        string Sanitize(string html);
    }
}
