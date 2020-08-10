using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Interfaces
{
    public interface IUserRepository
    {
        Guid AddUser(User user);
        bool isExistUserName(string username);
        bool isExistEmail(string email);
        void save();
    }
}
