using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5thclassCalculator
{
    public interface Icalculator
    {
        public double Add(double n1, double n2);
        public double subs(double n1, double n2);
        public double Multi(double n1, double n2);
        public double Div(double n1, double n2);
    }
}
