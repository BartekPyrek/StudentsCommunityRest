using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCommunityRest.Models
{
    public class NewPostCommentViewModel
    {
        // post
        [Display(Name = "Grupa")]
        public int postGroupID { set; get; }
        public IEnumerable<Group> Gropus { get; set; }


        // coment
        public int PostID { set; get; }
        public Post Post { set; get; }

        // 
        [Display(Name = "Treść")]
        [Required(ErrorMessage = "Musisz podać treść")]
        public string content { set; get; }
        public string returnUrl { set; get; }
    }
}