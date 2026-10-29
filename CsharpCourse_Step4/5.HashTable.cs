using System;
using System.Collections;

namespace CsharpCourse_Step4
{
    internal class HashTableExample
    {
        static void Main()
        {
            Hashtable studentDetails = new Hashtable();
            studentDetails.Add("Name", "Alice");
            studentDetails.Add("Age", 20);
            studentDetails.Add("Location", "New York");
            studentDetails.Add("isStudent", true);

            Console.WriteLine(studentDetails["Name"]);
            Console.WriteLine(studentDetails["Age"]);
            Console.WriteLine(studentDetails["Location"]);
            Console.WriteLine(studentDetails["isStudent"]);

            foreach (DictionaryEntry item in studentDetails)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }


            Hashtable data =  new Hashtable();
            data.Add("Meken", "+91-78952145");
            data.Add(101, "Employee Id is : 101");
            data.Add("salary", 50000);
            data.Add("isActive", true);
            data.Add("otherIncome", 800000);
            data.Add("isAdmin", true);
            data.Add(true, "isActive");


            Console.WriteLine($"Phone Number of Meken : {data["Meken"]}");
            Console.WriteLine($"{data[101]}");
            Console.WriteLine($"Salary of Meken : {data["salary"]}");
            Console.WriteLine($"isActive of Meken : {data["isActive"]}");
            Console.WriteLine($"otherMeken of Meken : {data["otherIncome"]}");
            Console.WriteLine($"isAdmin of Meken : {data["isAdmin"]}");
            Console.WriteLine($"isActive of Meken : {data["true"]}");


            foreach (DictionaryEntry Data in data)
            {
                Console.WriteLine(Data.Key + " : " + Data.Value);
            }

            Console.WriteLine($"salary of Meken : {data.ContainsKey("salary")}");

            try
            {
                data.Add("Meken", "+91655545358");
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine(e.Message);
                }
            }

            data.Remove("isActive");

            data.Clear();
        }
    }
}
