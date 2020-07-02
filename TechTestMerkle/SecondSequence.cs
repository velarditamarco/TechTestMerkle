using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TechTestMerkle
{
    public static class SecondSequence
    {
        public static int SecondLowest(List<int> numbers)
        {
            if (numbers.Count <= 0)
                throw new Exception("You should put some numbers in input");

            List<int> result = new List<int>();
            var groups = numbers.GroupBy(x => x);

            int maxCounter = groups.Max(x => x.Count());

            foreach (var group in groups)
            {
                if (group.Count() == maxCounter)
                    result.Add(group.Key);
            }

            result = result.OrderBy(x => x).ToList();           

            return result.Count > 1 ? result[1] : result[0];
        }
    }
}
