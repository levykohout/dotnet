using System;

namespace ConsoleApplication
{
    public enum CarType
{
    Toyota = 1,
    Honda = 2,
    Ford = 3,
}

    public class Program
    {
        public static void Main(string[] args)
        {
            CarType myCarType = CarType.Toyota;
            //defining variables
            
//             int myInt = 1;
// float myFloat = 1f;
// bool myBoolean = true;
// string myName = "John";
// char myChar = 'a';
// double myDouble = 1.75;

//defining empty array
int[] nums = new int[10];
//initializing array
int[] nums = { 1, 2, 3, 4, 5 };
//defining a list
List<int> numbers = new List<int>();
//inserting numbers in the listnumbers.Add(1);
numbers.Add(2);
numbers.Add(3);

            string productName ="TV";
       int productYear = 2012;
       double productPrice = 279.99;

      // test code
      Console.WriteLine("productName: " + productName);
      Console.WriteLine("productYear: " + productYear);
      Console.WriteLine("productPrice: " + productPrice);
      Console.WriteLine(nums.Length);
            Console.WriteLine("Hello Levy!");
        }
    }
}
