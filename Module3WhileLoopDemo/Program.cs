using System;
using static System.Console;

//Name: James Shoemaker
//Date: 04/04/2020
//Program Description: Module 3 while loop demo

namespace Module3DefiniteWhileLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Grading Application - Requests 5 grades and then calculates the average
            int grade = 0;
            double total = 0;
            double average = 0.0;
            const int GRADE_COUNT = 5;
            int counter = 1;

            //this is a definite loop!!!!!!!!!!
            while(counter <=GRADE_COUNT)
            {
                Write(" Please enter a grade as an integer: ");
                grade = int.Parse(ReadLine());

                total = total + grade;

                //Make sure to increment the counter!!
                counter++;
            }

            average = total / GRADE_COUNT;
            WriteLine($"the average grade is: {average.ToString("F1")}");

        }
    }
}
