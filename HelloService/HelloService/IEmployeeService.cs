using System.Collections.Generic;
using System.ServiceModel;

namespace HelloService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee GetEmployee(EmployeeRequest id);
        [OperationContract]
        Employee GetEmployeeType(EmployeeRequest typeId);
        [OperationContract]
        void SaveEmployee(Employee employee);
        [OperationContract]
        IEnumerable<Employee> GetAllEmployees();
    }
}