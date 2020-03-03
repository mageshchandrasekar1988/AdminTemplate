using System;
using System.Collections.Generic;

namespace GatesAdministratorTool.Models
{
    public partial class UserDetails
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
