using System;
using System.Collections.Generic;

namespace inverseChiSquareDistribution
{
    [Serializable]
    public class TestResult
    {
        public TestResult()
        {
            A = 0;
            B = 0;
            NIter = 0;
            Left = 0;
            Right = 0;
            Step = 0;
            Analit = new List<double>();
            Neymon = new List<double>();
            Metropolis = new List<double>();
            Inverse = new List<double>();

            Mean = new List<double>();
            Dispers = new List<double>();
            Sigma = new List<double>();
        }

        public TestResult(double A, double B, double nIter, double left, double right, double step, List<double> analit,
            List<double> neymon, List<double> metropolis, List<double> inverse)
        {
            this.A = A;
            this.B = B;
            this.NIter = nIter;
            Left = left;
            Right = right;
            Step = step;

            Analit = new List<double>(analit);
            Neymon = new List<double>(neymon);
            Metropolis = new List<double>(metropolis);
            Inverse = new List<double>(inverse);

            Mean = new List<double>();
            Dispers = new List<double>();
            Sigma = new List<double>();
        }

        public double A { get; set; }
        public double B { get; set; }
        public double NIter { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }
        public double Step { get; set; }
        public List<double> Analit { get; set; }
        public List<double> Neymon { get; set; }
        public List<double> Metropolis { get; set; }
        public List<double> Inverse { get; set; }
        public List<double> Mean { get; set; }
        public List<double> Dispers { get; set; }
        public List<double> Sigma { get; set; }

        public void AnswerResults(double mean, double dispers, double sigma)
        {
            Mean.Add(mean);
            Dispers.Add(dispers);
            Sigma.Add(sigma);
        }
    }
}