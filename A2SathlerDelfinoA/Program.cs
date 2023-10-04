using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SathlerDelfinoA {
    
    class Program {
        //Method Overload: Join two chars together separated by a space
        static string ManipulateTwoVariables(char a, char b) {
            return ($"{a} {b}");
        }

        //Method Overload: Divide a number by a second number
        static double ManipulateTwoVariables(double a, double b) {
            return (a / b);
        }

        //Method Overload: Concatenate two string values
        static string ManipulateTwoVariables(string a, string b) {
            return (a + b);
        }

        //Method: Add any four numbers together
        static double SumNumbers(double a, double b, double c, double d) {
            return (a + b + c + d);
        }

        static void Main() {
            double number1, number2, number3, number4;
            string string1, string2;
            char char1, char2;

            //Numbers
            Console.Write("Enter number 1: ");
            number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            number2 = double.Parse(Console.ReadLine());

            Console.Write("Enter number 3: ");
            number3 = double.Parse(Console.ReadLine());

            Console.Write("Enter number 4: ");
            number4 = double.Parse(Console.ReadLine());

            //Strings
            Console.Write("Enter string 1: ");
            string1 = Console.ReadLine();

            Console.Write("Enter string 2: ");
            string2 = Console.ReadLine();

            //Chars
            Console.Write("Enter char 1: ");
            char1 = Console.ReadLine()[0];

            Console.Write("Enter char 2: ");
            char2 = Console.ReadLine()[0];

            //Calling the different methods
            Console.WriteLine(SumNumbers(number1, number2, number3, number4));
            Console.WriteLine(ManipulateTwoVariables(string1, string2));
            Console.WriteLine(ManipulateTwoVariables(number1, number2));
            Console.WriteLine(ManipulateTwoVariables(char1, char2));
        }
    }
}
