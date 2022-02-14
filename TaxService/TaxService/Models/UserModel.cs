using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxService.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleId { get; set; }
    }
}