using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Host
{
    private string _hostusername;
    private string _hostpassword;

    public string HostUsername
    {
        private set { _hostusername = value; }
        get { return _hostusername; }
    }

    public string HostPassword
    {
        private set { _hostpassword = value; }
        get { return _hostpassword; }
    }


    public string IPAddress { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Owner { get; set; }



    public Host(string ipaddress, string hostusername, string hostpassword, string owner)
    {
        IPAddress = ipaddress;
        HostUsername = hostusername;
        HostPassword = hostpassword;
        Owner = owner;
    }

    public void DisplayHostInfo()
    {
        Console.WriteLine($"IP Address: {IPAddress}");
        Console.WriteLine($"Username: {HostUsername}");
        Console.WriteLine($"Password: {HostPassword}");
        Console.WriteLine($"Owner: {Owner}");
    }
}