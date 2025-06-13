
namespace MathInterpreter
{
    public class Program
    {
        public static void Main()
        {
            bool isRunning = true;
            while (isRunning)

            {
                DisplayMenu menu = new DisplayMenu();
                menu.ShowMenu();

                Operation calculator = new Operation();
                calculator.Calculation();

                Console.WriteLine("\nDo you want to exit the application? (y/n)\n");
                string exit = Console.ReadLine();

                if (exit == "y")
                {
                    isRunning = false;
                }

                else if (exit == "n")
                {
                    isRunning = true;
                }

                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }
            }
        }
    }
}