using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using UserService.ViewModels;

namespace UserService.Services
{
    public class UserService: IUserService
    {
        public bool CreateUser(UserInfo userInfo)
        {
            if(userInfo == null)
            {
                return false;
            }
            string json = JsonSerializer.Serialize(userInfo);
            File.WriteAllText(@"C:\userinfopath.json", json);
            return true;
        }
    }
}
