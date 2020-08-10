using CleanArch.Application.ViewModel;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface IUserService
    {
        CheckUser CheckUser(string username, string email);
        Guid RegisterUser(RegisterViewModel register);
    }
}
