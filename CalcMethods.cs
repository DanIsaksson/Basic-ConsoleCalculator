namespace Methods;

// =========== OPERATION METHODS ===========
// ===== DO NOT CHANGE IN REFACTORING ======
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

     public static double Multiplication(double mulNum1, double mulNum2)
     {
          return mulNum1 * mulNum2;
     }

     public static double Division(double divNum1, double divNum2)
     {
          while(divNum2 == 0)
          {
               Console.WriteLine("Error: Either divided by zero or not a number.\nTry again: ");
               double.TryParse(Console.ReadLine(), out divNum2);
          }
          return divNum1 / divNum2;
     }

}


//  ┌─────────────────────────────────────────────────────┐
//  │                   E V A L U A T E                   │
//  │                   ═══════════════                   │
//  │               ! ! !  REFACTOR  ! ! !                │
//  └─────────────────────────────────────────────────────┘
public class CalcEval
{

     double result = 0;
     public static void Evaluate()
     {

          //PICKS METHOD BASED ON OPERATOR PARSED FROM ABOVE
          switch (calcOperator)
          {
               case '+':
                    result=CalcMethods.Add(num1, num2);
                    break;
               case '-':
                    result=CalcMethods.Subtraction(num1, num2);
                    break;
               case '*':
                    result=CalcMethods.Multiplication(num1, num2);
                    break;
               case '/':
                    result=CalcMethods.Division(num1, num2);
                    break;
               default:
                     break;
          }

          Console.WriteLine("\nResult: " + result + "\n");

     }
}

