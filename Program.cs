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
//inserting numbers in the list
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

//adding whole array to a list
List<int> numbers = new List<int>();
int[] array = new int[] { 1, 2, 3 };
numbers.AddRange(array);

//removing from a list
List<string> fruits = new List<string>();
// add fruits
fruits.Add("apple");
fruits.Add("banana");
fruits.Add("orange");

// now remove the banana
fruits.Remove("banana");
Console.WriteLine(fruits.Count);

//using index
// now remove the banana
fruits.RemoveAt(1);
Console.WriteLine(fruits.Count);

//concatenating lists
List<string> food = new List<string>();
food.Add("apple");
food.Add("banana");

List<string> vegetables = new List<string>();
vegetables.Add("tomato");
vegetables.Add("carrot");

food.AddRange(vegetables);
Console.WriteLine(food.Count);

//dictionary
Dictionary<string, long> phonebook = new Dictionary<string, long>();
phonebook.Add("Alex", 4154346543);
phonebook["Jessica"] = 4159484588;

//check if dictionary contains key
if (phonebook.ContainsKey("Alex"))
{
    Console.WriteLine("Alex's number is " + phonebook["Alex"]);
}

//removes item from dictionary
phonebook.Remove("Jessica");
Console.WriteLine(phonebook.Count);

//string formatting
int x = 1, y = 2;
int sum = x + y;
string sumCalculation = String.Format("{0} + {1} = {2}", x, y, sum);
Console.WriteLine(sumCalculation);

//substring
string fullString = "full string";
string partOfString = fullString.Substring(5);
string shorterPart = fullString.Substring(5, 3);
Console.WriteLine(partOfString);
Console.WriteLine(shorterPart);

//search and replace
string name = "John Doe";
string newName = name.Replace("John", "Eric");
Console.WriteLine(newName);

//indexof
string fruit = "apple,orange,banana";
Console.WriteLine("Found orange in position: " + fruit.IndexOf("orange"));
Console.WriteLine("Found lemon in position: " + fruit.IndexOf("lemon"));

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
