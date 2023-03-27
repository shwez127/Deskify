using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeDeskBLL.Services;
using OfficeDeskEntity.Models;

namespace OfficeDeskBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeService _employeeService;
        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.AddEmployee(employee);
            return Ok("Employee Added Successfully");
        }

        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee(Employee employee) 
        {
            _employeeService.UpdateEmployee(employee);
            return Ok("Employee details updated Successfully");
        }
        [HttpDelete("DeleteEmployee")]
        public IActionResult DeleteEmployee(int employeeid)
        {
            _employeeService.DeleteEmployee(employeeid);
            return Ok("Employee Deleted Successfully");
        }
        [HttpGet("GetAllEmployees")]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeService.GetAllEmployees();
        }
        [HttpGet("GetEmployeeById")]
        public Employee GetEmployee(int employeeid)
        {
            return _employeeService.GetEmployeeById(employeeid);
        }
    }
}
