using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer
{
    public class customException : Exception
    {
        public customException(string s) : base(s)
        { 
            
        }
    }
    public class blClass
    {
        public int  Divide(string numer, string denom)
        {
            int r = 0, r1 = 0;
            bool n = int.TryParse(numer.ToString(),out r);
            bool n1 = int.TryParse(denom.ToString(),out r1);
            if (n && n1)
            {
                if (int.Parse(denom )!= 0)
                    return int.Parse(numer) / int.Parse(denom);
                else
                    throw new DivideByZeroException("cannot divide by zero");
            }
            else
                throw new FormatException("only numbers");
        }
        public int calculate(DateTime age)
        {
            DateTime now = DateTime.Now;
            int currage = (int)now.Subtract(age).TotalDays / 365;
            if (currage > 60)
                throw new customException("maximum age is 60");
            else if (currage < 18)
                throw new customException("minimum age is 18");
            else
                return currage;
        }
    }
}
