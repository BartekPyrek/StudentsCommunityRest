using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System;
using System.Linq;

namespace StudentCommunityRest.Models
{
    // Możesz dodać dane profilu dla użytkownika, dodając więcej właściwości do klasy ApplicationUser.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Element authenticationType musi pasować do elementu zdefiniowanego w elemencie CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Dodaj tutaj niestandardowe oświadczenia użytkownika
            return userIdentity;
        }

        // to teraz dodałem
        public ApplicationUser()
        {
            this.Posts = new HashSet<Post>();
            this.Groups = new HashSet<Group>();
            this.Moderates = new HashSet<Moderate>();
        }

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Moderate> Moderates { get; set; }


        public Boolean IsModerator()
        {
            return (this.Moderates.Count != 0);
        }

        /// <summary>
        /// Sprawdza czy użytkownik jest modedatorem
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public Boolean IsModeratorOfGroup(Group group)
        {
            return (this.Moderates.Where(m => m.Group == group).FirstOrDefault() != null);
        }
    }
}