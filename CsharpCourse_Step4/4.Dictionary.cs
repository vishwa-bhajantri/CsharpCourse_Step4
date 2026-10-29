

using System;
using System.Collections.Generic;

namespace CsharpCourse_Step4
{
    internal class DictionaryExample
    {

        static void Main()
        {
            Dictionary<int, string> myBook = new Dictionary<int, string>();
            myBook.Add(1, "Introduction");
            myBook.Add(2, "Chapter1");
            myBook.Add(3, "Chapter2");
            myBook.Add(4, "Chapter3");
            myBook.Add(5, "Chapter4");

            foreach(var mybook  in myBook)
            {
                Console.WriteLine(mybook.Key + " : " + mybook.Value);
            }



            Dictionary<string, int> studentGrades = new Dictionary<string, int>();
            studentGrades.Add("Alice", 90);
            studentGrades.Add("Bob", 92);
            studentGrades.Add("Charlie", 95);
            Console.WriteLine("Bobs Grade is " + " : " + studentGrades["Bob"]);
            Console.WriteLine(studentGrades.ContainsKey("David"));


            //updating the value
            studentGrades["Charlie"] = 65;


            foreach (var stu in studentGrades)
            {
                Console.WriteLine(stu.Key + " : " + stu.Value);
            }

            //Removing the value
            studentGrades.Remove("Alice");

            foreach (var stu in studentGrades)
            {
                Console.WriteLine(stu.Key + " : " + stu.Value);
            }
        }

    }
}
