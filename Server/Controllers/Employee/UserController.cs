using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMstUser repo;
        private readonly ILogger<UserController> logger;
        public UserController(IMstUser user, ILogger<UserController> log)
        {
            repo = user;
            logger = log;
        }

        [HttpGet]
        public async Task<ActionResult> ValidateUser([FromBody] MstUser oRecord)
        {
            try
            {
                var result = await repo.GetUser(oRecord.Id);
                if (result is null)
                {
                    return BadRequest("User not found.");
                }
                return Ok("User found.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return BadRequest("Server error");
            }
        }
    }
}
