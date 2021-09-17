using System;

namespace BankingLibrary
{
    public class CalcInterest : ICalcInterest
    {
        public int Calculate(int principle, int rate, int years)
        {
            int interest = (principle * rate * years) / 100;
            return interest;
        }
    }
}
