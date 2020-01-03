using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using StudentCommunityRest.DAL;
using StudentCommunityRest.Models;


namespace StudentCommunityRest.Controllers
{
    [Authorize]
    [RoutePrefix("api/Academies")]
    public class AcademiesController : ApiController
    {
        // db context
        private ApplicationDbContext db = new ApplicationDbContext();
        

        // GET api/academies{?cityName=jakieśMiasto}
        public IEnumerable<Academy> Get(string cityName = "")
        {
            if (cityName == "")
                return db.Academies.ToList();
            else
                return db.Academies.Where(x => x.City == cityName).ToList();
        }


        // GET api/academies/Cities
        [Route("Cities")]
        public List<string> GetCities()
        {
            return db.Academies.Select(x => x.City).Distinct().ToList();
        }

    }
}