namespace FootballLeagues.Data.Models.Contracts
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BaseModel : IAuditInfo, IDeletableEntity
    {

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
