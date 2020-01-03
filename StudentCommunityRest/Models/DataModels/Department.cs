using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCommunityRest.Models
{
    public class Department
    {
        public int ID { get; set; }
		
        public virtual Academy Academy { get; set; }
		
		[Display(Name = "Nazwa wydziału")]
        public string Name { get; set;}

        public ICollection<Group> Groups { get; set; }

        public Department()
        {
            this.Groups = new HashSet<Group>();
        }
    }
}
