using Microsoft.AspNetCore.Mvc;
using UserService.ViewModels;
using UserService.Services;

namespace UserService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInfoController : ControllerBase
    {
        private readonly IUserService userService;

        public UserInfoController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] UserInfo userInfo)
        {
            if(this.ModelState.IsValid && this.userService.CreateUser(userInfo))
            {
                return this.NoContent();
            }
            else
            {
                return this.BadRequest("Invalid request, please check the request parameter.");
            }
           
        }
    }
}
