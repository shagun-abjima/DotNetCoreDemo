using EmployeeApi.Data;
using EmployeeApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserDbContext _context;
        public LoginController(UserDbContext userDbContext)
        {
            _context = userDbContext;
                
        }
        [HttpGet("users")]
        public IActionResult GetUsers() 
        {
            var userDetails = _context.UserModels.AsQueryable();
            return Ok(userDetails);
        }
        [HttpPost("signup")]
        public IActionResult SignUp([FromBody] UserModel userObj)
        {
            if (userObj == null)
            {
                return BadRequest();
            }
            else
            {
                _context.UserModels.Add(userObj);
                _context.SaveChanges();
                return Ok(new
                {
                    StatusCode = 200,
                    Message = "User Added Successfully!",
                    
                }) ;
            }           
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserModel userObj) 
        {
            if(userObj == null)
            {
                return BadRequest();
            }
            else
            {
                var user= _context.UserModels.Where(a=>a.UserName == userObj.UserName
                && a.Password== userObj.Password
                ).FirstOrDefault();
                if (user != null)
                {
                    return Ok(new
                    {
                        StatusCode=200,
                        Message="Logged in Successfully",
                        UserData= userObj.FullName
                    });
                }
                else
                {
                    return NotFound(new
                    {

                        StatusCode=404,
                        Message="User Not Found!"
                    });
                }
            }
        }
    }
}
