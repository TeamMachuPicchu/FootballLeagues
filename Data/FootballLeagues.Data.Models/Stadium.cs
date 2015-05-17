namespace FootballLeagues.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using Contracts;

    public class Stadium : BaseModel
    {
        public int Id { get; set; }
    
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int Capacity { get; set; }

        public string Photo { get; set; }

        public int TownId { get; set; }

        public virtual Town Town { get; set; }
    }
}
