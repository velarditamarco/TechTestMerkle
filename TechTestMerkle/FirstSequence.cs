using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace TechTestMerkle
{
    public static class FirstSequence
    {
        public static Tuple<char,int> LongestSequence(string sequence)
        {
            if (string.IsNullOrEmpty(sequence))
                throw new Exception("You should put some characters in input");

            sequence = sequence.ToLower();

            List<(char, int)> myList = new List<(char, int)>();

            int tempCounter = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (i > 0 && sequence[i] == sequence[i - 1])
                    tempCounter++;
                else
                    tempCounter = 1;

                myList.Add((sequence[i], tempCounter));
            }

            int maxCounter = myList.Max(x => x.Item2);

            List<char> resultCharList = myList.Where(x => x.Item2 == maxCounter)
                .Select(x => x.Item1)
                .ToList();
   
            resultCharList = resultCharList.OrderBy(x => x).ToList();

            return new Tuple<char, int>(resultCharList[0], maxCounter);        
        }

    }  
}
