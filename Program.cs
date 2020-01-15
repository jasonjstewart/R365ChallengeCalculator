/* Author: Jason Stewart
 * Description: found at https://github.com/restaurant365/challenge-calculator
 * this was for a project given to me by R365 before I started my internship this summer
 */

using System;

namespace Challenge_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            String[] numbers;
            String outputequation="";
            int sum=0;
            int i = 0;
            bool cont = true;

            while (cont == true) {
                    Console.WriteLine("Please enter numbers separated by commas.");
                    input = Console.ReadLine();
                    //Commented out the next line from Requirement 6
                    //string output = input.Substring(input.IndexOf('/') + 2,1);
                    string output = input.Substring(input.IndexOf("//") + 3, input.IndexOf(@"\n") - (input.IndexOf("//") + 4));
                    String[] delimiters = output.Split("][");
                    //input = input.Substring(input.IndexOf("//")+3);
                    input = input.Substring(input.IndexOf(@"\n") + 2);
                    input = input.Replace(@"\n", ",");
                    foreach (var d in delimiters)
                    {
                        input = input.Replace(d, ",");
                    }
                    numbers = input.Split(',');
                    //Took this out for Requirement 2
                    //if (numbers.Length>2)
                    //{
                    //    throw new System.ArgumentException("Too many numbers specified", "original");
                    //}

                    foreach (var num in numbers) {
                        i = Convert.ToInt32(int.TryParse(num, out i) ? num : "0");
                        if (i < 0)
                        {
                            throw new System.ArgumentException("Incorrect negative number entered.", "original");
                        }
                        if (i > 1000)
                        {
                            i = 0;
                        }
                        outputequation += i + "+";
                        sum = Convert.ToInt32(i) + sum;
                    }
                    outputequation = outputequation.Substring(0, outputequation.Length - 1) + "=" + sum;
                    Console.WriteLine(outputequation);
                    Console.WriteLine(sum);
            }
        }
    }
}
