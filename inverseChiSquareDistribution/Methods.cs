using System;
using System.Collections.Generic;
using System.Linq;

namespace inverseChiSquareDistribution
{
    internal static class Methods
    {
        private static readonly Random Random = new Random();

        
        public static double MethodNeyman(double a, double b, double qMax, double left, double right, double gamma)
        {
            var result = (double)0;
            var yN = (double)0;
            do
            {
                result = left + (right - left) * Random.NextDouble(); 
                yN = qMax * Random.NextDouble(); 
            } while (Function(a, b, result, gamma) < yN); 

            return result; 
        }
        
        public static double Metropolis(double a, double b, double left, double right, double xM, double delta,
            double gamma)
        {
            var xNext = (double)0; 
            var pI = (double)0;
            var result = (double)0;

            xNext = left + delta * (2 * Random.NextDouble() - 1); 
            pI = Function(a, b, xNext, gamma) /
                 Function(a, b, xM, gamma); 

            if (pI > 1) 
                result = xNext; 

            if (Random.NextDouble() < pI) 
                result = xNext; 

            return result; 
        }
        
        public static double Dispersion(List<double> myList, double summ)
        {
            var result = (double)0;
            var sqSum = (double)0;
            sqSum = myList.Sum(i => i * i);
            result = Math.Sqrt(1.0 / (myList.Count - 1) * (sqSum - myList.Count * Math.Pow(summ, 2)));

            return result;
        }

        public static double Mean(List<double> myList)
        {
            var result = myList.Sum() / myList.Count;
            return result;
        }

        public static double Inverse(double a, double b)
        {
            var x = Random.NextDouble();
            var result = InverseCDF(a, b, x);
            return result;
        }
        
        private static double InverseCDF(double a, double b, double x)
        {
            var temp = Math.Pow((1 - Math.Pow(1 - x, 1 / b)), 1 / a);
            return temp;
        }
        
        public static double Function(double a, double b, double x, double gamma)
        {
            var result = (double)0;
            
            if (x == 0 && a < 1 && b < 1)
            {
                result = (1 / gamma) * 1 * Math.Pow(1 - x, b - 1);
                return result;
            }

            result = (1 / gamma) * Math.Pow(x, a - 1) * Math.Pow(1 - x, b - 1);
            return result;
        }
    }
}