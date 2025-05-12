﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Basics
{
    public delegate T OperationDelegate<T>(T number1, T number2);

    class Program
    {
        static void Main(string[] args)
        {
            OperationDelegate<double> action = Substraction;

            var result = action(5.0, 8.0);

            Console.WriteLine(result);

            OperationHandler<double>(5.2, 4.8, Addition);

        }

        private static void OperationHandler<T>(T n1, T n2, OperationDelegate<T> operation)
        {
            operation(n1, n2);
        }

        private static double Substraction(double value1, double value2)
        {
            return value1 - value2;
        }

        private static double Addition(double value1, double value2)
        {
            return value1 + value2;
        }
    }
}
