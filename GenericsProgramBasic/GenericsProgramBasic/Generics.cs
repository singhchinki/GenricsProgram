﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgramBasic
{
    public class Generics<T> where T : IComparable
    {
        public T[] value;
        public Generics(T[] value)
        {
            this.value = value;
        }
        public static T[] sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public static T findMaximum(params T[] value)
        {
            var sorted_values = sort(value);
            return sorted_values[value.Length - 1];
        }
        public T showMax()
        {
            var Result = Generics<T>.findMaximum(this.value);
            return Result;
        }
    }
}



