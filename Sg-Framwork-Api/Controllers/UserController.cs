using BL.DTO;
using BL.UserBLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sg_Framwork_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBLL _userBLL;
        public UserController(IUserBLL userBLL) 
        {
          _userBLL = userBLL;
        }
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            try 
            {
             var result = await _userBLL.GetUsers();
                return Ok(result);
            }
            catch (Exception ex) 
            {
              return BadRequest(ex.Message);

            }
        }
        [HttpGet]
        public async Task<IActionResult> GetUserByUserName(string Username) 
        {
            try
            {
                var result = await _userBLL.GetUserById(Username);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddNewUser(UserDTO user)
        {
            try 
            {

                if (user != null)
                { 
                 var result = await _userBLL.AddNewUser(user);
                    return Ok(result);
                }
                return BadRequest();
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
