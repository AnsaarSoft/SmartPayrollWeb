using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMstEmployee repo;
        private readonly ILogger<EmployeeController> logger;
        public EmployeeController(IMstEmployee employee, ILogger<EmployeeController> log)
        {
            repo = employee;
            logger = log;
        }
    }
}
