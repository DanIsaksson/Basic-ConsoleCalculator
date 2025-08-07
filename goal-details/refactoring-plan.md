# REFACTORING PLAN

## ARRAY[200] FOR INPUT PARSING & INPUT WHOLE CALCULATION IN ONE READLINE

## CORE LOGIC UNDERSTANDING
1. Learn a bit about how you can extrapolate data from a string.
    - Use Select() method for parsing every c to array of strings.
        ### EXEMPEL ###
        string userInput = Console.ReadLine();
        string[] symbols = userInput.Select(c => c.ToString()).ToArray();

2. Learn about about how to process the parsed string array. It should be able to distinguish the parts to split into the first value (Val1), an operator (procOp) and the second value (Val2).
    - Check if Regex.IsMatch Method is valid.
    - Use Regex.Match Method to match the string against the pattern.
    - Use Regex.Replace Method to replace the matched string with the operator.
    - Use Regex.Split Method to split the string into an array of strings.
        ### EXEMPEL ###
        #### AI SAMPLE: 
        if (!Regex.IsMatch(input, "^\s*\d+(\.\d+)?\s*[+\-*/]\s*\d+(\.\d+)?\s*$"))
        {
            Console.WriteLine("Input must be: number  operator  number");
            return;
        }
        ###
        ### MY FIRST TEST AND SUGGESTION FOR THIS PROGRAM
        if (!Regex.IsMatch(result, "^ \s* \d+ (\.\d+)? \s* [\-+*/] \s* \d+ (\.\d+)? ,  RegexOptions.IgnorePatternWhitespace))

        string input = Console.ReadLine();
        // Remove any whitespace around the input
        input = input.Trim();
        // Replace any whitespace between numbers and operators with a single space
        input = 



2. For-loop
    - Run for the array.
    - Perhaps some kind of condition logic for "before" and "after" 
    the OPERATOR ( + - * / )




## AI SUGGESTION
using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your expression (e.g., 13.12+3):");
        string userInput = Console.ReadLine();
        string[] symbols = userInput.Select(c => c.ToString()).ToArray();

        Console.WriteLine("Symbols:");
        foreach (string symbol in symbols)
        {
            Console.WriteLine(symbol);
        }

        // Here you can add code to process, evaluate, or calculate with the symbols array
    }
}
