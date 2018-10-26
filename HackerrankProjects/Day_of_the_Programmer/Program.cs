using System.IO;
using System;

namespace Day_of_the_Programmer
{
    class Solution
    {

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {

            int[] daysOfMonth = new int[]{
        31,
        29,
        31,
        30,
        31,
        30,
        31,
        31,
        30,
        31,
        30,
        31
    };

            int sum = 0;
            int daysBalance = 0;
            int i = 0;

            bool isLeapYear;
            if (year == 1918)
            {

            }
            else if (year < 1918)
            {
                //Julian
                isLeapYear = year % 4 == 0 ? true : false;

                foreach (var item in daysOfMonth)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in daysOfMonth)
                {
                    i++;
                    if (sum + Convert.ToInt32(item) < 256)
                    {
                        sum += Convert.ToInt32(item);
                        if (isLeapYear && i == 2)
                            sum++;
                    }
                    else if (sum + Convert.ToInt32(item) == 256)
                    {
                        sum += Convert.ToInt32(item);
                        daysBalance = 0;
                        if (isLeapYear && i == 2)
                            sum++;
                        break;
                    }
                    else
                    {
                        daysBalance = 256 - sum;
                        break;
                    }
                }

                Console.WriteLine("month " + daysOfMonth[i]);
                Console.WriteLine("days " + sum);
                Console.WriteLine("{0}.{1}.{2}", daysBalance, daysOfMonth[i + 1], year);
                return string.Format("{0}.{1}.{2}", daysBalance, i < 10 ? ("0" + i) : ("" + i), year);

            }
            else if (year > 1918)
            {
                //Georgion
                isLeapYear = (year % 400 == 0 ? true : false) || (year % 4 == 0 ? year % 100 == 0 ? false : true : false);

            }

            return "2";

        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = dayOfProgrammer(year);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
