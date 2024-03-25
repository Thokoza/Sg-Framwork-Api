using BL.DTO;
using BL.RoleBLL;
using DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sg_Framwork_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleBLL _iroleBLL;

        public RoleController(IRoleBLL iroleBLL)
        { 
         _iroleBLL = iroleBLL;
        }
        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {

            try 
            {
                var result = await _iroleBLL.GetRoles();
                return Ok(result);
            }
            catch (Exception ex)
            {
             return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetRoleById(int id)
        {
            try 
            {
             var result = await _iroleBLL.GetRoleById(id);
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        
        }
        [HttpPost]
        public async Task<IActionResult> AddNewRolde(RoleDTO role)
        {
            try
            {
                if (role != null)
                {
                    var result = await _iroleBLL.AddNewRolde(role);
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
