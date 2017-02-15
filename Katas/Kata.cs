﻿using System;
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

        public int FlipBit(int value, int bitIndex)
        {
            var binary = Convert.ToString(value, 2).ToCharArray().Reverse().ToList();

            if (bitIndex - 1 >= binary.Count)
            {
                var loopCount = bitIndex - binary.Count;
                while (loopCount != 1)
                {
                    binary.Add('0');
                    loopCount--;
                }
                binary.Add('1');
            }
            else
            {
                if (binary[bitIndex - 1] == '1')
                {
                    binary[bitIndex - 1] = '0';
                }
                else
                {
                    binary[bitIndex - 1] = '1';
                }
            }
            
            return Convert.ToInt32(string.Join("", binary.ToArray().Reverse()),2);
        }
    }
}
