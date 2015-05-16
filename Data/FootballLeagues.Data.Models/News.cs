using FootballLeagues.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagues.Data.Models
{
    public class News : BaseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Published { get; set; }

        public int UserId { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public bool IsActive { get; set; }
    }
}
