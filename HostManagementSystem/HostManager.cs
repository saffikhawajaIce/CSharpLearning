using System.ComponentModel.DataAnnotations;
using System.Runtime.Versioning;

public class HostManager
{
    public TheDataHandlerBrother dataHandler;
    public ValidationSystem validator;

    public ProgramUI programUI = new ProgramUI();

    public HostManager(ValidationSystem validator, TheDataHandlerBrother dataHandler, ProgramUI programUI)
    {
        this.validator = validator;
        this.dataHandler = dataHandler;
        this.programUI = programUI;
    }


    public Host CreateNewHost()
    {
        programUI.DisplayCreateHostMenu();
        while (true)
        {

            System.Console.WriteLine("Please enter the username of the host owner: ");
            string username = programUI.GetStringInput();

            if (validator.UsernameValidation(username) == false)
            {
                Console.WriteLine("Please enter a valid username.");
                continue;
            }

            Console.WriteLine("Create New Host, Enter your Host name: ");
            string hostusername = programUI.GetStringInput();

            if (validator.HostNameValidation(hostusername) == false)
            {
                Console.WriteLine("Please enter a valid host name.");
                continue;
            }

            System.Console.WriteLine("Create a password for your host: ");
            string hostpassword = programUI.GetStringInput();


            if (validator.PasswordValidation(hostpassword) == false)
            {
                Console.WriteLine("Please enter a valid password.");
                continue;
            }

            System.Console.WriteLine("Enter the IP address of your host: ");
            string ipaddress = programUI.GetStringInput();

            if (validator.IPAddressValidation(ipaddress) == false)

            {
                Console.WriteLine("Please enter a valid IP address.");
                continue;
            }

            //i need to implement duplicate IPaddress verification to make sure user is not entering duplicate IP address.
            List<Host> hosts = dataHandler.LoadHostDataFromFile();
            if (hosts.Any(h => h.IPAddress == ipaddress))
            {
                Console.WriteLine("IP address already registered.");
                return null;
            }

            //creating a new host object to play around with by returning it 
            Host newHost = new Host(ipaddress, hostusername, hostpassword, username);
            Console.WriteLine("New host created successfully!");

            //displaying info to the user for correctness
            newHost.DisplayHostInfo();

            //updating text file with this new information
            dataHandler.AddHostInformation(ipaddress, hostusername, hostpassword, username);

            return newHost;
        }
    }

    public void UpdateHostInformation()
    {
        Console.WriteLine("Update Host Information");
        Thread.Sleep(200);

        programUI.DisplayUpdateHostMenu();
        Thread.Sleep(200);

        Console.WriteLine("Enter the IP address of the host you want to update: ");
        Thread.Sleep(200);

        string ipaddress = programUI.GetStringInput();
        if (validator.IPAddressValidation(ipaddress) == false)
        {
            Console.WriteLine("Please enter a valid IP address.");
            return;
        }
        //i need to check the database for the IPaddress of the host and then update that entry here using this method.

        List<Host> hostData = dataHandler.LoadHostDataFromFile();

        if (hostData.Count == 0)
        {
            Console.WriteLine("No hosts found in the database.");
            return;
        }

        else if (hostData.Count > 0)
        {
            Host hostToUpdate = hostData.FirstOrDefault(h => h.IPAddress == ipaddress);

            if (hostToUpdate == null)
            {
                Console.WriteLine("Host with the specified IP address not found.");
                return;
            }

            else
            {
                Console.WriteLine("Host information found:");
                hostToUpdate.DisplayHostInfo();

                //this is the updated information as you cant update the IPadress of the host
                System.Console.WriteLine("Enter the new username for the host: ");
                string newUsername = programUI.GetStringInput();
                if (validator.UsernameValidation(newUsername) == false)
                {
                    Console.WriteLine("Please enter a valid username.");
                    return;
                }


                System.Console.WriteLine("Enter the new password for the host: ");
                string newPassword = programUI.GetStringInput();
                if (validator.PasswordValidation(newPassword) == false)
                {
                    Console.WriteLine("Please enter a valid password.");
                    return;
                }

                // Update the host information in the database
                dataHandler.UpdateHostInformation(ipaddress, newUsername, newPassword, hostToUpdate.Owner);
                Console.WriteLine("Host information updated successfully!");
            }

        }
    }

    public void DeleteHostFromFile(string ipaddress, TheDataHandlerBrother datahandler)
    {
        //first i will load the list of hosts from the file to start to manipulate them
        List<Host> hostData = dataHandler.LoadHostDataFromFile();

        if (hostData.Count == 0)
        {
            Console.WriteLine("No hosts found in the database.");
            return;
        }
        else if (hostData.Count > 0)
        {
            Host hostToDelete = hostData.FirstOrDefault(h => h.IPAddress == ipaddress);

            if (hostToDelete == null)
            {
                Console.WriteLine("Host with the specified IP address not found.");
                return;
            }

            else
            {
                // Delete the host from the database
                datahandler.DeleteHostFromFile(ipaddress, datahandler);
                Console.WriteLine("Host deleted successfully!");
            }
        }
    }

    public void ViewHostInformationByOwnername(string ownername)
    {
        //first i will load the list of hosts from the file to start to manipulate them
        List<Host> hostData = dataHandler.LoadHostDataFromFile();

        if (hostData.Count == 0)
        {
            Console.WriteLine("No hosts found in the database.");
            return;
        }
        else if (hostData.Count > 0)
        {
            Host hostToView = hostData.FirstOrDefault(h => h.Owner == ownername);

            if (hostToView == null)
            {
                Console.WriteLine("Host with the specified owner name not found.");
                return;
            }

            else
            {
                Console.WriteLine("Host information found:");
                hostToView.DisplayHostInfo();
            }
        }

    }

}
