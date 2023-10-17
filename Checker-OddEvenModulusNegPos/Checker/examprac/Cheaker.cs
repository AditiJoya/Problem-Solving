using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace examprac
{
    public class Cheaker
    {
        public string oddeven(int num)
        {
            if (num % 2 == 0)
            {
                return "even";
            }
            else
                return "odd";
        }
        public string zeronegpositive(int num1)
        {
            if (num1 == 0)
            {
                return "its zero";
            }
            else if (num1 < 1)
            {
                return "its negative";
            }
            else
            {
                return "positive";
            }
        }
        public string greaters(int fst , int snd, int thrd)
        {
            if(fst >snd)
            {
                if (fst > thrd)
                {
                    return fst + " is greater than" + snd + thrd;
                }
                else
                    return thrd + "is greater";
            }
            else
            {
                if (snd > thrd)
                {

                    return snd + "is greater";
                }

                else
                {
                    return thrd + "is grater";
                }
            }
        }

        public string lowerupper(char chars)
        {
            if(chars >= 'A' && chars <= 'Z')
            {
                return "upper";
            }
            else if(chars >= 'a' && chars <= 'z')
            {
                return "lower";

            }
            else
            {
                return "envalid entry";
            }

            

        }
        public string PrimeOrNot(int number)
        {
            bool IsPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                return "Prime";
            }
            else
            {
                return "Not Prime";
            }
        }
        

    }
}
