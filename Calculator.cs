using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_calculator
{
    public class Calculator
    {
        public static bool allowNegativeNumbers = false;
        public static int upperBound = 1000;

        static public int Add(List<int> numbers)
        {
            int answer = 0;
            string negativeNumbers = "";

            foreach (var number in numbers)
            {
                if (number > upperBound)
                {

                }
                else if (( ! allowNegativeNumbers) && number < 0)
                {
                    negativeNumbers += number.ToString() + " ";
                }
                else
                {
                    answer += number;
                }
            }

            if (negativeNumbers.Length > 0)
            {
                throw new Exception("Negative numbers not allowed: " + negativeNumbers);
            }

            return answer;
        }
    }
}
