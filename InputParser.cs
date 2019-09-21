using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_calculator
{
    public class InputParser
    {
        static public List<int> parseStringToList(string input)
        {
            List<int> numbers = new List<int>();
            string[] splitInput = input.Split(',');

            foreach (var item in splitInput)
            {
                int conversion = 0;
                int.TryParse(item, out conversion);
                numbers.Add(conversion);
            }

            return numbers;
        }
    }
}
