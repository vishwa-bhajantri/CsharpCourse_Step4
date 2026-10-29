

using System;
using System.Collections.Generic;

namespace CsharpCourse_Step4
{
    class ListExample
    {
        static void Main()
        {

            List<int> numbers = new List<int>();

            //Adding the Elements
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            Console.WriteLine($"Size of numbers {numbers.Count}");

            Console.WriteLine("List of Elements");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            //Removing the Elements
            numbers.Remove(20);
            Console.WriteLine($"Size of numbers after Removing {numbers.Count}");

            Console.WriteLine("List of Elements after Removing");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


            List<string> names = new List<string>() { "Alice", "Bob", "Robert" };
            names.Add("John");

            Console.WriteLine("List of Name");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            List<int> scores = new List<int>() { 10, 20, 30, 40 };
            Console.WriteLine("Scores are");
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            scores.Insert(1, 15);

            Console.WriteLine("After Inserting Scores are");
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            scores.RemoveAt(3);
            Console.WriteLine("After Removing Scores are");
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            scores[3] = 60;
            Console.WriteLine("After Updating Scores are");
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine(scores.Contains(20));
        }
    }
}
