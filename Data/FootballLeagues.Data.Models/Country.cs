namespace FootballLeagues.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
<<<<<<< Updated upstream

=======
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
>>>>>>> Stashed changes
    using Contracts;

    public class Country : BaseModel
    {
        public Country()
        {
            this.Towns = new HashSet<Town>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Town> Towns { get; set; }
    }
}
