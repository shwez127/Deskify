using OfficeDeskDAL.Data;
using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskDAL.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        DeskDbContext _db;
        public EmployeeRepository(DeskDbContext db)
        {
            _db = db;
        }

        public void AddEmployee(Employee employee)
        {
            _db.Add(employee);
            _db.SaveChanges();
        }

        public void DeleteEmployee(int employeeId)
        {
            _db.Remove(employeeId);
            _db.SaveChanges();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _db.employees.ToList();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _db.employees.Find(employeeId);
        }

       

        public void UpdateEmployee(Employee employee)
        {
            _db.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
