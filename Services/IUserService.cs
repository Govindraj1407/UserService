using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using UserService.ViewModels;

namespace UserService.Services
{
    public interface IUserService
    {
        bool CreateUser(UserInfo userInfo);
    }
}
