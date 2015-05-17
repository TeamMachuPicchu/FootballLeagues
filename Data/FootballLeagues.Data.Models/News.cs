namespace FootballLeagues.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Contracts;

    public class News : BaseModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(10000)]
        public string Content { get; set; }

        public DateTime Published { get; set; }

        public int UserId { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        // What is this about? 
        public bool IsActive { get; set; }
    }
}
