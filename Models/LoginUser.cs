using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivestockMgmt.Models
{
    public class LoginUser : IdentityUser
    {
        public string Email { get; set; }

        public string Password { get; set; }

        [Column("role_id")]
        public int role_id { get; set; }
        [Column("status")]
        public int status { get; set; }
    }
}
