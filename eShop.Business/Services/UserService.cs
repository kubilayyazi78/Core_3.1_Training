using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.Business.Services
{
    public class UserService : IUserService
    {
        public Users isValidUser(string userName, string password)
        {
            var user = FakeUsers.GetUsers().FirstOrDefault(x => x.UserName == userName && x.Password == password);
            return user;
        }

        public static class FakeUsers
        {
            public static List<Users> GetUsers()
            {
                return new List<Users>
                {
                    new Users { UserName="kubilay", Password ="yazi"}
                };
            }
        }
    }
}
