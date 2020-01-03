using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using StudentCommunityRest.DAL;
using StudentCommunityRest.Models;

namespace StudentCommunityRest.Controllers
{
    [Authorize]
    [RoutePrefix("api/Departments")]
    public class DepartmentsController : ApiController
    {
        // db context
        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: Departments/{academyId}
        public IEnumerable<object> Get(int id = 0)
        {
            IEnumerable<Department> departments;
            int academyId = id;

            if (academyId == 0)
                departments = db.Departments;
            else
                departments = db.Departments.Where(x => x.Academy.ID == academyId);

            return departments
                    .Select(x => new { x.ID, x.Name })
                    ;
        }
    }
}