using System.IO;
public class TheRealestClassLOL
{
    public static void Main(string[] args)
    {
        TheDataHandlerBrother dataHandler = new TheDataHandlerBrother();
        ProgramUI programUI = new ProgramUI();
        ValidationSystem validator = new ValidationSystem();
        LoginManager loginManager = new LoginManager(validator, dataHandler, programUI);
        HostManager hostManager = new HostManager(validator, dataHandler, programUI);


        programUI.DisplayMainMenu();
        int choice = programUI.GetMnenuChoiceInput();
        while (true)
        {
            if (choice == 1)
            {
                System.Console.WriteLine("Please enter your username: ");
                string username = programUI.GetStringInput();
                System.Console.WriteLine("Please enter your password: ");
                string password = programUI.GetStringInput();

                if (loginManager.Login(username, password) == false)
                {
                    System.Console.WriteLine("Login failed. Please try again.");
                }

                else
                {
                    System.Console.WriteLine("Login successful! Welcome to the Host Management System.");
                    //here i will call the method that displays the host management menu and allows user to manipulate host information
                    hostManager.CreateNewHost();
                }
            }
            else if (choice == 2)
            {
                loginManager.CreateUserFromInput();
            }
            else if (choice == 3)
            {
                programUI.DisplayExitMessage();
                break;
            }
            else
            {
                System.Console.WriteLine("Invalid choice. Please try again.");
            }
            programUI.DisplayMainMenu();
            choice = programUI.GetMnenuChoiceInput();
        }

    }
}