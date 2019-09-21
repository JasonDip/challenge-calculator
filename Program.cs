using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Requirements:
    1. Support a maximum of 2 numbers using a comma delimiter
        examples: 20 will return 20; 1,5000 will return 5001
        invalid/missing numbers should be converted to 0 e.g. "" will return 0; 5,tytyt will return 5
    2. Support an unlimited number of numbers e.g. 1,2,3,4,5,6,7,8,9,10,11,12 will return 78
    3. Support a newline character as an alternative delimiter e.g. 1\n2,3 will return 6
    4. Deny negative numbers. An exception should be thrown that includes all of the negative numbers provided
    5. Ignore any number greater than 1000 e.g. 2,1001,6 will return 8
    6. Support 1 custom single character length delimiter
        use the format: //{delimiter}\n{numbers} e.g. //;\n2;5 will return 7
        all previous formats should also be supported
 */

namespace challenge_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a formatted string of numbers to add.");
            Console.WriteLine(" * Comma or new-line delimited.");
            Console.WriteLine(" * To use a custom delimiter, use this format: //{delimiter}\\n{numbers}.");
            Console.Write("> ");
            string input = Console.ReadLine();

            List<double> numbers = InputParser.ParseStringToList(input);
            Console.WriteLine(Calculator.Add(numbers));
        }
    }
}
