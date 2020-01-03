using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCommunityRest.Models.ViewModels
{
    public class AcademiesViewModel
    {
        // for Departments
        public Academy Academy;
        public IEnumerable<Department> Departments;

        // for Groups
        public Department Department;
        public IEnumerable<Group> Groups;
    }
}