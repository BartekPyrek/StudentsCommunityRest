using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCommunityRest.Models
{
    public enum Course
    {
        fulltime,
        extramural
    }

    public enum Level
    {
        first,
        second
    }

    public class Group
    {
        public Group()
        {
            this.Posts = new HashSet<Post>();
            this.Members = new HashSet<ApplicationUser>();
            this.Moderators = new HashSet<Moderate>();
            this.Events = new HashSet<Event>();
        }

        public int ID { get; set; }

        public virtual Department Department { get; set; }

        [Required]
        [Display(Name = "Rocznik")]
        //[Range(2010, 2030, ErrorMessage = "Coś nie tak z rokiem...")]
        public int Year { get; set; }

        
        [Required]
        [Display(Name = "Nazwa kierunku")]
        public String Specialization { get; set; }

        
        [Required]
        [Display(Name = "Tryb")]
        public Course  Course { get; set; }

        
        [Required]
        [Display(Name = "Stopień")]
        public Level Level { get; set; }


        [Display(Name = "Data utworzenia")]
        public DateTime? CreationDate { get; set; }

        //[Display(Name = "Utworzona przez")]
        //public virtual ApplicationUser CreatedBy { get; set; }

        [Display(Name = "Data unieważnienia")]
        public DateTime? CancellationDate { get; set; }


        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<ApplicationUser> Members { get; set; }
        public virtual ICollection<Moderate> Moderators { get; set; }
        public virtual ICollection<Event> Events { get; set; }

        public override string ToString()
        {
            var course = (this.Course == Course.fulltime ? "S" : "NS");
            var level = (this.Level == Level.first ? "1st." : "2st.");
            return $"{this.Specialization} {course} {level} {this.Year}";
        }

        [Display(Name = "Nazwa grupy")]
        public string Name
        {
            get{
                return this.ToString();
            }
        }
    }
}
