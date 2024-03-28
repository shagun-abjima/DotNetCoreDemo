using EmployeeApi.Data;
using EmployeeApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly UserDbContext _context;
        public EmployeeController(UserDbContext userDbContext)
        {
            _context = userDbContext;
                
        }
        [HttpPost("add_employee")]
        public IActionResult AddEmployee([FromBody] EmployeeModel employeeObj)
        {
            if (employeeObj == null)
            {
                return BadRequest();
            }
            else
            {
                _context.EmployeeModels.Add(employeeObj);
                _context.SaveChanges();
                return Ok(new
                {
                    StatusCode=200,
                    Message="User Added !"
                });
            }
        }
        [HttpPut("update_employee")]
        public IActionResult UpdateEmployee([FromBody]EmployeeModel employeeObj)
        {
            if(employeeObj == null)
            {
                return BadRequest();
            }
            var user = _context.EmployeeModels.AsNoTracking().FirstOrDefault(x=> x.Id==employeeObj.Id);
            if (user == null)
            {
                return NotFound(new
                {
                    StatusCode= 500,
                    Message="User not found!"
                });
            }
            else
            {
                _context.Entry(employeeObj).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok(new
                {
                    StatusCode=200,
                    Message="Modified"
                });
            }
        }
        [HttpDelete("delete_employee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var user=_context.EmployeeModels.Find(id);
            if (user == null)
            {
                return NotFound(new
                {
                    StatusCode=500,
                    Message="User Not Found !"
                });
            }
            else
            {
                _context.Remove(user);
                _context.SaveChanges();
                return Ok(new
                {
                    StatusCode=200,
                    Message="User Deleted Successfully!"
                });

            }
        }
        [HttpGet("get_all_employees")]
        public IActionResult GetAllEmployee(int id)
        {
            var employee = _context.EmployeeModels.AsQueryable();
            return Ok(new
            {
                StatusCode = 200,
                EmployeeDetails=employee
            });
        }
        [HttpGet("get_employee/id")]
        public IActionResult GetEmployee(int id)
        {
            var employee = _context.EmployeeModels.Find();
            if(employee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(new
                {                    StatusCode = 200,
                    EmployeeDetails = employee
                });
            }
        }
    }
}
