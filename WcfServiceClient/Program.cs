using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceClient;
using WcfServiceClient.ServiceReference;

namespace WcfServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient wcf = new CalculatorClient();
            double res = wcf.Subtract(6, 7);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
