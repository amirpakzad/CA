using CleanArch.Application.Interfaces;
using CleanArch.Application.Security;
using CleanArch.Application.ViewModel;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CleanArch.Application.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userrepository)
        {
            _userRepository = userrepository;
        }

        public CheckUser CheckUser(string username, string email)
        {
            bool Email = _userRepository.isExistEmail(email.Trim().ToUpper());
            bool UserName = _userRepository.isExistUserName(username.Trim().ToUpper());
            if (!UserName && !Email)
                return ViewModel.CheckUser.Success;
            else if (UserName)
                return ViewModel.CheckUser.UserNameNotValid;
            else if (Email)
                return ViewModel.CheckUser.EmailNotValid;
            else
                return ViewModel.CheckUser.UserNameNotValid;
        }

        public Guid RegisterUser(RegisterViewModel register)
        {
            User user = new User()
            {
                Email = register.Email,
                NormalizedEmail = register.Email.Trim().ToUpper(),
                UserName = register.UserName,
                NormalizedUserName = register.UserName.Trim().ToUpper(),
                Password = PasswordHelper.EncodePasswordMd5(register.Password)
                
            };
            _userRepository.AddUser(user);
            _userRepository.save();
            return user.UserId;
        }
    }
}
