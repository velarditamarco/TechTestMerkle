using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TechTestMerkle
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1
            Time time = new Time(1, 30, 20);
            Console.WriteLine(time.TimeString());

            time.Scale(400);
            Console.WriteLine(time.TimeString());


            // Excercise 2
            string sequence = "AdghhhaaamhmxaHKKK";
            Console.WriteLine(FirstSequence.LongestSequence(sequence));


            // Excercise 3 
            List<int> numbers = new List<int>() { 1, 3, 5, 5, 2, 2 };
            Console.WriteLine(SecondSequence.SecondLowest(numbers));


            //Excercise 4
            
            decimal first = SavingAccountBalance.Balance(10000, 1, 20000, 1, 2); //#must be approximately 10201
            decimal second = SavingAccountBalance.Balance(25000, 2, 20000, 1, 2); //#must be approximately 25904.5
            decimal third = SavingAccountBalance.Balance(19800, 2, 20000, 1, 2); //#must be approximately 20597.96

            List<decimal> newBalances = new List<decimal>() { first, second, third };

            newBalances.ForEach(x => Console.WriteLine(x));

       






        }
    }
}
