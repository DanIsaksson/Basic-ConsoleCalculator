namespace Calculator;

using Methods;

// ==== TO USE ====
//• C# and .NET
// • data types – string, int, bool
// • variables
// • operators
// • for loops
// • scope
// • methods
//  parsing


public class Program
{
    public static void Main(string[] args)
    {
          bool calcIsRunning = true;
          while(calcIsRunning)
          {
               Console.Clear(); // Clear console on each loop iteration
               double number1=0;
               double number2=0;
               char calcOperator=' ';

               bool evalIsValid = false;
               while(!evalIsValid)
               {
                    Console.WriteLine("First enter your number.");                  
                    CalcEval.Evaluate(number1, number2, calcOperator);
                    evalIsValid = true;
               }

               Console.WriteLine("Press Q to quit or any other key to clear the memory \nand do another calculation.");
               var decision = Console.ReadKey();
               if(decision.Key == ConsoleKey.Q || decision.Key == ConsoleKey.q)
               {
                    calcIsRunning = false;
               }
              
          }
    }
}
