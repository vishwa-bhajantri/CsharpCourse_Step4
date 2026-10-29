
using System;
using System.Collections.Generic;

namespace CsharpCourse_Step4
{
    internal class HashSetExample
    {
        static void Main()
        {
            HashSet<string> userNames = new HashSet<string>();

            userNames.Add("Alice");
            userNames.Add("Bob");
            userNames.Add("Charlie");

            userNames.Add("Bob");

            bool isAliceAvailable = userNames.Contains("Alice");
            Console.WriteLine(isAliceAvailable);

            foreach(string name in userNames)
            {
                Console.WriteLine(name);
            }

            userNames.Remove("Bob");

            bool isBobAvailable = userNames.Contains("Bob");
            Console.WriteLine(isBobAvailable);
        }
    }
}
