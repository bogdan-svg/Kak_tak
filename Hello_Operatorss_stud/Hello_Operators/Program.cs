using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");
            
            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            //Key sequence: 3817283 or 3827183
            // Declare 7 int variables for the input numbers and other variables
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please,  type numbers by step ");
            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing

        }
        #endregion

        #region calculator
        static void Calculator()
        {
            // Set Console.ForegroundColor  value
            Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation ");
            long b;
            int x, y, z;
            double i;
            b = long.Parse(Console.ReadLine());
            switch (b)
            {
                case 1:
                    Console.WriteLine("enter x");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter y");
                    y = int.Parse(Console.ReadLine());
                    z = x * y;
                    Console.WriteLine("{0} * {1} = {2}", x, y, z);
                    break;
                case 2:
                    Console.WriteLine("enter x");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter y");
                    y = int.Parse(Console.ReadLine());
                    i = x / y;
                    Console.WriteLine("{0} / {1} = {2:E2}", x, y, i);
                    break;
                case 3:
                    Console.WriteLine("enter x");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter y");
                    y = int.Parse(Console.ReadLine());
                    z = x + y;
                    Console.WriteLine("{0} + {1} = {2}", x, y, z);
                    break;
                case 4:
                    Console.WriteLine("enter x");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter y");
                    y = int.Parse(Console.ReadLine());
                    z = x - y;
                    Console.WriteLine("{0} - {1} = {2}", x, y, z);
                    break;
                case 5:
                    Console.WriteLine("enter x");
                    x = int.Parse(Console.ReadLine());
                    i = Math.Exp(x);
                    Console.WriteLine("e^{0} = {1}", x,i);
                    break;

            }
            // Implement option input (1,2,3,4,5)
            //     and input of  two or one numbers
            //  Perform calculations and output the result 
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            long x;
            Console.WriteLine("enter x");
            x = long.Parse(Console.ReadLine());
            if (x == 0)
            {
                x = 1;
            }
            else
            {
                for (long i = x - 1; i > 0; i--)
                    x = x * i;

            }
            Console.WriteLine("x! = {0}",x);

            
            // Implement input of the number
            // Implement input the for circle to calculate factorial of the number
            // Output the result
        }
        #endregion
    }
}
