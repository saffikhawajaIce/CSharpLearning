// // See https://aka.ms/new-console-template for more information

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

// int firstint = 5;
// if (firstint > 0)
// {
//     int secondint = 6;
//     firstint = firstint + secondint;
// }
// System.Console.WriteLine(firstint);


// bool flag = true; if (flag) {System.Console.WriteLine(flag);}

// System.Console.WriteLine("bruh the extion isnt running this is so sad");

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// foreach (int number in numbers)
// {
//     int total;
//     total += number;

//     if (number == 42)
//     {
//        bool found = true;
//     }
// }

// if (found) {Console.WriteLine("Set contains 42");}

// Console.WriteLine($"Total: {total}");

// string measurement = "104";

// int result = 0;

// result = int.Parse(measurement);
// System.Console.WriteLine(result);

// string measurement2 = "104";

// result += int.Parse(measurement2);
// System.Console.WriteLine( result);


// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// float sum = 0;
// float valueNumber;
// string message = "";

// foreach (string value in values)
// {
//     if (float.TryParse(value, out valueNumber) == true)
//     {
//         sum += valueNumber;
//     }
//     else
//     {
//         message += value;
//     }
// }
// System.Console.WriteLine($"Message: {message}\nTotal: {sum}");

using System.Runtime.InteropServices.Marshalling;
using Microsoft.Win32;

// string[] arrayValues = {"A11","B12", "A12","B13", "A10", "C10", "C11", "B10", "C12"};
// System.Console.WriteLine("Sorted..");
// Array.Sort(arrayValues);
// foreach (string value in arrayValues)
// {
//     System.Console.WriteLine($"Value -- {value}");
//     Thread.Sleep(200);
// }
// Array.Reverse(arrayValues);
// foreach (string value2 in arrayValues)
// {
//     System.Console.WriteLine($"Reversed Value -- {value2}");
//     Thread.Sleep(200);
// }

// string message1 = "abc123";
// char [] normalArray = message1.ToCharArray();
// foreach (char value in message1)
// {
//     System.Console.WriteLine($"the char is {value}");
// }

// string pangram = "The quick brown fox jumps over the lazy dog";
// string reversedPanagram = "";
// string[] items = pangram.Split(' ');

// foreach (string word in items)
// {
//     char [] panagramCharacters = word.ToCharArray();
//     Array.Reverse(panagramCharacters);

//     reversedPanagram += new string(panagramCharacters) + " ";
// }
// System.Console.WriteLine(reversedPanagram);

// System.Console.WriteLine("enter the width of rectangle you'd like to see the area for");

// double width = double.Parse(Console.ReadLine());

// System.Console.WriteLine("enter the width of rectangle you'd like to see the area for");

// double height = double.Parse(Console.ReadLine());

// System.Console.WriteLine("the area of the rectangle is: " + GetRectangleArea(width,height));

// static double GetRectangleArea(double width, double height)
// {
//     double area = width * height;
//     return area;
// }

    // long sum = CalcSum(2, 5);

    // Console.WriteLine(sum);

    // long sum2 = CalcSum(4, 0, -2, 12);

    // Console.WriteLine(sum2);

    // long sum3 = CalcSum();

    // Console.WriteLine(sum3);

// System.Console.WriteLine("write the numbers you need to sum up");

// int userinput = int.Parse(Console.ReadLine());

// long sum4 = CalcSum(userinput);
// System.Console.WriteLine(sum4);

// static long CalcSum(params int[] elements)
// {
//     long sum = 0;

//     foreach (int element in elements)
//     {
//         sum += element;
//     }
//     return sum;
// }
