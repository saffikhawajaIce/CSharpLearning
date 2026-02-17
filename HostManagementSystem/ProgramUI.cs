using System.Dynamic;
using System.Runtime.ConstrainedExecution;

public class ProgramUI
{
    private string passwordFormat;
    private string usernameFormat;

    private string hostIPFormat;


    public string PasswordFormat
    {
        get { return passwordFormat; }
        set { passwordFormat = value; }
    }

    public string UsernameFormat
    {
        get { return usernameFormat; }
        set { usernameFormat = value; }
    }

    public string HostIPFormat
    {
        get { return hostIPFormat; }
        set { hostIPFormat = value; }
    }

    public ProgramUI()
    {
        PasswordFormat = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.";
        UsernameFormat = "Username must be at least 5 characters long and can only contain letters and numbers.";
        HostIPFormat = "IP address must be in the format xxx.xxx.xxx.xxx";
    }


    public void DisplayUserMenu()
    {
        System.Console.WriteLine("1. Create a new Host\n2. View Existing Hosts\n3. Update Host information\n4. Delete Host\n5. Logout");
    }

    public void DisplayMainMenu()
    {
        System.Console.WriteLine("1. Login as user\n2. Create a new Account\n3. Exit");
    }

    public int GetMnenuChoiceInput()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        return choice;
    }

    public void DisplayCreateAccountMenu()
    {
        System.Console.WriteLine("Create a new account");
        System.Console.WriteLine($"Please enter your username in the following format:\n {UsernameFormat}");
        System.Console.WriteLine($"Please enter your password in the following format:\n {PasswordFormat}");
    }

    public void DisplayCreateHostMenu()
    {
        System.Console.WriteLine("Create a new Host");
        System.Console.WriteLine($"Please enter the Host's IP address in the following format:\n {HostIPFormat}");
        System.Console.WriteLine($"Please enter the Host's username in the following format:\n {UsernameFormat}");
        System.Console.WriteLine($"Please enter the Host's password in the following format:\n {PasswordFormat}");
    }

    public void DisplayUpdateHostMenu()
    {
        System.Console.WriteLine("Update Host information");
        System.Console.WriteLine($"Please enter the Host's new IP address in the following format:\n {HostIPFormat}");
        System.Console.WriteLine($"Please enter the Host's new username in the following format:\n {UsernameFormat}");
        System.Console.WriteLine($"Please enter the Host's new password in the following format:\n {PasswordFormat}");
    }

    public void DisplayDeleteHostMenu()
    {
        System.Console.WriteLine("Delete Host");
        System.Console.WriteLine($"Please enter the Host's IP address in the following format:\n {HostIPFormat}");
    }

    public void DisplayLogoutMenu()
    {
        System.Console.WriteLine("You have been logged out.");
    }

    public void DisplayExitMessage()
    {
        System.Console.WriteLine("Thank you for using the Host Management System. Goodbye!");
    }

    public void DisplayInvalidInputMessage()
    {
        System.Console.WriteLine("Invalid input. Please try again.");
    }

    public void DisplayInvalidPasswordMessage()
    {
        System.Console.WriteLine("Invalid password format. Please try again.");
    }

    public void DisplayInvalidUsernameMessage()
    {
        System.Console.WriteLine("Invalid username format. Please try again.");
    }

    public void DisplayInvalidIPAddressMessage()
    {
        System.Console.WriteLine("Invalid IP address format. Please try again.");
    }

    public string GetStringInput()
    {
        string input = Console.ReadLine();
        return input;
    }






}