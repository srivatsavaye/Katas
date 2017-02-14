using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class Kata
    {

        public int SumWithOutHighestAndLowestNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 1)
                return 0;
            numbers = numbers.OrderBy(r => r).ToArray();
            numbers[0] = 0;
            numbers[numbers.Length - 1] = 0;
            //var orderedList = numbers.OrderBy(n => n).ToList();
            //orderedList.RemoveAt(0);
            //orderedList.RemoveAt(orderedList.Count - 1);

            return numbers.Sum(r => r);
        }
    }
}
