# First Prototyping Stage
1. create method for add and subtraction
    ## DONE - create method for add
    ## DONE - create method for subtraction
2. Create input double variables for numbers and connect to methods.
3. Test if this works.

# Second Prototyping Stage
1. Create while-loop for calculator.
2. Create for (int i = 0; i < 2; i++) loop for inputting numbers and operator.
     - if i==0: 
         - Console.WriteLine("Enter first number:");
         - number1 = double.Parse(Console.ReadLine());
     - if i==1: 
         - Console.WriteLine("Enter operator:");
         - operator = char.Parse(Console.ReadLine());
     - if i==2:
          - Console.WriteLine("Enter second number:");
          - number2 = double.Parse(Console.ReadLine());
3. Create switch statement with char-variable check for method choice and string variable assignment.
4. Create evaluation method using string variable to decide if using +, -, * or /.
4. Test if this works.

# Third Prototyping Stage
1. Add methods for Division and Multiplication.
 - Add exception for 0 on Division.
2. Edit evaluation method.
3. Test if this works.

# Fourth Prototyping Stage
1. Test making more robust (avoid errors on typos etc.).
    - Add while-loop for re-input if error.




ASSIGNMENT 
Calculator 
1. Purpose 
Your assignment is to create a basic Console-based calculator using C#. It 
should be able to handle basic mathematical operations (addition, 
subtraction, multiplication, division), and be able to present the results in a 
consistent way. 

2. Required Features 
• The program should be able to perform basic mathematical operations 
on the numeric values entered by the user (Math has methods for more 
advanced operations if you include them). 
- Addition, Subtraction, Division, Multiplication, etc.. 
• The program should keep running until the user chooses to end it. 
3. Code Requirements 
• Each mathematical operation should be in its own method. 
• Division should inform the user if they try to divide by zero. 
• Use a loop and a menu system to keep the program running. 
4. Deadline 
Finish the assignment by Friday August 8. Push your code to a GitHub 
repository and share your repository URL with your instructor before 15:00.


