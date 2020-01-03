using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentCommunityRest.Models
{

    public class Academy
    {
        public int ID { get; set; }
		
		[Display(Name = "Nazwa uczelni")]
        public String Name{ get; set; }
		
		[Display(Name = "Miasto")]
        public String City{ get; set; }

        public ICollection<Department> Departments { get; set; }

        public Academy()
        {
            this.Departments = new HashSet<Department>();
        }
    }
}
