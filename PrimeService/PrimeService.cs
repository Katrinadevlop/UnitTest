using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int numberOne, int numberTwo)
        {
            if (numberOne % numberTwo == 0)
            {
                return true;
            }
            throw new NotImplementedException("Please create a test first.");
        }
    }
}