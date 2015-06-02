namespace FootballLeagues.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNet.Identity.EntityFramework;

    using Contracts;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            //This will prevent UserManager.CreatedAsync from causing exception
            this.CreatedOn = DateTime.Now;
        }

        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }

        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Specifies whether or not the CreatedOn property should be automatically set.
        /// </summary>
        [NotMapped]
        public bool PreserveCreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
