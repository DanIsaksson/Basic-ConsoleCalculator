namespace Methods;

// =========== METHODS ===========
public static class CalcMethods
{
    public static double Add(double addNum1, double addNum2)
    {
        return addNum1 + addNum2;
    }

     public static double Subtraction(double subNum1, double subNum2)
     {
          return subNum1 - subNum2;
     }
}


// =========== EVALUATE ============
public class CalcEval
{
    public static void Evaluate(double num1, double num2, char calcOperator)
    {
          double result=0;

          bool enterNum1 =  true;
          // ENTER NUMBER INPUT 1
          while(enterNum1)      
          {
               if(double.TryParse(Console.ReadLine(), out num1))
               {
                    Console.WriteLine("Invalid number. Please enter a number.");
               }
               else
               {
                    enterNum1=false;
               }
          }


          bool isOperatorValid = false;
          // ENSURE PROPER OPERATOR IS ENTERED
          while(isOperatorValid)
          {
               Console.WriteLine("\n+ or -: ");
               calcOperator = Console.ReadLine();
               
               if(calcOperator == '+' || calcOperator == '-')
               {
                    isOperatorValid = true;
               }
               else
               {
                    Console.WriteLine("Invalid operator. Please enter + or -");
               }
          }

          bool enterNum2 =  true;
          // ENTER NUMBER INPUT 2
          while(enterNum2)      
          {
               if(double.TryParse(Console.ReadLine(), out num2))
               {
                    Console.WriteLine("Invalid number. Please enter a number.");
               }
               else
               {
                    enterNum2=false;
               }
          }

          switch (calcOperator)
          {
               case '+':
                    return result=CalcMethods.Add(num1, num2);
               case '-':
                    return result=CalcMethods.Subtraction(num1, num2);
               default:
                    return 0;
          }
          Console.WriteLine("Result:" + result);
     }
}

