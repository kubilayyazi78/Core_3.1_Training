using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace eShop.Domain
{
    public class Users
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime LastLoginDate { get; set; }
        public string Role { get; set; }
    }
}
