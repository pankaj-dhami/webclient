using RedisStorage;
using System.Collections.Generic;

namespace HelloService
{
    public class EmployeeService : IEmployeeService
    {
        CacheAdapter cacheAdapter;
        public EmployeeService()
        {
            cacheAdapter = new CacheAdapter();
        }

        IList<Employee> _employees = new List<Employee>();
        public Employee GetEmployee(EmployeeRequest id)
        {
            return cacheAdapter.Get<Employee>(id.ToString());
        }
        public void SaveEmployee(Employee employee)
        {
            cacheAdapter.Add(employee.Id.ToString(), employee);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return cacheAdapter.GetAll<Employee>();
        }

        public Employee GetEmployeeType(EmployeeRequest request)
        {
            if (request.TypeId == 1)
            {
                return new FullTimeEmployee { Id = 1, AnnualSalary = 1000 };
            }
            else
            {
                return new PartTimeEmployee { Id = 2, HourlyPay = 10 };
            }
            return null;
        }
    }
}
