using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_calculator
{
    public class Calculator
    {
        public static bool bAllowNegativeNumbers = false;

        static public int Add(List<int> numbers)
        {
            int answer = 0;
            //List<int> negativeNumbers = new List<int>();
            string negativeNumbers = "";

            foreach (var number in numbers)
            {
                if (( ! bAllowNegativeNumbers) && number < 0)
                {
                    //negativeNumbers.Add(number);
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
