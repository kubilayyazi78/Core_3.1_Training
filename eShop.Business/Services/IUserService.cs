using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Business.Services
{
    public interface IUserService
    {
        Users isValidUser(string userName, string password);
    }
}
