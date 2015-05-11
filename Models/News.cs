using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class News
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
