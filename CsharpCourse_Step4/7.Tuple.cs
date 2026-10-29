

using System;

namespace CsharpCourse_Step4
{
    internal class TupleExample
    {

        static int getProductID()
        {
            return 101;
        }

        static string getProductName()
        {
            return "Wireless Mouse";
        }

        static double getProductPrice()
        {
            return 1299.99;
        }

        static (int Id, string name, double price) getProductDetailes()
        {
            return (101, "Wireless Mouse", 1299.99);
        }
        static void Main()
        {

            int productID = getProductID();
            Console.WriteLine(productID);

            string productName = getProductName();
            Console.WriteLine(productName);

            double price = getProductPrice();
            Console.WriteLine(price);

            (int id, string name, double productPrice) = getProductDetailes(); //Tuple Deconstruction
            Console.WriteLine($"Product ID : {id}, Product Name is : {name}, Price is : {productPrice}");


            (int uid, string name, bool uActive) user = (50, "ALice", false); //Value Type Tuple
            Console.WriteLine($"{user.uid} , {user.name} , {user.uActive}");


            Tuple<int, string, bool> person2 = new Tuple<int, string, bool>(50, "ALice", false);
            Console.WriteLine($"Age : {person2.Item1} Name : {person2.Item2} , Active {person2.Item3}");

            var studentReport = ("John", 450, "A");
            Console.WriteLine($"Student : {studentReport.Item1} Total Marks : {studentReport.Item2} , Grade {studentReport.Item3}");

            Console.WriteLine(studentReport.GetType());


            var studentReport1 = (name : "Wick", Marks : 900, Grade : "C+");
            Console.WriteLine($"Student : {studentReport1.name} Total Marks : {studentReport1.Marks} , Grade {studentReport1.Grade}");
        }
    }
}
