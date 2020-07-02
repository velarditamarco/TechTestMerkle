using System;
using System.Collections.Generic;
using System.Text;

namespace TechTestMerkle
{
    public static class SavingAccountBalance
    {
        public static decimal Balance(int openingSum, int interestRate, int taxFreeLimit, int taxRate, int numMonths)
        {
            decimal newBalance = openingSum;

            for (int i = 0; i < numMonths; i++)
            {
                decimal monthlyInterest = (newBalance * interestRate) / 100;

                decimal monthlyTaxRate = newBalance > taxFreeLimit ? (taxRate * (newBalance - taxFreeLimit) / 100) : 0;

                newBalance += monthlyInterest - monthlyTaxRate;
            }

            return newBalance;
        }

    }
}
