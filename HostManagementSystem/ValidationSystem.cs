public class ValidationSystem
{
    public ValidationSystem()
    {

    }

    public bool IPAddressValidation(string IpAddressInput)
    {
        string IpAddress = IpAddressInput;
        char[] ipArray = IpAddress.ToCharArray();

        if (ipArray.Any(c => char.IsLetter(c)))
        {
            System.Console.WriteLine("IP address can not contain letters");
            return false;
        }
        else if (string.IsNullOrWhiteSpace(IpAddress))
        {
            System.Console.WriteLine("IP address can not be null or blank");
            return false;
        }
        else if (IpAddress.Contains(" "))
        {
            System.Console.WriteLine("IP address can not contain spaces");
            return false;
        }
        else if (IpAddress.Split('.').Length != 4)
        {
            System.Console.WriteLine("IP address must contain 4 octets");
            return false;
        }
        else if (!IpAddress.All(c => char.IsDigit(c) || c == '.'))
        {
            System.Console.WriteLine("IP address can only contain digits and dots");
            return false;
        }
        else if (!System.Net.IPAddress.TryParse(IpAddress, out _))
        {
            System.Console.WriteLine("IP address is not valid");
            return false;
        }
        else if (IpAddress.Length > 15)
        {
            System.Console.WriteLine("IP address can not be longer than 15 characters");
            return false;
        }
        else
        {
            System.Console.WriteLine("IP address is valid");
            return true;
        }
    }


    public bool PasswordValidation(string PasswordInput)
    {
        string Password = PasswordInput;
        char[] passwordArray = Password.ToCharArray();

        if (passwordArray.Length < 8)
        {
            System.Console.WriteLine("Password must be at least 8 characters long");
            return false;
        }
        else if (string.IsNullOrWhiteSpace(Password))
        {
            System.Console.WriteLine("Password can not be null or blank");
            return false;
        }
        else if (Password.Contains(" "))
        {
            System.Console.WriteLine("Password can not contain spaces");
            return false;
        }
        else if (Password.Length > 15)
        {
            System.Console.WriteLine("Password can not be longer than 15 characters");
            return false;
        }
        else if (!passwordArray.Any(c => char.IsUpper(c)))
        {
            System.Console.WriteLine("Password must contain at least one uppercase letter");
            return false;
        }
        else if (!passwordArray.Any(c => char.IsLower(c)))
        {
            System.Console.WriteLine("Password must contain at least one lowercase letter");
            return false;
        }
        else if (!passwordArray.Any(c => char.IsDigit(c)))
        {
            System.Console.WriteLine("Password must contain at least one number");
            return false;
        }
        else if (!passwordArray.Any(c => char.IsLetter(c)) || !passwordArray.Any(c => char.IsDigit(c)))
        {
            System.Console.WriteLine("Password must contain at least one special character");
            return false;
        }
        else
        {
            System.Console.WriteLine("Password is valid");
            return true;
        }
    }

    public bool UsernameValidation(string UsernameInput)
    {
        string Username = UsernameInput;
        char[] usernameArray = Username.ToCharArray();

        if (usernameArray.Length < 5)
        {
            System.Console.WriteLine("Username must be at least 5 characters long");
            return false;
        }
        else if (string.IsNullOrWhiteSpace(Username))
        {
            System.Console.WriteLine("Username can not be null or blank");
            return false;
        }
        else if (Username.Contains(" "))
        {
            System.Console.WriteLine("Username can not contain spaces");
            return false;
        }
        else if (Username.Length > 15)
        {
            System.Console.WriteLine("Username can not be longer than 15 characters");
            return false;
        }
        else if (!usernameArray.All(c => char.IsLetterOrDigit(c)))
        {
            System.Console.WriteLine("Username can only contain letters and numbers");
            return false;
        }
        else
        {
            System.Console.WriteLine("Username is valid");
            return true;
        }
    }


    public bool HostNameValidation(string HostNameInput)
    {
        string HostName = HostNameInput;
        char[] hostnameArray = HostName.ToCharArray();

        if (hostnameArray.Length < 5)
        {
            System.Console.WriteLine("Host name must be at least 5 characters long");
            return false;
        }
        else if (string.IsNullOrWhiteSpace(HostName))
        {
            System.Console.WriteLine("Host name can not be null or blank");
            return false;
        }
        else if (HostName.Contains(" "))
        {
            System.Console.WriteLine("Host name can not contain spaces");
            return false;
        }
        else if (HostName.Length > 15)
        {
            System.Console.WriteLine("Host name can not be longer than 15 characters");
            return false;
        }
        else if (!hostnameArray.All(c => char.IsLetterOrDigit(c)))
        {
            System.Console.WriteLine("Host name can only contain letters and numbers");
            return false;
        }
        else
        {
            System.Console.WriteLine("Host name is valid");
            return true;
        }
    }



    public bool HostPasswordValidation(string HostPasswordInput)
    {
        string HostPassword = HostPasswordInput;
        char[] hostpasswordArray = HostPassword.ToCharArray();

        if (hostpasswordArray.Length < 8)
        {
            System.Console.WriteLine("Host password must be at least 8 characters long");
            return false;
        }
        else if (string.IsNullOrWhiteSpace(HostPassword))
        {
            System.Console.WriteLine("Host password can not be null or blank");
            return false;
        }
        else if (HostPassword.Contains(" "))
        {
            System.Console.WriteLine("Host password can not contain spaces");
            return false;
        }
        else if (HostPassword.Length > 15)
        {
            System.Console.WriteLine("Host password can not be longer than 15 characters");
            return false;
        }
        else if (!hostpasswordArray.Any(c => char.IsUpper(c)))
        {
            System.Console.WriteLine("Host password must contain at least one uppercase letter");
            return false;
        }
        else if (!hostpasswordArray.Any(c => char.IsLower(c)))
        {
            System.Console.WriteLine("Host password must contain at least one lowercase letter");
            return false;
        }
        else if (!hostpasswordArray.Any(c => char.IsDigit(c)))
        {
            System.Console.WriteLine("Host password must contain at least one number");
            return false;
        }
        else if (!hostpasswordArray.Any(c => char.IsLetter(c)) || !hostpasswordArray.Any(c => char.IsDigit(c)))
        {
            System.Console.WriteLine("Host password must contain at least one special character");
            return false;
        }
        else
        {
            System.Console.WriteLine("Host password is valid");
            return true;
        }
    }
}