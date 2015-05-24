namespace FootballLeagues.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Contracts;

    public class Comment : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }

        public int TargetId { get; set; }

        public Target Target { get; set; }

        public int UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public bool IsActive { get; set; }
    }
}
