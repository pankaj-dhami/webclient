using System.ServiceModel;

namespace HelloService
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Divide(int num, int deno);
    }
}