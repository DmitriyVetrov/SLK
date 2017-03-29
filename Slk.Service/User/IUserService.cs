using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Slk.Models;

namespace Slk.Services
{
    public interface IUserService
    {
        OperationResult Create(User user, string password);
        OperationResult SignIn(string email, string password);
    }
}