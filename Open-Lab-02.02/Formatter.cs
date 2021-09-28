using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            foreach (double num in numbers) 
            { 
                Console.Write(String.Format("{0:0.00} ", num)); 
            }
        }
    }
}
