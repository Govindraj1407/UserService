using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.ViewModels
{
    public class UserInfo
    {
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
