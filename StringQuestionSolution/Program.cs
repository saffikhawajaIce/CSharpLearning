public class TheOneandOnlyProgram
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello, World!");

        System.Console.WriteLine("enter a string");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            System.Console.WriteLine("please do not enter empty string");
        }

        Dictionary<char, int> Dict = new Dictionary<char, int>();

        char[] stringarray = input.ToCharArray();

        foreach (char a in stringarray)
        {
            if (!Dict.ContainsKey(a))
            {
                Dict[a] = 1;
            }
            else if (Dict.ContainsKey(a))
            {
                Dict[a]++;
            }
        }

        foreach (KeyValuePair<char, int> value in Dict)
        {
            System.Console.WriteLine($"the character {value.Key} has a frequency of {value.Value}");
        }

        bool found = false;

        foreach (char s in stringarray)
        {
            if (Dict[s] == 1)
            {
                System.Console.WriteLine($"the first non repeating character is {s}");
                found = true;
                break;
            }

            else if (Dict[s] > 1)
            {
                continue;
            }

            else if (!found)
            {
                System.Console.WriteLine("no non repeating character found, returning 0\n0");
            }

        }
    }
}