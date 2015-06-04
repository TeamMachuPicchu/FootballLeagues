namespace FootballLeagues.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using Common.Global;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using Models.Global;

    internal sealed class Configuration : DbMigrationsConfiguration<FootballDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FootballDbContext context)
        {
            //var directory = AssemblyHelpers.GetDirectoryForAssembly(Assembly.GetExecutingAssembly());
            //var fileLeagues = directory + "/Files/Leagues.txt";

            //this.SeedRoles(context);
            //this.SeedUsers(context);
            //this.SeedCountries(context);
            //this.SeedLeagues(context, fileLeagues);
            //this.seedSeasons(context);

            //context.SaveChanges();

            //var leagues = new HashSet<League>();

            //foreach (var league in context.Leagues)
            //{
            //    leagues.Add(league);
            //}

            //foreach (var season in context.Seasons)
            //{
            //    foreach (var league in leagues)
            //    {
            //        var leagueSeason = new LeaguesSeasons()
            //        {
            //            League = league,
            //            Season = season
            //        };

            //        context.LeaguesSeasons.Add(leagueSeason);
            //    }
            //}

            //foreach (var ls in context.LeaguesSeasons)
            //{
            //    int index;

            //    if (ls.League.Name != "PremierLeague")
            //    {
            //        index = 46;
            //    }
            //    else
            //    {
            //        index = 38;
            //    }

            //    for (int i = 1; i <= index; i++)
            //    {
            //        var round = new Round()
            //        {
            //            Number = i,
            //            LeagueSeason = ls
            //        };

            //        context.Rounds.Add(round);
            //    }
            //}

            //context.SaveChanges();

            //var fileTeams = directory + "/Files/Teams-Towns-Stadiums-Capacity-OrderedByClub.txt";
            //using (var parser = new StreamReader(fileTeams))
            //{
            //    while (!parser.EndOfStream)
            //    {
            //        var line = parser.ReadLine();
            //        var info = line.Split(',');
            //        var stadiumName = info[1];
            //        var cityName = info[2];
            //        var stadiumCapacity = int.Parse(info[3]);
            //        var teamName = info[4];
            //        var yearEstablished = DateTime.ParseExact(info[5], "yyyy", CultureInfo.InvariantCulture);
            //        var competitionName = info[6];
            //        var managerName = info[7];
            //        var countryName = info[8];
            //        var managerBirthDate = DateTime.ParseExact(info[9], "d-mm-yyyy", CultureInfo.InvariantCulture);
            //        // var manageAppointDate = DateTime.ParseExact(info[10], "d-mm-yyyy",System.Globalization.CultureInfo.InvariantCulture);

            //        var country = context.Countries
            //            .FirstOrDefault(c => c.Name == countryName);

            //        var town = new Town()
            //        {
            //            Name = cityName,
            //            Country = country
            //        };

            //        var manager = new Manager()
            //        {
            //            Name = managerName,
            //            // Birthdate = managerBirthDate,
            //            Country = country
            //        };

            //        var stadium = new Stadium()
            //        {
            //            Name = stadiumName,
            //            Capacity = stadiumCapacity,
            //            Town = town
            //        };

            //        var team = new Team()
            //        {
            //            Name = teamName,
            //            Established = yearEstablished,
            //            Manager = manager,
            //            Stadium = stadium
            //        };

            //        context.Managers.Add(manager);
            //        context.Towns.Add(town);
            //        context.Stadiums.Add(stadium);
            //        context.Teams.Add(team);
            //    }
            //}

            //context.SaveChanges();

            //var fileGames = directory + "/Files/Test-Games.txt";
            //using (var reader = new StreamReader(fileGames))
            //{
            //    var round = 1;
            //    var roundGame = 0;

            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var info = line.Split(',');

            //        var period = info[0];
            //        var startYear = int.Parse(info[0].Split('-')[0]);
            //        var endYear = int.Parse(info[0].Split('-')[1]);
            //        var leagueName = info[1];
            //        var defaultDate = new DateTime(1999, 01, 01);
            //        var matchDate = DateTime.TryParseExact(info[2], "dd/mm/yy", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out defaultDate);
            //        var homeTeamName = info[3];
            //        var awayTeamName = info[4];
            //        var homeGoalsFullTime = info[5];
            //        var awayGoalsFullTime = info[6];
            //        var homeGoalsHalfTime = info[7];
            //        var awayGoalsHalfTime = info[8];
            //        var attendance = info[9];
            //        var refereeName = info[10];
            //        var homeShoots = info[11];
            //        var awayShoots = info[12];
            //        var homeShootsOnTarget = info[13];
            //        var awayShootsOnTarget = info[14];
            //        var homeCorners = info[17];
            //        var awayCorners = info[18];
            //        var homeFouls = info[19];
            //        var awayFouls = info[20];
            //        var homeYellowCards = info[23];
            //        var awayYellowCards = info[24];
            //        var homeRedCards = info[25];
            //        var awayRedCards = info[26];

            //        roundGame++;

            //        switch (leagueName)
            //        {
            //            case "PremierLeague":
            //                if (roundGame % 10 == 0)
            //                {
            //                    round++;
            //                    roundGame = 0;

            //                    if (round == 39)
            //                    {
            //                        round = 1;
            //                    }
            //                } break;
            //            case "ChampionShip":
            //                if (roundGame % 12 == 0)
            //                {
            //                    round++;
            //                    roundGame = 0;

            //                    if (round == 47)
            //                    {
            //                        round = 1;
            //                    }
            //                } break;
            //            case "LeagueOne":
            //                if (round % 12 == 0)
            //                {
            //                    round++;
            //                    roundGame = 0;

            //                    if (round == 47)
            //                    {
            //                        round = 1;
            //                    }
            //                } break;
            //            case "LeagueTwo":
            //                if (round % 12 == 0)
            //                {
            //                    round++;
            //                    roundGame = 0;

            //                    if (round == 47)
            //                    {
            //                        round = 1;
            //                    }
            //                } break;
            //            default:
            //                round = 12; break;
            //        }

            //        var leagueSeason = context.LeaguesSeasons
            //            .FirstOrDefault(
            //                ls => ls.League.Name == leagueName && ls.Season.StartYear == startYear);
            //        var currRound = context.Rounds.FirstOrDefault(r => r.Number == round && r.LeaguesSeasonsId == leagueSeason.Id);
            //        var homeTeam = context.Teams.FirstOrDefault(t => t.Name == homeTeamName);
            //        var awayTeam = context.Teams.FirstOrDefault(t => t.Name == awayTeamName);
            //        int hgft, agft, hc, ac, hf, af, hs, aws, hst, awst, hyc, ayc, hrc, arc, att;

            //        var game = new Game()
            //        {
            //            Round = currRound,
            //            HomeTeam = homeTeam,
            //            AwayTeam = awayTeam,
            //            HomeGoals = int.TryParse(homeGoalsFullTime, out hgft) ? int.Parse(homeGoalsFullTime) : 0,
            //            AwayGoals = int.TryParse(awayGoalsFullTime, out agft) ? int.Parse(awayGoalsFullTime) : 0,
            //            HomeCorners = int.TryParse(homeCorners, out hc) ? int.Parse(homeCorners) : 0,
            //            AwayCorners = int.TryParse(awayCorners, out ac) ? int.Parse(awayCorners) : 0,
            //            HomeFouls = int.TryParse(homeFouls, out hf) ? int.Parse(homeFouls) : 0,
            //            AwayFouls = int.TryParse(awayFouls, out af) ? int.Parse(awayFouls) : 0,
            //            HomeShots = int.TryParse(homeShoots, out hs) ? int.Parse(homeShoots) : 0,
            //            AwayShots = int.TryParse(awayShoots, out aws) ? int.Parse(awayShoots) : 0,
            //            HomeShotsOnTarget = int.TryParse(homeShootsOnTarget, out hst) ? int.Parse(homeShootsOnTarget) : 0,
            //            AwayShotsOnTarget = int.TryParse(awayShootsOnTarget, out awst) ? int.Parse(awayShootsOnTarget) : 0,
            //            HomeYellowCards = int.TryParse(homeYellowCards, out hyc) ? int.Parse(homeYellowCards) : 0,
            //            AwayYellowCards = int.TryParse(awayYellowCards, out ayc) ? int.Parse(awayYellowCards) : 0,
            //            HomeRedCards = int.TryParse(homeRedCards, out hrc) ? int.Parse(homeRedCards) : 0,
            //            AwayRedCards = int.TryParse(awayRedCards, out arc) ? int.Parse(awayRedCards) : 0,
            //            Attendance = int.TryParse(attendance, out att) ? int.Parse(attendance) : 0,
            //            StartDate = defaultDate
            //        };

            //        context.Games.Add(game);
            //    }
            //}

            //context.SaveChanges();

            //using (var reader = new StreamReader(@"..\..\Files\Players.txt"))
            //{
            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var info = line.Split(',');
            //        // DateTime matchDate;

            //        // DateTime.TryParseExact(info[0], "dd/mm/yy", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out matchDate);
            //        var lastName = info[2];
            //        var firstName = info[3];
            //        var playerName = firstName + " " + lastName;
            //        var teamName = info[4];
            //        var opponent = info[6];
            //        var venue = info[8];
            //        var position = int.Parse(info[9]);
            //        var minutesPlayed = int.Parse(info[10]);
            //        var starts = int.Parse(info[11]);
            //        var subOn = int.Parse(info[12]);
            //        var subOff = int.Parse(info[13]);
            //        var goals = int.Parse(info[14]);
            //        var penaltyGoals = int.Parse(info[15]);
            //        var penaltySaved = int.Parse(info[16]);
            //        var penaltyMissed = int.Parse(info[17]);
            //        var successPasses = int.Parse(info[29]);
            //        var unSuccessPasses = int.Parse(info[30]);
            //        var assists = int.Parse(info[31]);
            //        var keyPasses = int.Parse(info[32]);
            //        var successDribbles = int.Parse(info[33]);
            //        var unSuccessDribbles = int.Parse(info[34]);
            //        var tacklesWon = int.Parse(info[36]);
            //        var tacklesLost = int.Parse(info[37]);
            //        var offsides = int.Parse(info[40]);
            //        var yellowCards = int.Parse(info[41]);
            //        var redCards = int.Parse(info[42]);
            //        var savesMade = int.Parse(info[43]);
            //        var seasonStartYear = int.Parse(info[47]);

            //        var team = context.Teams.FirstOrDefault(t => t.Name == teamName);
            //        Player player;

            //        if (!context.Players.Any(p => p.Name == playerName))
            //        {
            //            player = new Player()
            //            {
            //                Name = playerName,
            //                CurrentTeam = team,
            //                Position = (Position)position
            //            };

            //            context.Players.Add(player);
            //        }
            //        else
            //        {
            //            player = context.Players.FirstOrDefault(p => p.Name == playerName);
            //        }

            //        string homeTeam, awayTeam;

            //        if (venue == "Home")
            //        {
            //            homeTeam = teamName;
            //            awayTeam = opponent;
            //        }

            //        else
            //        {
            //            homeTeam = opponent;
            //            awayTeam = teamName;
            //        }


            //        var game = context.Games.FirstOrDefault(g => g.HomeTeam.Name == homeTeam &&
            //            g.AwayTeam.Name == awayTeam &&
            //            g.Round.LeagueSeason.Season.StartYear == seasonStartYear &&
            //            g.Round.LeagueSeason.League.Name == "PremierLeague");

            //        //var game =
            //        //    context.Games.FirstOrDefault(g => g.HomeTeam.Name == homeTeam && g.AwayTeam.Name == awayTeam && g.Round.LeagueSeason.Season.EndYear == 2012);

            //        while (goals > 0)
            //        {
            //            var gameStat = new GameStats { Action = Models.Action.Goal, Game = game, Player = player, Team = team };
            //            context.GamesStats.Add(gameStat);
            //            goals--;
            //        }

            //        while (assists > 0)
            //        {
            //            var gameStat = new GameStats { Action = Models.Action.Assists, Game = game, Player = player, Team = team };
            //            context.GamesStats.Add(gameStat);
            //            assists--;
            //        }

            //        while (yellowCards > 0)
            //        {
            //            var gameStat = new GameStats { Action = Models.Action.YellowCard, Game = game, Player = player, Team = team };
            //            context.GamesStats.Add(gameStat);
            //            yellowCards--;
            //        }

            //        while (redCards > 0)
            //        {
            //            var gameStat = new GameStats { Action = Models.Action.RedCard, Game = game, Player = player, Team = team };
            //            context.GamesStats.Add(gameStat);
            //            redCards--;
            //        }

            //        if (minutesPlayed > 0)
            //        {
            //            var gameStat = new GameStats { Action = Models.Action.Played, Game = game, Player = player, Team = team, Time = minutesPlayed };
            //            context.GamesStats.Add(gameStat);
            //        }

            //        context.SaveChanges();
            //    }
            //}

            //context.SaveChanges();
        }

        /*private void seedSeasons(FootballDbContext context)
        {
            for (int startYear = 2000; startYear < 2013; startYear++)
            {
                var season = new Season()
                {
                    StartYear = startYear,
                    EndYear = startYear + 1
                };

                context.Seasons.Add(season);
            }

            context.SaveChanges();
        }

        private void SeedLeagues(FootballDbContext context, string file)
        {
            using (var reader = new StreamReader(file))
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

            context.SaveChanges();

        }

        private void SeedCountries(FootballDbContext context)
        {
            if (context.Countries.Any())
            {
                return;
            }

            var directory = AssemblyHelpers.GetDirectoryForAssembly(Assembly.GetExecutingAssembly());
            var file = directory + "/Files/countries.txt";
            using (var reader = new StreamReader(file))
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

        }

        private void SeedUsers(FootballDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!context.Users.Any(u => u.UserName == "Admin"))
            {
                var admin = new ApplicationUser
                {
                    UserName = "Admin"
                };

                userManager.Create(admin, "password");
                userManager.AddToRole(admin.Id, GlobalConstants.AdministratorRole);
            }

            context.SaveChanges();
        }

        private void SeedRoles(FootballDbContext context)
        {
            if (context.Roles.Any(r => r.Name == GlobalConstants.AdministratorRole))
            {
                return;
            }

            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole(GlobalConstants.AdministratorRole));

            context.SaveChanges();
        }*/
    }
}

