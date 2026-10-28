

using System;
using System.Collections;

namespace CsharpCourse_Step4
{
    class ArrayListExample
    {
        static void Main()
        {
            ArrayList numbers = new ArrayList();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            Console.WriteLine($"Size of numbers {numbers.Count}");
            Console.WriteLine($"Array List Afetr Adding the Numbers");
            Console.WriteLine($"Capacity of numbers {numbers.Capacity}");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            ArrayList items = new ArrayList();
            items.Add(10);
            items.Add("Hello");
            items.Add(15.5);

            Console.WriteLine($"Array List Afetr Adding the Items");

            foreach(var item in items)
            {
                Console.WriteLine($"{item} - {item.GetType()}");
            }

            //Boxing and Unboxing

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add("Hello");

            int firstValue = (int)list[0];
            int secondValue = (int)list[1];
            string thirdValue = (string)list[2];

        }
    }
}
