using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5thclassCalculator
{
    public class Calculator : Icalculator
    {
        public double Add(double n1,double n2)
        {
            return n1 + n2;
        }
        public double Subs(double n1,double n2)
        {
            return n1 - n2;
        }
        public double Multi(double n1,double n2)
        { return n1 * n2;
        }
        public double Div(double n1,double n2)
        { 
            return n1 / n2; 
        }

        public double subs(double n1, double n2)
        {
            throw new NotImplementedException();
        }

        public double MyValue(double n1, double n2, string opt)
        {
            double result = 0;
            if (opt == "+")
            {
                result = n1 + n2;
            }
            else if (opt == "-")
            {
                result = n1 - n2;
            }
            else if (opt == "*")
            {
                result = n1 * n2;
            }
            else if (opt == "/")
            {
                result = n1 / n2;
            }

            return result;
        }

        public string concetantion(string s1, string s2)
        { return s1 +  "-" + s2;
        }
    }
    

}
