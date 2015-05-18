namespace FootballLeagues.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.IO;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FootballDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FootballDbContext context)
        {/*
            using (TextFieldParser parser = new TextFieldParser(@"..\..\Files\E0.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        Console.WriteLine(field);
                    }
=======
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

            using (var parser = new StreamReader(@"..\..\Files\Teams-Towns-Stadiums-Capacity-OrderedByClub.txt"))
            {
                while (!parser.EndOfStream)
                {
                    //Processing row
                    var line = parser.ReadLine();
                    var stats = line.Split(',');
                }
            }

            /*using (var reader = new StreamReader(@"..\..\Files\Teams.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var team = reader.ReadLine();
                    context.Teams.Add(new Team()
                    {
                        Name = team
                    });
>>>>>>> Stashed changes
                }
            }*/
        }
    }
}
