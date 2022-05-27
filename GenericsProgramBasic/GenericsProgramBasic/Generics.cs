using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgramBasic
{
    public class Generics<T> where T : IComparable
    {
       public int MaximumOfIntegers(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if(b > a && b > c)
            { 
                return b;
            }
            else
            {
                return c;
            }
        }     
        
    }
}
