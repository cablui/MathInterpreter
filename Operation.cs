
using System.Data;

namespace MathInterpreter
{
    internal class Operation
    {
        public void Calculation()
        {
            string operation = Console.ReadLine();

            try
            {
                var result = new DataTable().Compute(operation.ToString(), null);
                Console.WriteLine(result);
            }

            catch (Exception)
            {
                Console.WriteLine("Error: this is not a valid operation");
            }
        }
    }
}
