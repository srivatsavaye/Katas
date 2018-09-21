using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class Kata
    {
        public string DeNico(string key, string message)
        {
           /*
            int[] coder = key.OrderBy(x => x).Select(e => key.IndexOf(e)).ToArray();
            return string.Concat(message.Select((e, i) => message[i / key.Length * key.Length + Array.IndexOf(coder, i % key.Length)])).TrimEnd(' '); ;

            Console.WriteLine(string.Join(",",message.Select((e, i) => message[i / key.Length * key.Length + Array.IndexOf(coder, i % key.Length)])));

            var test = message.Select((e, i) =>
            {
                Console.WriteLine(message[i / key.Length * key.Length + Array.IndexOf(coder, i % key.Length)]);
                return message[i / key.Length * key.Length + Array.IndexOf(coder, i % key.Length)];
            });


            */
            var splitKey = Regex.Split(key, string.Empty).Where(s => s != string.Empty).OrderBy(s => s).ToArray();

            var splitMessage = Regex.Split(message, string.Empty).Where(s => s != string.Empty).ToArray();
            var k = 0;
            
            foreach (var m in splitMessage)
            {
                if (k < splitKey.Length)
                {
                    splitKey[k] = splitKey[k] + m;
                    k++;
                }
                else
                {
                    splitKey[0] = splitKey[0] + m;
                    k = 1;
                }
            }

            //Console.WriteLine(key);
            //Console.WriteLine(message);
            //Console.WriteLine(string.Join(",", splitKey));
            
            var finalResult = new StringBuilder();

            var max = splitKey.Max(s => s.Length);
            for (var i = 1; i < max; i++)
            {
                foreach (var e in key)
                {
                    var t = splitKey.First(s => s.StartsWith(e.ToString()));
                    if (i < t.Length)
                    {
                        finalResult.Append(t[i]);
                    }
                }
            }

            return finalResult.ToString().TrimEnd();
        }

        public  bool isMerge(string s, string part1, string part2)
        {
            Console.WriteLine("{0}->{1},{2}", s, part1, part2);
            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(part1) && string.IsNullOrEmpty(part2))
            {
                return true;
            }
            if (string.IsNullOrEmpty(s) && (!string.IsNullOrEmpty(part1) || !string.IsNullOrEmpty(part2)))
            {
                return false;
            }


            var original = s.ToCharArray().ToList();
            var w1 = part1.ToCharArray().ToList();
            var w2 = part2.ToCharArray().ToList();
            var combined = new List<char>();
            combined.AddRange(w1);
            combined.AddRange(w2);

            var intersect = original.Where(r => combined.Contains(r));
            Console.WriteLine("Intersect: {0}, Original: {1}, plain Intersect: {2}", string.Join("", intersect.OrderBy(x => x)), string.Join("", original.OrderBy(x => x)), string.Join("", intersect));
            if (string.Join("", intersect.OrderBy(x => x)) != string.Join("", original.OrderBy(x => x)))
            {
                Console.WriteLine("Word matching Failure");
                return false;
            }

            var w1Intersect = original.Where(r => w1.Contains(r)).ToArray();

            for (var i = 0; i < w1Intersect.Count(); i++)
            {
                if (w1Intersect[i] != w1[i])
                {
                    Console.WriteLine("Order Failure 1");
                    return false;
                }
            }


            var w2Intersect = original.Where(r => w2.Contains(r)).ToArray();

            for (var i = 0; i < w2Intersect.Count(); i++)
            {
                if (w2Intersect[i] != w2[i])
                {
                    Console.WriteLine("Order failure 2");
                    return false;
                }
            }

            return true;


        }

        public bool IsAllPossibilities(int[] arr)
        {
           // Console.WriteLine(string.Join(",", arr));
            /* foreach(var a in arr)
             {Console.WriteLine(a);}*/

            //Console.WriteLine("Over");
            //Console.WriteLine(arr != null && arr.Length > 0 && !arr.Any(a => a < 0 || a > arr.Length - 1));
            return arr != null && arr.Length > 0 && !arr.Any(a => a < 0 || a > arr.Length - 1);

        }

        public bool IsAllPossibilities_copied(int[] arr)
        {
            var e = Enumerable.Range(0, arr.Length);
            var r = e.Except(arr);

            return arr.Any() && !Enumerable.Range(0, arr.Length).Except(arr).Any();

            //List<int> list = arr.ToList();
            //list.Sort();
            //return (list.Count > 0 && list[0] == 0 && list[list.Count - 1] == list.Count - 1);
        }

        

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

        public int BouncingBall(double h, double bounce, double window)
        {
            if (bounce <= 0 || bounce >= 1 || h <= window)
            {
                return -1;
            }
            var bounces = 1;
            var height= h * bounce;
            while (height > window)
            {
                height = height * bounce;
                bounces = bounces + 2;
            }

            return bounces;
        }

        public  int[] BuyingACar(int startPriceOld, int startPriceNew, int savingperMonth, double percentLossByMonth)
        {
            double priceNew = startPriceNew;
            double priceOld = startPriceOld;
            double amountSaved = 0;
            var counter = 0; 

            while (amountSaved + priceOld < priceNew)
            {
                if (counter % 2 == 1)
                {
                    percentLossByMonth = percentLossByMonth + .5;
                }
                counter++;
                priceOld = priceOld - ((priceOld * percentLossByMonth)/100);
                priceNew = priceNew - ((priceNew * percentLossByMonth)/100);
                amountSaved = amountSaved + savingperMonth;
            }

            var buyingACar = new[] {counter, Convert.ToInt32(amountSaved + priceOld - priceNew)};
            return buyingACar;
        }
    }

    class BagelSolver
    {
        public static Bagel Bagel
        {
            get
            {
                // TODO: Implement me
                return new Bagel() ;
            }

        }
    }

    sealed class Bagel
    {
        public int Value { get; } = 3;
    }
}
