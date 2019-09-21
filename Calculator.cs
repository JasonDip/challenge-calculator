using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_calculator
{
    public class Calculator
    {
        static public int Add(List<int> numbers)
        {
            int answer = 0;
            foreach (var number in numbers)
            {
                answer += number;
            }
            return answer;
        }
    }
}
