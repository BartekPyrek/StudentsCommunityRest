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
    [RoutePrefix("api/Groups")]
    public class GroupsController : ApiController
    {
        // db context
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Groups/{departmentId}
        public IEnumerable<object> Get(int id = 0)
        {
            IEnumerable<Group> groups;
            int departmentId = id;

            if (departmentId == 0)
                groups = db.Groups;
            else
                groups = db.Groups.Where(x => x.Department.ID == departmentId);

            return groups
                    .Select(x => new { x.ID, x.Year, x.Specialization, x.Course, x.Level })
                    ;
        }

        // POST api/Groups/Join/groupID
        [HttpPost][Route("Join")]
        public IHttpActionResult Join(int groupID = 0)
        {
            String userName = RequestContext.Principal.Identity.Name;
            ApplicationUser user = db.Users.Where(x => x.UserName == userName).FirstOrDefault();

            var result = new {
                groupID = groupID,
                userName = userName,
                user = user
            };

            //Console.WriteLine();
            return Ok(result);
        }

    }
}