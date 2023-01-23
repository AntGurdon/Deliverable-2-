/*
Author: Anthony Gurdon
Date: 1/19/2023
Description: C# Console Application for calculating letter grades
*/

using System;

namespace Deliverable_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numberic grade: ");

            try
            {
                int grade = int.Parse(Console.ReadLine());

                string letter;

                if(grade >=1 && grade < 60)
                {
                    letter = "F";
                    Console.WriteLine("Your letter grade for ISM 4300 is F");
                }

                else if(grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your letter grade for ISM 4300 is D");
                }

                else if(grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your letter grade for ISM 4300 is C");
                }

                else if(grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your letter grade for ISM 4300 is B");
                }

                else if(grade >= 90 && grade <= 100)
                {
                    letter = "A";
                    Console.WriteLine("Your letter grade for ISM 4300 is A");
                }
            }
            catch
            {
                Console.WriteLine("Enter a numeric value");
            }

            Console.WriteLine("");
        }
    }
}

