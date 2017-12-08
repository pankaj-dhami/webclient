using System.Collections.Generic;
using System.ServiceModel;

namespace HelloService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee GetEmployee(int id);
        [OperationContract]
        void SaveEmployee(Employee employee);
        [OperationContract]
        IEnumerable<Employee> GetAllEmployees();
    }
}