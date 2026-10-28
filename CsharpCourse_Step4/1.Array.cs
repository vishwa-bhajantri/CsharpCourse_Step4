using System;

namespace CsharpCourse_Array
{
    class ArrayExample
    {
        static void Main()
        {
            int[] numbers = new int[4];

            numbers[0] = 40;
            numbers[1] = 30;
            numbers[2] = 20;
            numbers[3] = 10;

            int number3 = numbers[3];

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"Index value is {Array.IndexOf(numbers, 20)}");
            Console.WriteLine($"Index value is {Array.IndexOf(numbers, 40)}");
            Console.WriteLine($"Index value is {Array.IndexOf(numbers, 50)}");

            Array.Sort(numbers);

            int[] destinationArray = new int[numbers.Length];

            Array.Copy(numbers, destinationArray, numbers.Length);

            foreach(int d  in destinationArray)
            {
                Console.WriteLine(d);
            }

            numbers[0] = 5;

            Console.ReadLine();
        }
    }
}