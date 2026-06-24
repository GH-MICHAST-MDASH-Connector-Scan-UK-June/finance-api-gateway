using System;

namespace finance_api_gateway
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("finance-api-gateway - Console Application");
            ProcessData();
        }

        static void ProcessData()
        {
            // Sample processing logic
            string input = Console.ReadLine();
            if (input != null)
            {
                Console.WriteLine(input.ToUpper());
            }
        }
    }
}
