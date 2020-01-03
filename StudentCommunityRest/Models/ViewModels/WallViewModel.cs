using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentCommunityRest.Class;

namespace StudentCommunityRest.Models
{
    public class WallViewModel
    {
        public string searchString;
        public ApplicationUser User { get; set; }
        public Calendar Calendar { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}