using FootballLeagues.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagues.Data.Models
{
    public class Tag : BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
