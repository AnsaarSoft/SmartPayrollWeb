using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Response;
using SharedLibrary.ViewModels;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Server.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMstUser repo;
        private readonly IMstEmployee repoEmployee;
        private readonly ILogger<UserController> logger;
        public UserController(IMstUser user, ILogger<UserController> log)
        {
            repo = user;
            logger = log;
        }

        [HttpPost("validateuser")]
        [AllowAnonymous]
        public async Task<ActionResult<ApiResponse>> ValidateUser([FromBody] MstUser oRecord)
        {
            ApiResponse response = new();
            try
            {
                var dbuser = await repo.GetUser(oRecord.UserCode);
                if (dbuser?.Id > 0)
                {
                    if(dbuser.UserCode == "manager")
                    {
                        string PasswordHashBase = "2c8a9c40eb0b09b4423ed500664fb22fde7a7d202cca278b168d89c0963a7f05";
                        string PasswordHashUser = GetHashPassword(oRecord.Password, oRecord.UserCode, dbuser.Id.ToString());
                        if (PasswordHashBase == PasswordHashUser)
                        {
                            vmLogin login = new vmLogin();
                            login.Employee = await repoEmployee.GetEmployee(dbuser.Id) ?? null;
                            login.User = dbuser;
                            login.JwtToken = "new token baby";
                            response.Success = true;
                            response.message = "user validated";
                            response.Data = login;
                            return Ok(response);
                        }
                        else
                        {
                            response.Success = false;
                            response.message = "user not validated";
                            response.Data = null;
                            return Ok(response);
                        }
                    }
                    else
                    {
                        string PasswordHashBase = dbuser.Password;
                        string PasswordHashUser = GetHashPassword(oRecord.Password, oRecord.UserCode, dbuser.Id.ToString());
                        if (PasswordHashBase == PasswordHashUser)
                        {
                            vmLogin login = new vmLogin();
                            login.Employee = await repoEmployee.GetEmployee(dbuser.Id) ?? null;
                            login.User = dbuser;
                            login.JwtToken = "new token baby";
                            response.Success = true;
                            response.message = "user validated";
                            response.Data = login;
                            return Ok(response);
                        }
                        else
                        {
                            response.Success = false;
                            response.message = "user not validated";
                            response.Data = null;
                            return Ok(response);
                        }
                    }
                }
                else
                {
                    response.Success = false;
                    response.message = "user not found.";
                    response.Data = null;
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "exception validateuser");
                response.Success = false;
                response.Error = "exception validateuser";
                response.Data = null;
                return BadRequest(response);
            }
        }
        private string GetHashPassword(string password, string usercode, string id)
        {
            try
            {
                string value = id + usercode + password;
                byte[] inputBytes = Encoding.UTF8.GetBytes(value);
                // Create a new instance of the SHA256 algorithm class
                using (SHA256 sha256 = SHA256.Create())
                {
                    // Compute the hash value from the input byte array
                    byte[] hashBytes = sha256.ComputeHash(inputBytes);
                    // Convert the byte array to a hexadecimal string
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in hashBytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                    return sb.ToString();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "exception gethashpassword  ");
                return "";
            }
        }

    }
}
