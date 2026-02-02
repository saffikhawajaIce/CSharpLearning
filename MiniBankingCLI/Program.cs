// See https://aka.ms/new-console-template for more information
// Bank account mini using classes and methods
// methods: Deposit(amount), Withdraw(amount), GetBalance(), PrintSummary()

decimal totalBalance = 1000.0m;
decimal userwithdrawAmountnumber = 0.0m;
decimal userdepositAmountnumber = 0.0m;

//main loop
MenuPrint();
while (true)
{
    string userInput1 = Console.ReadLine().Trim().ToLower();

    //main input validations
    if (string.IsNullOrWhiteSpace(userInput1))
    {
        InvalidInputMessagePrint();
        continue;
    }

    if (!userInput1.Equals("1") && !userInput1.Equals("2") && !userInput1.Equals("3") && !userInput1.Equals("q") )
    {
        InvalidInputMessagePrint();
        continue;
    }

    //Deposit logic
    else if (userInput1.Equals("1"))
    {
        //deposit loop
        while (true)
        {
            System.Console.WriteLine("Please Enter the Amount you'd like to deposit.");
            string userdepositAmount = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userdepositAmount))
            {
                InvalidInputMessagePrint();
                continue;
            }

            //parse string value into decimal value if its not invalid
            bool sucess = decimal.TryParse(userdepositAmount, out userdepositAmountnumber);
            if (sucess == false)
            {
                InvalidInputMessagePrint();
                continue;
            }

            else if (userdepositAmountnumber < 0)
            {
                InvalidInputMessagePrint();
                continue;
            }

            DepositAmount(userdepositAmountnumber);
            System.Console.WriteLine($"Your new total balance is {totalBalance}");
            System.Console.WriteLine("Would you like to deposit more? Type Y for yes or N for no.");
            string userdepositmore = Console.ReadLine().Trim().ToLower();
            if (userdepositmore.Equals("y"))
            {
                continue;
            }
            else if (userdepositmore.Equals("n"))
            {
                MenuPrint();
                break;
            }
            else
            {
                InvalidInputMessagePrint();
                continue;
            }
        }
    }

    //Withdraw Logic
    else if (userInput1.Equals("2"))
        //withdraw loop
        while (true)
        {
            {
                System.Console.WriteLine("Please enter the Amount you would like to withdraw:");
                string userwithdrawAmount = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userwithdrawAmount))
                {
                    InvalidInputMessagePrint();
                    continue;
                }

                //parse string value into decimal value if its not invalid
                bool success = decimal.TryParse(userwithdrawAmount, out userwithdrawAmountnumber);
                if (success == false)
                {
                    InvalidInputMessagePrint();
                    continue;
                }

                if (userwithdrawAmountnumber < 0)
                {
                    InvalidInputMessagePrint();
                    continue;
                }

                else if (userwithdrawAmountnumber > totalBalance)
                {
                    System.Console.WriteLine("The Withdrawal Amount you have entered exceeds your total balance, please try again.");
                    continue;
                }

                WithdrawAmount(userwithdrawAmountnumber);
                System.Console.WriteLine($"Your new total balance is {totalBalance}");
                System.Console.WriteLine("Would you like to withdraw more? Type Y for yes or N for no.");
                string userwithdrawmore = Console.ReadLine().Trim().ToLower();
                if (userwithdrawmore.Equals("y"))
                {
                    continue;
                }
                else if (userwithdrawmore.Equals("n"))
                {
                    MenuPrint();
                    break;
                }
                else
                {
                    InvalidInputMessagePrint();
                    continue;
                }
            }
        }

    //Show Balance
    else if (userInput1.Equals("3"))
    {
        ShowBalance(totalBalance);
        continue;
    }

    //User wants to Quit
    else if (userInput1.Equals("q"))
    {
        System.Console.WriteLine("Thankyou for using this program!");
        return;
    }
}


static void InvalidInputMessagePrint()
{
    System.Console.WriteLine("your input was invalid, please try again.");
}


static void MenuPrint()
{
    System.Console.WriteLine("welcome to my mini banking application!\n1:\tDeposit Amount\n2:\tWithdraw Amount\n3:\tShow Balance\nIf at any moment you'd like to quit the program please press Q");
}


 decimal DepositAmount(decimal userdepositAmount)
{
    totalBalance += userdepositAmount;
    return totalBalance;
}


 decimal WithdrawAmount(decimal userwithdrawAmount)
{
    totalBalance -= userwithdrawAmount;
    return totalBalance;
}


static void ShowBalance(decimal totalBalance)
{
    System.Console.WriteLine($"Your total Balance is: {totalBalance}");
}



// decimal totalBalance = 1000m;

// MenuPrint();

// while (true)
// {
//     var choice = Console.ReadLine()?.Trim().ToLower();

//     if (string.IsNullOrWhiteSpace(choice))
//     {
//         InvalidInputMessagePrint();
//         continue;
//     }

//     if (choice == "1")
//     {
//         totalBalance = RunDepositFlow(totalBalance);
//         MenuPrint();
//     }
//     else if (choice == "2")
//     {
//         totalBalance = RunWithdrawFlow(totalBalance);
//         MenuPrint();
//     }
//     else if (choice == "3")
//     {
//         ShowBalance(totalBalance);
//     }
//     else if (choice == "q")
//     {
//         Console.WriteLine("Thankyou for using this program!");
//         break;
//     }
//     else
//     {
//         InvalidInputMessagePrint();
//     }
// }

// static decimal RunDepositFlow(decimal balance)
// {
//     while (true)
//     {
//         Console.WriteLine("Please Enter the Amount you'd like to deposit.");
//         var input = Console.ReadLine();

//         if (!TryGetPositiveAmount(input, out var amount))
//         {
//             InvalidInputMessagePrint();
//             continue;
//         }

//         balance += amount;
//         Console.WriteLine($"Your new total balance is {balance}");

//         if (!AskYesNo("Would you like to deposit more? Type Y for yes or N for no."))
//             return balance;
//     }
// }

// static decimal RunWithdrawFlow(decimal balance)
// {
//     while (true)
//     {
//         Console.WriteLine("Please enter the Amount you would like to withdraw:");
//         var input = Console.ReadLine();

//         if (!TryGetPositiveAmount(input, out var amount))
//         {
//             InvalidInputMessagePrint();
//             continue;
//         }

//         if (amount > balance)
//         {
//             Console.WriteLine("The Withdrawal Amount you have entered exceeds your total balance, please try again.");
//             continue;
//         }

//         balance -= amount;
//         Console.WriteLine($"Your new total balance is {balance}");

//         if (!AskYesNo("Would you like to withdraw more? Type Y for yes or N for no."))
//             return balance;
//     }
// }

// static bool TryGetPositiveAmount(string? input, out decimal amount)
// {
//     amount = 0m;

//     if (string.IsNullOrWhiteSpace(input))
//         return false;

//     if (!decimal.TryParse(input, out amount))
//         return false;

//     return amount > 0; // choose > 0 (recommended) or >= 0 depending on your rules
// }

// static bool AskYesNo(string prompt)
// {
//     while (true)
//     {
//         Console.WriteLine(prompt);
//         var answer = Console.ReadLine()?.Trim().ToLower();

//         if (answer == "y") return true;
//         if (answer == "n") return false;

//         InvalidInputMessagePrint();
//     }
// }
