

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Server.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMstEmployee repoEmployee;
        private readonly IMstUser repoUser;
        private readonly ILogger<EmployeeController> logger;
        public EmployeeController(IMstEmployee employee, IMstUser user, ILogger<EmployeeController> log)
        {
            repoEmployee = employee;
            repoUser = user;
            logger = log;
        }

        
    }
}
