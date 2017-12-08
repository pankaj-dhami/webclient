using System.Collections.Generic;
using System.Linq;

namespace HelloService
{
    public class EmployeeService : IEmployeeService
    {
        IList<Employee> _employees = new List<Employee>();
        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(a => a.Id == id);
        }
        public void SaveEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}
