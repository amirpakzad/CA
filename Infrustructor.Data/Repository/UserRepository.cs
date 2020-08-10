using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using Infrustructor.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrustructor.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private UniversityDBContext _context;
        public UserRepository(UniversityDBContext context)
        {
            _context = context;
        }
        public Guid AddUser(User user)
        {
            _context.Add(user);
            return user.UserId;
        }

        public bool isExistEmail(string email)
        {
            return _context.Users.Any(u => u.NormalizedEmail == email);
        }

        public bool isExistUserName(string username)
        {
            return _context.Users.Any(u => u.NormalizedUserName == username);
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
