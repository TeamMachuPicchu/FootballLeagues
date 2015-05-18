namespace FootballLeagues.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Core.Metadata.Edm;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using Microsoft.VisualBasic.FileIO;
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
            using (var reader = new StreamReader(@"..\..\Files\countries.txt"))
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

            using (var reader = new StreamReader(@"..\..\Files\Leagues.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    context.Leagues.Add(new League()
                    {
                        Name = line
                    });
                }
            }

            context.SaveChanges();

            using (var parser = new StreamReader(@"..\..\Files\Teams-Towns-Stadiums-Capacity-OrderedByClub.txt"))
            {
                while (!parser.EndOfStream)
                {
                    //Processing row
                    var line = parser.ReadLine();
                    var info = line.Split(',');
                    var stadiumName = info[1];
                    var cityName = info[2];
                    var stadiumCapacity = int.Parse(info[3]);
                    var teamName = info[4];
                    var yearEstablished = DateTime.ParseExact(info[5], "yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    var competitionName = info[6];
                    var managerName = info[7];
                    var countryName = info[8];
                    var managerBirthDate = DateTime.ParseExact(info[9], "d-mm-yyyy", System.Globalization.CultureInfo.InvariantCulture);
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
        }
    }
}

