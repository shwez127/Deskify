using Microsoft.EntityFrameworkCore.Query.Internal;
using OfficeDeskDAL.Repository;
using OfficeDeskEntity.Models;

namespace OfficeDeskBLL.Services
{
    public class EmployeeService
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void AddEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }
        public void DeleteEmployee(int employeeId)
        {
            _employeeRepository.DeleteEmployee(employeeId);
        }
        public IEnumerable<Employee> GetAllEmployees() 
        { 
            return _employeeRepository.GetAllEmployees();
        }
        public Employee GetEmployeeById(int employeeId)
        {
            return _employeeRepository.GetEmployeeById(employeeId);
        }
        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }
    }
}