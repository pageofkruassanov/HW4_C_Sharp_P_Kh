using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HW4_C_Sharp_P_Kh
{
    static internal class Calc
    {
        public static double GetResult(string expression)
        {
            string[] tokens = expression.Split(' ');

            double result = 0;
            double currentOperand = 0;
            string currentOperator = "+";

            foreach (string token in tokens)
            {
                if (token == "+" || token == "-")
                {
                    currentOperator = token;
                }
                else
                {
                    if (double.TryParse(token, out currentOperand))
                    {
                        if (currentOperator == "+")
                        {
                            result += currentOperand;
                        }
                        else if (currentOperator == "-")
                        {
                            result -= currentOperand;
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Неправильний формат виразу.");
                    }
                }
            }

            return result;
        }
    }
}
