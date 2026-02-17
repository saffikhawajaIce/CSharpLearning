using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

public class LoginManager
{
    private string username;
    private string password;
    public TheDataHandlerBrother dataHandler = new TheDataHandlerBrother();
    public ValidationSystem validator = new ValidationSystem();

    public ProgramUI programUI = new ProgramUI();

    public LoginManager(ValidationSystem validator, TheDataHandlerBrother dataHandler, ProgramUI programUI)
    {
        this.validator = validator;
        this.dataHandler = dataHandler;
        this.programUI = programUI;
    }



    public User CreateUserFromInput()
    {
        programUI.DisplayCreateAccountMenu();
        while (true)
        {
            //first ask for username and validate it 
            Console.WriteLine("Please enter your username: ");
            string username = programUI.GetStringInput();

            if (validator.UsernameValidation(username) == false)
            {
                Console.WriteLine("Please enter a valid username.");
                continue;
            }

            //then ask for password and validate it

            Console.WriteLine("Please enter your password: ");
            string password = programUI.GetStringInput();

            if (validator.PasswordValidation(password) == false)
            {
                Console.WriteLine("Please enter a valid password.");
                continue;
            }

            //then create a user object and save the username and password to a file
            Console.WriteLine("User created successfully!");

            User user = new User(username, password);
            dataHandler.AddUserAuthInfoToFile(username, password);
            return user;
        }
    }


    public bool Login(string username, string password)
    {
        //first load the data from the file and check if the username and password match any of the entries
        Dictionary<string, string> userData = dataHandler.LoadUserDataFromFile();

        //then check if the username and password match any of the entries

        if (!userData.ContainsKey(username) || userData[username] != password)
        {
            Console.WriteLine("Invalid username or password.");
            return false;
        }
        else if (userData.ContainsKey(username) && userData[username] == password)
        {
            Console.WriteLine("Login successful!");
            return true;
        }
        else
        {
            System.Console.WriteLine("Invalid username or password.");
            return false;
        }
    }
}