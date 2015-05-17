using FootballLeagues.Data.Models.Contracts;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace FootballLeagues.Data.Models
{
    public class Player : Person, IAuditInfo, IDeletableEntity
    {
        public int TeamId { get; set; }

        public virtual Team CurrentTeam { get; set; }

        public int Number { get; set; }

        public Position Position { get; set; }

         public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Specifies whether or not the CreatedOn property should be automatically set.
        /// </summary>
        [NotMapped]
        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn  { get; set; }
    }
}
