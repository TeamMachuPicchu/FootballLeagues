namespace FootballLeagues.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FootballDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FootballDbContext context)
        {
            /*using (var reader = new StreamReader(@"..\..\Files\countries.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var countryAndCode = line.Split(';');
                    var country = countryAndCode[0];

                    context.Countries.Add(new Country()
                    {
                        Name = country
                    });
                }
            }

            context.SaveChanges();

            using (var reader = new StreamReader(@"..\..\Files\Leagues.txt"))
            {
                var country = context.Countries.FirstOrDefault(c => c.Name == "ENGLAND");

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split(',');
                    context.Leagues.Add(new League()
                    {
                        Name = line[0],
                        Logo = line[1],
                        Country = country
                        
                    });
                }
            }

            
            for (int startYear = 2000; startYear < 2015; startYear++)
            {
                var season = new Season()
                {
                    StartYear = startYear,
                    EndYear = startYear + 1
                };

                context.Seasons.Add(season);
            }

            context.SaveChanges();

            var leagues = new HashSet<League>();

            foreach (var league in context.Leagues)
            {
                leagues.Add(league);
            }

            foreach (var season in context.Seasons)
            {
                foreach (var league in leagues)
                {
                    var leagueSeason = new LeaguesSeasons()
                    {
                        League = league,
                        Season = season
                    };

                    context.LeaguesSeasons.Add(leagueSeason);
                }
            }

            context.SaveChanges();

            foreach (var ls in context.LeaguesSeasons)
            {
                int index;

                if (ls.League.Name != "PremierLeague")
                {
                    index = 46;
                }
                else
                {
                    index = 38;
                }

                for (int i = 1; i <= index; i++)
                {
                    var round = new Round()
                    {
                        Number = i,
                        LeagueSeason = ls
                    };

                    context.Rounds.Add(round);
                }    
            }

            context.SaveChanges();

            using (var parser = new StreamReader(@"..\..\Files\Teams-Towns-Stadiums-Capacity-OrderedByClub.txt"))
            {
                while (!parser.EndOfStream)
                {
                    var line = parser.ReadLine();
                    var info = line.Split(',');
                    var stadiumName = info[1];
                    var cityName = info[2];
                    var stadiumCapacity = int.Parse(info[3]);
                    var teamName = info[4];
                    var yearEstablished = DateTime.ParseExact(info[5], "yyyy", CultureInfo.InvariantCulture);
                    var competitionName = info[6];
                    var managerName = info[7];
                    var countryName = info[8];
                    var managerBirthDate = DateTime.ParseExact(info[9], "d-mm-yyyy", CultureInfo.InvariantCulture);
                    // var manageAppointDate = DateTime.ParseExact(info[10], "d-mm-yyyy",System.Globalization.CultureInfo.InvariantCulture);

                    var country = context.Countries
                        .FirstOrDefault(c => c.Name == countryName);
                    
                    var town = new Town()
                    {
                        Name = cityName,
                        Country = country
                    };

                    var manager = new Manager()
                    {
                        Name = managerName,
                        Birthdate = managerBirthDate,
                        Country = country
                    };

                    var stadium = new Stadium()
                    {
                        Name = stadiumName,
                        Capacity = stadiumCapacity,
                        Town = town
                    };

                    var team = new Team()
                    {
                        Name = teamName,
                        Established = yearEstablished,
                        Manager = manager,
                        Stadium = stadium
                    };

                    context.Managers.Add(manager);
                    context.Towns.Add(town);
                    context.Stadiums.Add(stadium);
                    context.Teams.Add(team);
                }
            }

            context.SaveChanges();

            using (var reader = new StreamReader(@"..\..\Files\Test-Games.txt"))
             {
                 var round = 1;
                 var roundGame = 0;

                 while (!reader.EndOfStream)
                 {
                     var line = reader.ReadLine();
                     var info = line.Split(',');

                     var period = info[0];
                     var startYear = int.Parse(info[0].Split('-')[0]);
                     var endYear = int.Parse(info[0].Split('-')[1]);
                     var leagueName = info[1];
                     var defaultDate = new DateTime(1999, 01, 01);
                     var matchDate = DateTime.TryParseExact(info[2], "dd/mm/yy",CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out defaultDate);
                     var homeTeamName = info[3];
                     var awayTeamName = info[4];
                     var homeGoalsFullTime = info[5];
                     var awayGoalsFullTime = info[6];
                     var homeGoalsHalfTime = info[7];
                     var awayGoalsHalfTime = info[8];
                     var attendance = info[9];
                     var refereeName = info[10];
                     var homeShoots = info[11];
                     var awayShoots = info[12];
                     var homeShootsOnTarget = info[13];
                     var awayShootsOnTarget = info[14];
                     var homeCorners = info[17];
                     var awayCorners = info[18];
                     var homeFouls = info[19];
                     var awayFouls = info[20];
                     var homeYellowCards = info[23];
                     var awayYellowCards = info[24];
                     var homeRedCards = info[25];
                     var awayRedCards = info[26];

                     roundGame++;
             
                     switch (leagueName)
                     {
                         case "PremierLeague":
                             if (roundGame % 10 == 0)
                             {
                                 round++;
                                 roundGame = 0;
             
                                 if (round == 39)
                                 {
                                     round = 1;
                                 }
                             } break;
                         case "ChampionShip":
                             if (roundGame % 12 == 0)
                             {
                                 round++;
                                 roundGame = 0;
             
                                 if (round == 47)
                                 {
                                     round = 1;
                                 }
                             } break;
                         case "LeagueOne":
                             if (round % 12 == 0)
                             {
                                 round++;
                                 roundGame = 0; 
             
                                 if (round == 47)
                                 {
                                     round = 1;
                                 }
                             } break;
                         case "LeagueTwo":
                             if (round % 12 == 0)
                             {
                                 round++;
                                 roundGame = 0;
              
                                 if (round == 47)
                                 {
                                     round = 1;
                                 }
                             } break;
                         default:
                             round = 10; break;
                     }

                     var leagueSeason = context.LeaguesSeasons
                         .FirstOrDefault(
                             ls => ls.League.Name == leagueName && ls.Season.StartYear == startYear);
                     var currRound = context.Rounds.FirstOrDefault(r => r.LeagueSeason.LeagueId == leagueSeason.LeagueId);
                     var homeTeam = context.Teams.FirstOrDefault(t => t.Name == homeTeamName);
                     var awayTeam = context.Teams.FirstOrDefault(t => t.Name == awayTeamName);
                     int hgft, agft, hc, ac, hf, af, hs, aws, hst, awst, hyc, ayc, hrc, arc, att;

                     var game = new Game()
                     {
                         Round = currRound,
                         HomeTeam = homeTeam,
                         AwayTeam = awayTeam,
                         HomeGoals = int.TryParse(homeGoalsFullTime, out hgft) ? int.Parse(homeGoalsFullTime) : 0,
                         AwayGoals = int.TryParse(awayGoalsFullTime, out agft) ? int.Parse(awayGoalsFullTime) : 0,
                         HomeCorners = int.TryParse(homeCorners, out hc) ? int.Parse(homeCorners) : 0,
                         AwayCorners = int.TryParse(awayCorners, out ac) ? int.Parse(awayCorners) : 0,
                         HomeFouls = int.TryParse(homeFouls, out hf) ? int.Parse(homeFouls) : 0,
                         AwayFouls = int.TryParse(awayFouls, out af) ? int.Parse(awayFouls) : 0,
                         HomeShots = int.TryParse(homeShoots, out hs) ? int.Parse(homeShoots) : 0,
                         AwayShots = int.TryParse(awayShoots, out aws) ? int.Parse(awayShoots) : 0,
                         HomeShotsOnTarget = int.TryParse(homeShootsOnTarget, out hst) ? int.Parse(homeShootsOnTarget) : 0,
                         AwayShotsOnTarget = int.TryParse(awayShootsOnTarget, out awst) ? int.Parse(awayShootsOnTarget) : 0,
                         HomeYellowCards = int.TryParse(homeYellowCards, out hyc) ? int.Parse(homeYellowCards) : 0,
                         AwayYellowCards = int.TryParse(awayYellowCards, out ayc) ? int.Parse(awayYellowCards) : 0,
                         HomeRedCards = int.TryParse(homeRedCards, out hrc) ? int.Parse(homeRedCards) : 0,
                         AwayRedCards = int.TryParse(awayRedCards, out arc) ? int.Parse(awayRedCards) : 0,
                         Attendance = int.TryParse(attendance, out att) ? int.Parse(attendance) : 0,
                         StartDate = defaultDate
                     };

                     context.Games.Add(game);
                 }
             }*/
        }
    }
}

