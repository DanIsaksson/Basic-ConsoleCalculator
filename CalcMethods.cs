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
               if(!double.TryParse(Console.ReadLine(), out num1))
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
          while(!isOperatorValid)
          {
               calcOperator = Console.ReadKey().KeyChar;
               
               if(calcOperator == '+' || calcOperator == '-')
               {
                    isOperatorValid = true;
               }
               else
               {
                    Console.WriteLine("\nInvalid operator. Please enter + or -");
               }
          }

          bool enterNum2 =  true;
          // ENTER NUMBER INPUT 2
          while(enterNum2)      
          {
               if(!double.TryParse(Console.ReadLine(), out num2))
               {
                    Console.WriteLine("Invalid number. Please enter a number.");
               }
               else
               {
                    enterNum2=false;
               }
          }

          //PICKS METHOD BASED ON OPERATOR PARSED FROM ABOVE
          switch (calcOperator)
          {
               case '+':
                    result=CalcMethods.Add(num1, num2);
                    break;
               case '-':
                    result=CalcMethods.Subtraction(num1, num2);
                    break;
               default:
                     break;
          }

          Console.WriteLine("\nResult: " + result + "\n");

     }
}

