using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCommunityRest.Models
{
    public class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int ID { get; set; }
        public virtual Group Group { get; set; }
        public virtual ApplicationUser User { get; set; }
        public DateTime Datetime { get; set; }
        public String Content { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
