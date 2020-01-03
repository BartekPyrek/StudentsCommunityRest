using System;

namespace StudentCommunityRest.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public virtual Post Post { get; set; }
        public virtual ApplicationUser User { get; set; }
        public DateTime Datetime { get; set; }
        public String Content { get; set; }
    }
}
