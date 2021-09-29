using System;
using System.Globalization;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    string num = String.Format("{0:0.00}", numbers[i]);
                    num = num.Replace(',', '.');
                    Console.Write(num);
                }
                else
                {
                    string num = String.Format("{0:0.00} ", numbers[i]);
                    num = num.Replace(',', '.');
                    Console.Write(num);
                }
            }
        }
    }
}
