using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloService
{
    [GlobalErrorHandlerBehaviour(typeof(GlobalErrorHandler))]
    public class CalculatorService : ICalculatorService
    {
        public int Divide(int num, int deno)
        {
            return num / deno;
        }
    }
}
