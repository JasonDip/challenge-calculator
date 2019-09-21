using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    1. Support a maximum of 2 numbers using a comma delimiter
        examples: 20 will return 20; 1,5000 will return 5001
        invalid/missing numbers should be converted to 0 e.g. "" will return 0; 5,tytyt will return 5
    2. Support an unlimited number of numbers e.g. 1,2,3,4,5,6,7,8,9,10,11,12 will return 78
 */

namespace challenge_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a formatted string of numbers to add.");
            Console.WriteLine(" * Comma delimited.");
            Console.Write("> ");
            string input = Console.ReadLine();

            List<int> numbers = InputParser.parseStringToList(input);
            Console.WriteLine(Calculator.Add(numbers));
        }
    }
}
