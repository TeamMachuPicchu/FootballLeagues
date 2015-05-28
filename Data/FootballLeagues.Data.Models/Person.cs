namespace FootballLeagues.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Contracts;

    public abstract class Person : BaseModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Nickname { get; set; }

        public string Photo { get; set; }

        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }

        public string Info { get; set; }

        // public DateTime Birthdate { get; set; }

        /*public int Age()
        {
            DateTime today = DateTime.Today;
            DateTime bday = this.Birthdate;
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }*/
    }
}
