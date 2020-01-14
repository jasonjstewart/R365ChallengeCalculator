using System;

namespace Challenge_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            String[] numbers;
            int sum=0;
            int i = 0;
            Console.WriteLine("Please enter two numbers separated by commas.");
            input = Console.ReadLine();
            numbers=input.Split(',');
            if (numbers.Length>2)
            {
                throw new System.ArgumentException("Too many numbers specified", "original");
            }
            foreach (var num in numbers){                
                sum = Convert.ToInt32(int.TryParse(num, out i) ? num : "0") + sum;
            }
            Console.WriteLine(sum);
        }
    }
}
