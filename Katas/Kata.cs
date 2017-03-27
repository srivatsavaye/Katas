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
}
