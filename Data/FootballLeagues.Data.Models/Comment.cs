using FootballLeagues.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagues.Data.Models
{
    public class Comment : BaseModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int TargetId { get; set; }

        public Target Target { get; set; }

        public int UserId { get; set; }

        public bool IsActive { get; set; }
    }
}
