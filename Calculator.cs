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
        public static double upperBound = 1000;

        static private bool IsGreaterThanUpperBound(double number)
        {
            return (number > upperBound);
        }

        static private bool IsNegativeAndDenyingNegatives(double number)
        {
            return ((!allowNegativeNumbers) && number < 0);
        }

        static public double Add(List<double> numbers)
        {
            double answer = 0;
            string negativeNumbers = "";

            foreach (var number in numbers)
            {
                if (IsGreaterThanUpperBound(number))
                {

                }
                else if (IsNegativeAndDenyingNegatives(number))
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

        static public string GetFormula(List<double> numbers)
        {
            string formula = "";
            string operation = "+";
            foreach (var number in numbers)
            {
                if (IsGreaterThanUpperBound(number))
                {
                    formula += "0" + operation;
                }
                else if (IsNegativeAndDenyingNegatives(number))
                {
                    formula += "0" + operation;
                }
                else
                {
                    formula += number + operation;
                }
            }
            return formula.Remove(formula.Length - 1);
        }
    }
}
