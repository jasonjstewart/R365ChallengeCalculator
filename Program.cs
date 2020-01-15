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

            Console.WriteLine("Please enter numbers separated by commas.");
            input = Console.ReadLine();
            //Commented out the next line from Requirement 6
            //string output = input.Substring(input.IndexOf('/') + 2,1);
            string output = input.Substring(input.IndexOf('[') + 1, input.IndexOf(']')- (input.IndexOf('[')+1));
            input = input.Substring(input.IndexOf("//")+3);
            input =input.Replace(@"\n",",");
            input=input.Replace(" ", "");
            input = input.Replace(output, ",");
            numbers =input.Split(',');
            //Took this out for Requirement 2
            //if (numbers.Length>2)
            //{
            //    throw new System.ArgumentException("Too many numbers specified", "original");
            //

            foreach (var num in numbers){
                i = Convert.ToInt32(int.TryParse(num, out i) ? num : "0");
                if (i < 0)
                {
                    throw new System.ArgumentException("Incorrect negative number entered.", "original");
                }
                if (i > 1000)
                {
                    i = 0;
                }
                sum = Convert.ToInt32(i) + sum;
            }
            Console.WriteLine(sum);
        }
    }
}
