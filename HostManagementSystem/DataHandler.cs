using System.Runtime.ConstrainedExecution;

public class TheDataHandlerBrother
{

    public ValidationSystem validator;

    //basically i want to use this method to load all of the data from the file into the program so that im able to manipulate it and use it properly
    public Dictionary<string, string> LoadUserDataFromFile()
    {
        Dictionary<string, string> userData = new Dictionary<string, string>();

        try
        {
            if (!File.Exists(@"C:\Users\Saffi\CSharpLearning\HostManagementSystem\UserLoginInfo.txt"))
                return userData;

            string[] lines = File.ReadAllLines(@"C:\Users\Saffi\CSharpLearning\HostManagementSystem\UserLoginInfo.txt");

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split('|');

                if (parts.Length == 2)
                {
                    string username = parts[0];
                    string password = parts[1];

                    if (!userData.ContainsKey(username))
                        userData.Add(username, password);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return userData;
    }

    //method for loading host information from the file into the program so that i can manipulate it and use it properly
    public List<Host> LoadHostDataFromFile()
    {
        List<Host> hostData = new List<Host>();

        try
        {
            if (!File.Exists(@"C:\Users\Saffi\CSharpLearning\HostManagementSystem\HostInfo.txt"))
                return hostData;

            string[] lines = File.ReadAllLines(@"C:\Users\Saffi\CSharpLearning\HostManagementSystem\HostInfo.txt");

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split('|');

                if (parts.Length == 4)
                {
                    string ipAddress = parts[0];
                    string username = parts[1];
                    string password = parts[2];
                    string owner = parts[3];

                    Host host = new Host(ipAddress, username, password, owner);
                    hostData.Add(host);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return hostData;
    }

    //im using this method here to append an entry into the end of the file
    public void AddUserAuthInfoToFile(string inputUsername, string inputPassword)
    {
        try
        {

            if (!string.IsNullOrWhiteSpace(inputUsername) && !string.IsNullOrWhiteSpace(inputPassword))
            {
                File.AppendAllText(@"C:\Users\Saffi\CSharpLearning\HostManagementSystem\UserLoginInfo.txt", $"{inputUsername}|{inputPassword}" + Environment.NewLine);
                Console.WriteLine("User information saved successfully!");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void AddHostInformation(string ipAddress, string username, string password, string owner)
    {
        try
        {
            if (!string.IsNullOrWhiteSpace(ipAddress) && !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(owner))
            {
                File.AppendAllText(@"C:\Users\Saffi\CSharpLearning\HostManagementSystem\HostInfo.txt", $"{ipAddress}|{username}|{password}|{owner}" + Environment.NewLine);
                Console.WriteLine("Host information saved successfully!");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void UpdateHostInformation(string ipAddres, string username, string password, string owner)
    {
        try
        {
            List<Host> hostData = LoadHostDataFromFile();

            for (int i = 0; i < hostData.Count; i++)
            {
                if (hostData[i].IPAddress == ipAddres)
                {
                    hostData[i].Username = username;
                    hostData[i].Password = password;
                    hostData[i].Owner = owner;
                    break;
                }
            }

            using (StreamWriter writer = new StreamWriter(@"C:\Users\Saffi\CSharpLearning\HostManagementSystem\HostInfo.txt"))
            {
                foreach (Host host in hostData)
                {
                    writer.WriteLine($"{host.IPAddress}|{host.Username}|{host.Password}|{host.Owner}");
                }
            }

            Console.WriteLine("Host information updated successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }


    public void DeleteHostFromFile(string ipAddress, TheDataHandlerBrother datahandler)
    {
        List<Host> hostData = datahandler.LoadHostDataFromFile();

        for (int i = 0; i < hostData.Count; i++)
        {
            if (hostData[i].IPAddress == ipAddress)
            {
                hostData.RemoveAt(i);
                break;
            }
        }
    }
}
