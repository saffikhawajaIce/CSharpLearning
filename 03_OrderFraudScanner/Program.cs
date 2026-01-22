// See https://aka.ms/new-console-template for more information

using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

string [] IDPrefixes = {"A","B","C","D","E","F"};
int [] IDSuffix = new int[18];
string [] IDPrefix = new string [18];
Random Random = new Random();

for (int i = 0; i < IDPrefix.Length; i++)
{
    IDPrefix[i] = IDPrefixes[Random.Next(0,IDPrefixes.Length)];
}

for (int i = 0; i < IDSuffix.Length; i++)
{
    IDSuffix[i] = Random.Next(0, 100); 
}
    
string[] OrderIDs = new string [18];
for ( int i = 0; i < OrderIDs.Length; i++)
{
    string tempSuffix = IDSuffix[i].ToString();
    OrderIDs[i] = $"{IDPrefix[i]}{tempSuffix}";
    System.Console.WriteLine($"Generated Order ID: {OrderIDs[i]}");
    Thread.Sleep(500);
}

System.Console.WriteLine("now we check for fraudulent ID's. \nFraudulent ID's are ID's that start with Prefix 'B'");

for (int x = 0; x<OrderIDs.Length; x++)
{
    if (OrderIDs[x].StartsWith('B'))
    {
        System.Console.WriteLine($"ID at {x} is invalid! this ID is {OrderIDs[x]} and is invalid. ");
        Thread.Sleep(200);
    }
}







