using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentCommunityRest.Models
{
    public class GroupJoinViewModel
    {
        [Display(Name = "Miasto")]
        public string postCity { get; set; }
        public int postAcademy { get; set; }
        public int postDepartment { get; set; }
        public int postGroup { get; set; }

        public List<String> cityList { get; set; }

        [Display(Name = "Uczelnia")]
        public IEnumerable<Academy> academyList { get; set; }

        [Display(Name = "Wydział")]
        public IEnumerable<Department> departmentList { get; set; }

        [Display(Name = "Grupa")]
        public IEnumerable<Group> groupsList { get; set; }
    }
} 