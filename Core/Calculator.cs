using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApplication.Core
{
    internal static class Calculator
    {
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static decimal Substract(decimal x, decimal y) 
        {
            return x - y;
        }

        public static decimal Divide(decimal x, decimal y) 
        {
            return x / y;
        }

        public static decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }
    }
}
