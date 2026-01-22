System.Console.WriteLine("Please input your name");
string? name = Console.ReadLine();

//checking for not null or whitespace
if (string.IsNullOrWhiteSpace(name)) //learnt this through chatpgt 
{
    System.Console.WriteLine("do not input null please");
}

System.Console.WriteLine("Please input your age");
int? age = int.Parse(Console.ReadLine());

if (age is null)
{
    System.Console.WriteLine("do not enter null value for your age bruh");
}

//checking for a real age entered 
if ((age < 0) || (age > 120))
{
    System.Console.WriteLine($"invalid age entered:{age} is not a real age dude ");
}

System.Console.WriteLine($"welcome home {name}, of age {age}");
