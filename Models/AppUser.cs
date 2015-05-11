using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Models
{
    public class AppUser : IdentityUser
    {

        public int TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}
