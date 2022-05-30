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
        
        public int GivenMaxSecondPosition_CheckMaxNum_ReturnMax( int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public int GivenMaxThirdPosition_CheckMaxNum_ReturnMax(int a, int b, int c)
        {
                if (a > b && a > c)
                {
                    return a;
                }
                else if (b > a && b > c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
        }
        public double FindMaximumFirstFloatNumber( double a, double b, double c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public double FindMaximumSecondFloatNumber(double a, double b, double c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public double FindMaximumThirdFloatNumber(double a, double b, double c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public string findMaximumString(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }
            else
                return third;
        }
        public T findMaximum<T>(T first, T second, T third) where T : IComparable
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }
            else
                return third;
        }
    }


}
