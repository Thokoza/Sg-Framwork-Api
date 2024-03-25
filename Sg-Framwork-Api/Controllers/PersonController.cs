using BL.DTO;
using BL.PersonBLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sg_Framwork_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonBLL _personBLL;

        public PersonController(IPersonBLL personBLL)
        { 
         _personBLL = personBLL;
        }

        [HttpGet]
        public async Task<IActionResult> GetPerson(string EmailAddress)
        {
            try 
            {
                var result = await _personBLL.GetPerson(EmailAddress);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> InsertPerson([FromBody]PersonDTO person)
        {
            try
            {

                if (person != null)
                {
                    var result = await _personBLL.InsertPerson(person);
                    return Ok(result);
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePerson(PersonDTO person)
        {
            try
            { 
                var result = await _personBLL.UpdatePerson(person);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
