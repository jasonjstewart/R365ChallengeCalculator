using System;

namespace Challenge_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //eliminate all spaces in the string, just in case someone added spaces on accident or something along those lines
            //just comment out the unneeded code and probably dont use so many branches
            String input;
            String[] numbers;
            int sum=0;
            int i = 0;
            Console.WriteLine("Please enter numbers separated by commas.");
            input = Console.ReadLine();
            numbers=input.Split(',');
            //Took this out for Requirement 2
            //if (numbers.Length>2)
            //{
            //    throw new System.ArgumentException("Too many numbers specified", "original");
            //}
            foreach (var num in numbers){                
                sum = Convert.ToInt32(int.TryParse(num, out i) ? num : "0") + sum;
            }
            Console.WriteLine(sum);
        }
    }
}
