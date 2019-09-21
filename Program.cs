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
    7. Support 1 custom delimiter of any length
        use the format: //[{delimiter}]\n{numbers} e.g. //[***]\n11***22***33 will return 66
        all previous formats should also be supported
    8. Support multiple delimiters of any length
        use the format: //[{delimiter1}][{delimiter2}]...\n{numbers} e.g. //[*][!!][r9r]\n11r9r22*33!!44 will return 110
        all previous formats should also be supported

    Stretch Goals:
    1. Display the formula used to calculate the result e.g. 2,4,rrrr,1001,6 will return 2+4+0+0+6 = 12
    2. Allow the application to process entered entries until Ctrl+C is used
    3. Allow the acceptance of arguments to define...
        alternate delimiter in step #3
        toggle whether to deny negative numbers in step #4
        upper bound in step #5
 */

namespace challenge_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Supported command line arguments:");
            Console.WriteLine(" * Set a delimiter: -d \";\"");
            Console.WriteLine(" * Allow negative numbers: -n");
            Console.WriteLine(" * Set number upper limit: -u \"2000\"\r\n");
            CheckArgs(args);

            Console.WriteLine("Enter a formatted string of numbers to add.");
            Console.WriteLine(" * Comma or new-line delimited.");
            Console.WriteLine(" * To use multiple custom delimiters, use format: //[{delimiter1}][{delimiter2}]...\\n{numbers}.");
            Console.WriteLine(" * Continuously calculating entries. Exit using Ctrl+C.");

            double runningTotal = 0;
            int loopCount = 0;
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                List<double> numbers = InputParser.ParseStringToList(input);

                // add previous loop's answer - comment this part out to stop prefixing previous answer
                if (loopCount > 0)
                {
                    numbers.Insert(0, runningTotal);
                }
                loopCount++;

                // calculate this loop's answer
                runningTotal = Calculator.Add(numbers);
                Console.WriteLine(Calculator.GetFormula(numbers) + " = " + runningTotal);
            }
        }

        static void CheckArgs(string[] args)
        {
            for (int x = 0; x < args.Length; x++)
            {
                switch (args[x])
                {
                    case "-d":
                        InputParser.defaultDelimiters = new string[] { ",", args[++x] };
                        break;
                    case "-n":
                        Calculator.allowNegativeNumbers = true;
                        break;
                    case "-u":
                        Calculator.upperBound = Convert.ToDouble(args[++x]);
                        break;
                }
            }
        }
    }
}
