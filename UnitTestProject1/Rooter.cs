using System;

namespace UnitTestProject1
{
    class Rooter
    {
        public Rooter()
        {
        }

        //public double SquareRoot(double input)
        //{
        //    return input / 2;
        //}

        public double SquareRoot(double input)
        {
            if (input <= 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }

            double result = input;
            double previousResult = -input;
            while (Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                //result = result - (result * result - input) / (2 * result);
                result = (result + input / result) / 2;
            }
            return result;
        }
    }
}