using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreTutorialApp.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Department = Dept.HR, Name = "Marius", Email = "marius@gmail.com"},
                new Employee() {Id = 2, Department = Dept.IT, Name = "John", Email = "john@yahoo.com"},
                new Employee() {Id = 3, Department = Dept.IT, Name = "Marta", Email = "marta@yahoo.com"}
            };
        }

        public Employee Add(Employee newEmployee)
        {
            newEmployee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(newEmployee);

            return newEmployee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(employee => employee.Id == Id);
        }
    }
}
