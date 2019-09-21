using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_calculator
{
    public class InputParser
    {
        static public List<double> ParseStringToList(string input)
        {
            // extract delimiter-header from the input string
            string[] defaultDelimiters = { ",", "\\n", "\n" }; // did both '\n' (0xA) and "\n" as intructions were ambiguous
            string[] customDelimiters = FindDelimiters(ref input);
            List<string> addedList = new List<string>(defaultDelimiters.Concat<string>(customDelimiters));
            string[] delimiters = addedList.ToArray();

            // split the input string into an array
            string[] splitInput = input.Split(delimiters, StringSplitOptions.None);

            // create and return a list of numbers to be used for the calculation
            List<double> numbers = new List<double>();
            foreach (var item in splitInput)
            {
                double.TryParse(item, out double conversion);
                numbers.Add(conversion);
            }
            return numbers;
        }

        static public string[] FindDelimiters(ref string input)
        {
            // extract the delimiter-header that can potentially be at the beginning of the string //...\n
            Regex rx = new Regex(@"^//.*\\n");
            Match delimiterHeader = rx.Match(input);

            if ( ! delimiterHeader.Success)
            {
                return new string[] { "" };
            }

            // remove the delimiter portion from the input string
            input = input.Substring(delimiterHeader.Length);

            // check for a delimiter of custom length
            rx = new Regex(@"(?<=\[)(.+?)(?=\])");
            MatchCollection delimiter = rx.Matches(delimiterHeader.ToString());

            // if nothing was found, use all the contents of the header as the delimiter
            if (delimiter.Count == 0)
            {
                // extract the delimiter character from the delimiter-header
                rx = new Regex(@"(?<=//)(.+?)(?=\\n)");
                delimiter = rx.Matches(delimiterHeader.ToString());
            }
            
            return (from Match m in delimiter select m.Value).ToArray();
        }
    }
}
