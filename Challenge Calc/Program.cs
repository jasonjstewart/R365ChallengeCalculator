/* Author: Jason Stewart
 * Description: found at https://github.com/restaurant365/challenge-calculator
 * this was for a project given to me by R365 before I started my internship in 2020
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Challenge_Calculator
{
    public class Program
    {

        public static string Calculator(string input)
        { 
            String[] numbers;
            String outputequation = "";
            int sum = 0;
            int i = 0;

            //Commented out the next line from Requirement 6
            //string output = input.Substring(input.IndexOf('/') + 2,1);
            string a = input.Substring(1, input.Length - 2);
            string h = input.Substring(2, 1);
            if (input.Substring(2, 1) == "[")
            {
                int b = input.IndexOf("//") + 3;
                int f = input.IndexOf(@"\n");
                int e = (input.IndexOf("//") + 4);
                int c = input.IndexOf(@"\n") - (input.IndexOf("//") + 4);

                string output = input.Substring(input.IndexOf("//") + 3, input.IndexOf(@"\n") - (input.IndexOf("//") + 4));
                String[] delimiters = output.Split("][");
                input = input.Substring(input.IndexOf(@"\n") + 2);
                foreach (var d in delimiters)
                {
                    input = input.Replace(d, ",");
                }
            }
            else if (input.Substring(1, 1) == "/")
            {
                input = input.Substring(input.IndexOf(@"\n") + 2);
            }
            //input = input.Substring(input.IndexOf("//")+3);
            input = input.Replace(@"\n", ",");
            numbers = input.Split(',');
            //Took this out for Requirement 2
            //if (numbers.Length>2)
            //{
            //    throw new System.ArgumentException("Too many numbers specified", "original");
            //}

            foreach (var num in numbers)
            {
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

            return (outputequation);
        }
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont == true)
            { 
                Console.WriteLine("Please enter numbers separated by commas, or \\n or create own delimiter by using // \\n,\n putting demlimiter in the middle bracketed by [].");
                string input = Console.ReadLine();
                Calculator(input);
            }
        }

        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestMethod1()
            {
                // Arrange
                string input = "\\[##][$$]\n1,2,3,4";
                string expected = "1+2+3+4=11";

                // Act
                string actual = Calculator(input);

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
