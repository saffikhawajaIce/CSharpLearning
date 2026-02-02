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

using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;


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

//fibonachi sequence generator using loop

// int fibnumber;
// int firstnum = 0;
// int secondnum = 1;

// System.Console.WriteLine("How many iterations of the fibonachi sequence would you like to see?");
// string input = Console.ReadLine().Trim();
// int sequenceLength = int.Parse(input);

// for (int i = 0; i < sequenceLength; i++)
// {
//     fibnumber = firstnum + secondnum;
//     firstnum = secondnum;
//     secondnum = fibnumber;
//     System.Console.WriteLine(fibnumber);
// }

//fibonachi sequence generator using recursion
// System.Console.WriteLine("enter the nt");
// string input = Console.ReadLine().Trim();
// int fibnumber = int.Parse(input);

// if (fibnumber < 0 || fibnumber > 30 )
// {
//     System.Console.WriteLine("please do not enter negative numbers or numbers above 30");
// }

// else if (fibnumber > 0)
// {
//     Console.WriteLine(fibonachiNumberGenerator(fibnumber));
// }

// int fibonachiNumberGenerator(int value)
// {
//     if (value <= 2)
//     {
//         return 1;
//     }
//     else
//     {
//         return fibonachiNumberGenerator(value - 1) + fibonachiNumberGenerator(value - 2);
//     }
// }

//List practice
List<int> lt = new List<int>();

System.Console.WriteLine("add this number to the list:");

for (int i = 0; i < 4; i++)
{
    int num = int.Parse(Console.ReadLine());
    lt.Add(num);
    System.Console.WriteLine("added : " + num);
}

foreach (int value in lt)
{
    System.Console.WriteLine(value);
}

List<string> lb = new List<string>();

System.Console.WriteLine("input any string you want to add to the list");

for (int x = 0; x < 4; x++)
{
    string input = Console.ReadLine();
    lb.Add(input);
    System.Console.WriteLine("added: " + input);

}
foreach (string value in lb)
{
    System.Console.WriteLine(value);
}
