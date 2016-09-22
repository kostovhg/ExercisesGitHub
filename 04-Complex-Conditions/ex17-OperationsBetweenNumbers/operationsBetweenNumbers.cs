using System;


class operationsBetweenNumbers
{
    static void Main(string[] args)
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        string operand = Console.ReadLine();
        double result = 0.0;

        switch (operand)
        {
            case "+":
                result = number1 + number2;
                Console.WriteLine(
                    "{0} {1} {2} = {3} - {4}",
                    number1, operand, number2, result,
                    (result % 2 == 0) ? "even" : "odd");
                break;
            case "-":
                result = number1 - number2;
                Console.WriteLine(
                    "{0} {1} {2} = {3} - {4}",
                    number1, operand, number2, result,
                    (result % 2 == 0) ? "even" : "odd");
                break;
            case "*":
                result = number1 * number2;
                Console.WriteLine(
                    "{0} {1} {2} = {3} - {4}",
                    number1, operand, number2, result,
                    (result % 2 == 0) ? "even" : "odd");
                break;
            case "/":
                if (number2 == 0) Console.WriteLine($"Cannot divide {number2} by zero");
                else
                {
                    result = (double)number1 / number2;
                    Console.WriteLine(
                        "{0} {1} {2} = {3:F2} ",
                        number1, operand, number2, result
                         );
                }
                break;

            case "%":

                if (number2 == 0) Console.WriteLine($"Cannot divide {number2} by zero");
                else
                {
                    result = number1 % number2;
                    Console.WriteLine(
                        "{0} {1} {2} = {3} ",
                        number1, operand, number2, result
                         );
                }
                break;
            default:
                break;
        }

    }
}

