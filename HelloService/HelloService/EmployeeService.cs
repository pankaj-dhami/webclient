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
        public Employee GetEmployee(int id)
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
    }
}
