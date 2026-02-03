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
using System.Runtime.CompilerServices;
using System.Data.Common;


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
// List<int> lt = new List<int>();

// System.Console.WriteLine("add this number to the list:");

// for (int i = 0; i < 4; i++)
// {
//     int num = int.Parse(Console.ReadLine());
//     lt.Add(num);
//     System.Console.WriteLine("added : " + num);
// }

// foreach (int value in lt)
// {
//     System.Console.WriteLine(value);
// }

// List<string> lb = new List<string>();

// System.Console.WriteLine("input any string you want to add to the list");

// for (int x = 0; x < 4; x++)
// {
//     string input = Console.ReadLine();
//     lb.Add(input);
//     System.Console.WriteLine("added: " + input);

// }
// foreach (string value in lb)
// {
//     System.Console.WriteLine(value);
// }

// string name = new string{};
// name = "burh";
// System.Console.WriteLine(name);


Car Honda = new Car();
bool isthatcardrivingornah = Honda.IsDriving();
Honda.PrintSummary();
System.Console.WriteLine(isthatcardrivingornah);



public class Car
{
    //for identity of the car
    private string _make;
    private string _colour;

    //trying to turn the field into a property

    public string Colour
    {
        get { return _colour; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Colour can NOT be null or whitespace or blank you STUPID");
            }
            else
            {
                _colour = value;
            }
        }
    }


    private string _model;
    private string _VIN;
    private int _year;

    // for numeric calculations of the car
    private double _engineCapacity;

    public double EngineCapacity
    {
        get { return _engineCapacity; }
        private set
        {
            if (double.IsNegative(value))
            {
                throw new ArgumentException("Why are you trying to make the engine capacity negative bro cmon");
            }
            else
            {
                _engineCapacity = value;
            }
        }
    }

    //field fueltype
    private string _fueltype;

    //property fueltype
    public string Fueltype
    {
        get { return _fueltype; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Bruh why are you trynna make the fueltype null or whitespace lets be so fr");
            }
            else
            {
                _fueltype = value;
            }
        }
    }

    private int _horsepower;

    public int Horsepower
    {
        get { return _horsepower; }
        private set
        {
            if (int.IsNegative(value))
            {
                throw new ArgumentException("WHY is the horsepower negative?");
            }
            else if (value ==0)
            {
                throw new ArgumentException("WHY IS THE HORSEPOWER 0?");
            }
            else
            {
                _horsepower = value;
            }
        }
    }
    private string _transmission;

    public string Transmission
    {
        get { return _transmission; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("WHY DO YOU WANT TO MAKE THE TRANSMISSION NULL OR BLANK BRUH ARE YOU KIDDING BE SO FR");
            }
            else if ((!string.Equals(value, "manual", StringComparison.OrdinalIgnoreCase)) && (!string.Equals(value, "auto", StringComparison.OrdinalIgnoreCase)) &&
                     (!string.Equals(value, "semiauto", StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("please for the sake of everything that is green and lovely, the transmission can ONLY BE manual auto or semiauto");
            }
            else
            {
                _transmission = value;
            }
        }
    }


    //for usage and state of the car
    private double _mileage;

    public double Mileage
    {
        get { return _mileage; }
        private set
        {
            if (double.IsNegative(value))
            {
                throw new ArgumentException("why is the mileage negative? what are you trynna do here? whats wrong w you bruh");
            }
            else
            {
                _mileage = value;
            }
        }
    }

    private double _fuellevel;

    public double Fuellevel
    {
        get{return _fuellevel;}
        private set
        {
            if(double.IsNegative(value) || double.IsNaN(value))
            {
                throw new ArgumentException("PLEASE PLEASE fuel level CAN NOT BE NEGATIVE OR NOTANUMBER DUDDDDEEEE");
            }
            else
            {
                _fuellevel = value;
            }
        }
    } 


    public bool _isrunning;

    public bool IsRunning
    {
        get { return _isrunning; }
        private set { _isrunning = value; }
    }


    //ownership and value

    private double _price;
    public double Price
    {
        get{return _price;}
    }

    private string _ownername;

    public string Ownername
    {
        get{return _ownername;}
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("why is the owner's name null or empty or blank dude ts pmo fr 🥀");
            }
        }
    }


    private string _registrationNumber;

    public string Registrationnumber
    {
        get{return _registrationNumber;}
    }

    //lets try and make a default constructor:
    public Car()
    {
        this._make = "Honda";
        this._colour = "White";
        this._year = 2004; //this is my birthday year so im setting this as default
        this._model = "Civic";
        this._engineCapacity = 1800.0;
        this._fueltype = "89-Octane";
        this._price = 1700000.00;
    }

    //parameterized constructor
    public Car(string _make, string colour, int year, string model, double EngineCapacity, string fueltype, double price)
    {
        this._make = _make;
        this._colour = colour;
        this._year = year;
        this._model = model;
        this._engineCapacity = EngineCapacity;
        this._fueltype = fueltype;
        this._price = price;
    }


    public void PrintSummary()
    {
        System.Console.WriteLine(GetSummary());
    }

    public string GetSummary()
    {
        return $"Make: {_make}, Model: {_model}, Year: {_year}, Colour: {_colour}, " +
               $"Engine: {_engineCapacity}, Fuel: {_fueltype}, Price: {_price}";
    }


    public bool IsDriving()
    {
        IsRunning = true;
        return IsRunning;
    }

    public bool IsNotDriving()
    {
        IsRunning = false;
        return IsRunning;
    }

    public void StartEngine()
    {
        System.Console.WriteLine("Engine is now running. Chop Chop homie");
        IsRunning = true;
        _fuellevel--;
    }

    public void StopEngine()
    {
        System.Console.WriteLine("Engine has now stopped. Zzz");
    }

    public void Drive()
    {
        // if (IsRunning = true)
        // {
        //     IsDriving();
        //     System.Console.WriteLine("You are now driving the car.");
        //     _fuellevel--;
        // }
        // else
        // {
        //     throw new ArgumentException("How are you driving without the engine running dude.");
        // }
        IsDriving();
    }

    public void Refuel(int ammount)
    {
        if (_fuellevel > 1000)
        {
            System.Console.WriteLine("broooooo your car cant be refueled the fuel level is full");
        }
       else
        {
            _fuellevel += ammount;
        }
    }

}

