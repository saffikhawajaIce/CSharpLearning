// See https://aka.ms/new-console-template for more information
using System.Runtime;
using System;
using System.Linq.Expressions;
using System.Net;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Globalization;

// Random random = new Random();
// int targetNum = random.Next(1,21);

// int ammountOfTries = 0;
// bool guessed = false;
// while (guessed == false) {

// System.Console.WriteLine("Guess my number between 1 and 20, ill give you hints if you're lower or higher than the number");
// int guess = int.Parse(Console.ReadLine());

// if (guess < targetNum)
// {
//     System.Console.WriteLine("your number is too low");
//     ammountOfTries++;
//   continue;
// }
// else if (guess > targetNum)
// {
//     System.Console.WriteLine("your number is too high");
//     ammountOfTries++;
//   continue;
// }
// else if (guess == targetNum)
// {
//     System.Console.WriteLine("your guess was the target number!");
//     ammountOfTries++;
//     System.Console.WriteLine($"it took you {ammountOfTries} tries ");
//     guessed = true;
// }
// }

//Basic Calculator
// System.Console.WriteLine("Enter your first number");
// int num1 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter your second number");
// int num2 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("what operation do you want to perfom?\nType + for addition\nType - for subtraction\nType * for multiplication\nType / for division");
// string input = Console.ReadLine();
// bool looper = false;

// while (looper == false)
// {
//     if (input.Equals("+"))
//     {
//         int sum = num1 + num2;
//         System.Console.WriteLine($"The sum of the numbers {num1} and {num2} is {sum}");
//         break;
//     }
//     else if (input.Equals("-"))
//     {
//         int subtract = num1 - num2;
//         System.Console.WriteLine($"The difference of the numbers {num1} and {num2} is {subtract}");
//         break;
//     }
//     else if (input.Equals("*"))
//     {
//         int multiply = num1 * num2;
//         System.Console.WriteLine($"The product of the numbers {num1} and {num2} is {multiply}");
//         break;
//     }
//     else if (input.Equals("/"))
//     {
//         int divide = num1 / num2;
//         System.Console.WriteLine($"The quotient of the numbers {num1} and {num2} is {divide}");
//         break;
//     }
//     else
//     {
//         System.Console.WriteLine("Invalid input, please enter a valid operation (+, -, *, /)");
//         input = Console.ReadLine();
//     }
// }

// Random oddoreven = new Random();
// int number = oddoreven.Next(1, 101);
// bool bruh = false;
// while (bruh == false)
// {
// System.Console.WriteLine("guess weather the number i have selected is odd or even");
// string numberguess = Console.ReadLine();
// if (numberguess.Equals("even"))
// {
//     if ((number % 2) == 0)
// {
//     System.Console.WriteLine("you were correct!");
//     break;
// }
// else
//     {
//         System.Console.WriteLine("wrong, try again!");
//         continue;
//     }
// }
// else if (numberguess.Equals("odd"))
// {
//     if ((number % 2) != 0)
// {
//     System.Console.WriteLine("you were correct!");
//     break;
// }
// else
//     {
//         System.Console.WriteLine("wrong, try again!");
//         continue;
//     }
// }
// else
// {
//     System.Console.WriteLine("invalid input, please type odd or even");
//     continue;
// }
// }

// password retry system 
// string hardcodedpassword = "thisisthepassword";
// int numberOfTries = 0;
// System.Console.WriteLine("guess the password i have written for my system muhehehe!");
// while (numberOfTries < 3)
// {
//     string userInput = Console.ReadLine() ?? "";

//     if (userInput.Equals(hardcodedpassword))
//     {
//         System.Console.WriteLine("you have guessed the password correctly!");
//         break;
//     }
//     else if (!userInput.Equals(hardcodedpassword))
//     {
//         System.Console.WriteLine("your password guess was FALSE HAHAHA TRY AGAIN LOLOLOL");
//         numberOfTries ++;
//         if (numberOfTries == 3)
//     {
//         System.Console.WriteLine("YOU HAVE BEEN LOCKED OUT!!");
//     }
//         continue;
//     }

// }

// simple age category sorter
// System.Console.WriteLine("enter your age mister user");
// int userAge;
// bool success = int.TryParse(Console.ReadLine(), out userAge);
// if (userAge < 0)
// {
//     System.Console.WriteLine("that is not a real age bruh");
// }
// else if (userAge > 0 && userAge < 5)
// {   
//     System.Console.WriteLine("you are a baby bruh");
// }
// else if (userAge > 5 && userAge < 12)
// {
//     System.Console.WriteLine("you are a child bruh");
// }
// else if (userAge > 12 && userAge < 20 )
// {
//     System.Console.WriteLine("you are a teenager bruh");
// }
// else if (userAge > 20 && userAge < 35)
// {
//     System.Console.WriteLine("you are a young adult bruh");
// }
// else if (userAge > 35 && userAge < 50)
// {
//     System.Console.WriteLine("you are a grown adult bruh");
// }
// else if (userAge > 50 && userAge < 120)
// {
//     System.Console.WriteLine("holy old man bruh");
// }
// else if (userAge > 120)
// {
//     System.Console.WriteLine(" thats simply not possible");
// }





// rock paper scissors game

// int userscore = 0;
// int computerScore = 0;
// int drawcount = 0;

// Random throwRoll = new Random();
// string[] computerchoices = {"rock","paper","scissors"};

// System.Console.WriteLine("lets play a game of rock paper scissors homer\nI will pick randomly between rock paper and scissors, and you should also pick between rock paper and scissors.\ni will only print what i throw after you do, but i will always pick randomly.\nyour score will increase if you beat me, and my score will increase when i beat you.\nare you ready?\nType yes to begin or no to end program!");
// string gameInput = Console.ReadLine().Trim().ToLower();
// while (true)
// {
//     int roll = throwRoll.Next(3);
//     string computerchoice = computerchoices[roll];
//   if (gameInput=="yes")
//     {
//         System.Console.WriteLine("alright lets begin!");
//         System.Console.WriteLine("Rock! Paper! Scissorss! Throw!!");
//         gameInput = Console.ReadLine().Trim().ToLower();

//         if ((gameInput == "rock") && (computerchoice == "paper"))
//         {
//             computerScore++;
//             System.Console.WriteLine($"you lose! I picked {computerchoice} and you picked {gameInput}, {computerchoice} beats {gameInput} so i win!");
//             System.Console.WriteLine("do you want to try again?");
//             gameInput = Console.ReadLine().Trim().ToLower();
//             if (gameInput == "yes"){continue;}
//             else if (gameInput == "no") {break;}
//         }
//         else if ((gameInput == "paper") && ( computerchoice == "scissors"))
//         {
//             computerScore++;
//             System.Console.WriteLine($"you lose! I picked {computerchoice} and you picked {gameInput}, {computerchoice} beats {gameInput} so i win!");
//             System.Console.WriteLine("do you want to try again?");
//             gameInput = Console.ReadLine().Trim().ToLower();
//             if (gameInput == "yes"){continue;}
//             else if (gameInput == "no") {break;}
//         }
//         else if ((gameInput=="scissors") && (computerchoice == "rock"))
//         {
//             computerScore++;
//             System.Console.WriteLine($"you lose! I picked {computerchoice} and you picked {gameInput}, {computerchoice} beats {gameInput} so i win!");
//             System.Console.WriteLine("do you want to try again?");
//             gameInput = Console.ReadLine().Trim().ToLower();
//             if (gameInput == "yes"){continue;}
//             else if (gameInput == "no") {break;}
//         }
//         else if ((gameInput=="rock" )&& (computerchoice == "scissors"))
//         {
//             userscore++;
//             System.Console.WriteLine($"you win! i picked {computerchoice} and you picked {gameInput}, So you have beaten me!");
//             System.Console.WriteLine("do you want to play me again?");
//             gameInput = Console.ReadLine().Trim().ToLower();
//             if (gameInput == "yes"){continue;}
//             else if (gameInput == "no") {break;}
//         }

//         else if ((gameInput=="paper" )&& (computerchoice == "rock"))
//         {
//             userscore++;
//             System.Console.WriteLine($"you win! i picked {computerchoice} and you picked {gameInput}, So you have beaten me!");
//             System.Console.WriteLine("do you want to play me again?");
//             gameInput = Console.ReadLine().Trim().ToLower();
//             if (gameInput == "yes"){continue;}
//             else if (gameInput == "no") {break;}
//         }
//         else if ((gameInput=="scissors" )&& (computerchoice == "paper"))
//         {
//             userscore++;
//             System.Console.WriteLine($"you win! i picked {computerchoice} and you picked {gameInput}, So you have beaten me!");
//             System.Console.WriteLine("do you want to play me again?");
//             gameInput = Console.ReadLine().Trim().ToLower();
//             if (gameInput == "yes"){continue;}
//             else if (gameInput == "no") {break;}
//         }
//         else if (gameInput == computerchoice && (gameInput == "rock" || gameInput == "paper" || gameInput == "scissors"))
//         {
//             drawcount++;
//             System.Console.WriteLine($"we have made a draw! you picked {gameInput} and i picked {computerchoice}!");
//             System.Console.WriteLine("do you want to play me again?");
//             gameInput = Console.ReadLine().Trim().ToLower();
//             if (gameInput == "yes"){continue;}
//             else if (gameInput == "no") {break;}
//         }
//     }  
//     else if (gameInput=="no")
//         {
//             System.Console.WriteLine("alright then, goodbye!");
//             break;
//         }
//         else
//         {
//             System.Console.WriteLine("invalid input, please type yes or no");
//             gameInput = Console.ReadLine().Trim().ToLower();
//         }
// }



// multiplication table generator
// System.Console.WriteLine("input the number you want to see the times table of");
// int userinput = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Till what number do you want the table to?");
// int userpreferance = int.Parse(Console.ReadLine());

// for (int i = 0; i <= userpreferance; i++)
// {
//     int answer = userinput* i;
//     System.Console.WriteLine($"Result at {i} = {answer}");
// }

//ATM simulator
// decimal accountBalance = 1000.00m;
// while (true)
// {
//     System.Console.WriteLine("Welcome to the ATM Simulator!\nPlease choose an option:\n1. Check Balance\n2. Deposit Funds\n3. Withdraw Funds\n4. Exit");
//     string userChoice = Console.ReadLine();

//     if (userChoice == "1")
//     {
//         System.Console.WriteLine($"Your current balance is: ${accountBalance}");
//     }
//     else if (userChoice == "2")
//     {
//         System.Console.WriteLine("Enter the amount to deposit:");
//         decimal depositAmount = decimal.Parse(Console.ReadLine());
//         if (depositAmount > 0)
//         {
//             accountBalance += depositAmount;
//             System.Console.WriteLine($"Successfully deposited ${depositAmount}. New balance: ${accountBalance}");
//         }
//         else
//         {
//             System.Console.WriteLine("Invalid deposit amount.");
//         }
//     }
//     else if (userChoice == "3")
//     {
//         System.Console.WriteLine("Enter the amount to withdraw:");
//         decimal withdrawAmount = decimal.Parse(Console.ReadLine());
//         if (withdrawAmount > 0 && withdrawAmount <= accountBalance)
//         {
//             accountBalance -= withdrawAmount;
//             System.Console.WriteLine($"Successfully withdrew ${withdrawAmount}. New balance: ${accountBalance}");
//         }
//         else
//         {
//             System.Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
//         }
//     }
//     else if (userChoice == "4")
//     {
//         System.Console.WriteLine("Thank you for using the ATM Simulator. Goodbye!");
//         break;
//     }
//     else
//     {
//         System.Console.WriteLine("Invalid option, please try again.");
//     }
// }

//calculator with try catch finally exception handling

// System.Console.WriteLine("Please enter your first number");
// try
// {
//     int number1 = int.Parse(Console.ReadLine());
// }
// catch(FormatException)
// {
//     System.Console.WriteLine("you did not enter a number, try again.");
// }

// System.Console.WriteLine("please enter your second number");
// try
// {
//     int number2 = int.Parse(Console.ReadLine());
// }
// catch (FormatException)
// {
//     System.Console.WriteLine("you did not enter a number, try again.");
// }


//ATM Pin logic
// decimal defaultBalance = 1000.00m;
// int defaultPIN = 1234;

// while (true)
// {   
//     int userinputPINnumber; 

// System.Console.WriteLine("Please enter your ATM pin:");
// string input = Console.ReadLine();
// //Trying to parse input as integer and not random string or character or null
// if (int.TryParse(input, out userinputPINnumber))
//     {   
//         //checking for input matching default pin
//         if (userinputPINnumber != defaultPIN || input.Length != 4 || userinputPINnumber < 0 || userinputPINnumber > 9999 || input.Contains(" ") || input == null || input == "")
//         {
//         System.Console.WriteLine("your pin is invalid");
//         }
//         else
//         {
//             //main code logic 
//         System.Console.WriteLine("Welcome to XYZ ATM.\n1.View Balance\n2.Withdraw Ammount\n3.Change PIN\n4.Logout");
//         input = Console.ReadLine();

//         //checking if user inputs something other than 4 menu options
//         if ((input != "1") && (input != "2") && (input != "3") && (input != "4"))
//         {
//             System.Console.WriteLine("invalid input, please try again.");
//         }   
//         else
//         {
//             switch (input)
//             {
//                 case "1": //View Balance Logic
//                 System.Console.WriteLine($"Your current balance is: ${defaultBalance}");
//                 break;
//                 case "2": //Withdraw Ammount Logic
//                 System.Console.WriteLine("Enter the amount to withdraw:");
//                 decimal withdrawAmount = decimal.TryParse(Console.ReadLine(), out decimal parsedWithdrawAmount) ? parsedWithdrawAmount : 0;
//                 if (withdrawAmount > 0 && withdrawAmount <= defaultBalance)
//                 {
//                     defaultBalance -= withdrawAmount;
//                     System.Console.WriteLine($"Successfully withdrew ${withdrawAmount}. New balance: ${defaultBalance}");
//                 }
//                 else
//                 {
//                     System.Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
//                 }
//                 break;
//                 case "3": //Change PIN Logic
//                 System.Console.WriteLine("Enter your new PIN:");

//                 if (int.TryParse(Console.ReadLine(), out int newPIN))
//                 {
//                     defaultPIN = newPIN;
//                     System.Console.WriteLine("Your PIN has been successfully changed.");
//                 }
//                 else
//                 {
//                     System.Console.WriteLine("Invalid PIN format. PIN change failed.");
//                 }

//                 break;
//                 case "4": //Logout Logic
//                 System.Console.WriteLine("Thank you for using XYZ ATM. Goodbye!");
//                 return;

//             }
//         }
//         }
//     }
//     //invalid PIN input by user
// else
//     {
//         Console.WriteLine("Invalid number. Try again.");
//     }
// }

//record input simulator
// string username = "";
// int age = 0;
// decimal balance = 0.0m;


// System.Console.WriteLine("Welcome to the record Input Simulator!\nPlease enter in the following Details: ");
// System.Console.WriteLine("First name, Age and your Bank account Balance. Please make sure your input is in the following format: \nJohn, 23, 3000.00");
// System.Console.WriteLine("You may quit the program at any time by typing 'Quit' ");

// //main loop
// while (true)
// {
// string userinformation = Console.ReadLine().Trim().ToLower();
// //validation logic

// if (string.IsNullOrWhiteSpace(userinformation) || userinformation.Length == 0 )
// {
//     System.Console.WriteLine("Input cannot be empty. Please enter valid information.");
//     continue;
// }

// if (!userinformation.Contains(",") || userinformation.Split(",").Length != 3)
// {
//     System.Console.WriteLine("Invalid format. Please enter your information in the format: Name, Age, Balance");
//     continue;
// }

// if (!int.TryParse(userinformation.Split(",")[1].Trim(), out int parsedAge) || parsedAge < 0)
// {
//     System.Console.WriteLine("Invalid age. Please enter a valid non-negative integer for age.");
//     continue;
// }
// if (!decimal.TryParse(userinformation.Split(",")[2].Trim(), out decimal parsedBalance) || parsedBalance < 0)
// {
//     System.Console.WriteLine("Invalid balance. Please enter a valid non-negative number for balance.");
//     continue;
// }

// //formatting logic
// string [] tempArray = userinformation.Split(",");
// username = tempArray[0];
// age = int.Parse(tempArray[1]);
// balance = decimal.Parse(tempArray[2]);
// System.Console.WriteLine($"Record Created Successfully!\nName: {username}\nAge: {age}\nBalance: ${balance}");
// System.Console.WriteLine("----------------------------------------\nYou may enter another record or type 'Quit' to exit the program.");

// //quit logic
// if (userinformation.Contains("quit"))
// {
//     System.Console.WriteLine("Thankyou for using our program!");
// }
// }


// Password Validator
string defaultpassword = "basicP@ssword1!";
string newaccount = "";

System.Console.WriteLine("Welcome to the Password Validator!\nIf you are new please press n for New Password\nIf you already have an existing account please press l to login!\nIf you want to end the program at any time please type quit or exit!");
//main loop
while (true)
{
    string userinput = Console.ReadLine().Trim().ToLower();

    //checking for null or empty input
    if (string.IsNullOrEmpty(userinput))
    {
        System.Console.WriteLine("Invalid input, please try again.");
        continue;
    }

    //checking for valid input
    if (!userinput.Equals("n") && !userinput.Equals("l") && !userinput.Equals("quit") && !userinput.Equals("exit"))
    {
        System.Console.WriteLine("invalid input, please try again.");
        continue;
    }

    //checking for when the user whats to quit or exit
    if (userinput.Equals("quit") || userinput.Equals("exit"))
            {
                System.Console.WriteLine("Thankyou for using the Password Validation System!");
                return;
            }

    if (userinput.Equals("n"))
    {
        System.Console.WriteLine("Create new password\nPlease enter your new password.\nPlease ensure that the password meets the following requirements.");

        //calling method to display the password requirement information
        passwordrequirementsDisplay();

        while (true)
        {
            string userpasswordInput = Console.ReadLine().Trim();
                if (userpasswordInput.Equals("quit") || userpasswordInput.Equals("exit"))
                {
                System.Console.WriteLine("Thankyou for using the Password Validation System!");
                return;
                }
                //checking if the input is null or empty because cmon bro
                if (string.IsNullOrEmpty(userpasswordInput))
                {
                    System.Console.WriteLine("The Password you have entered can not be empty or null. Please try again.");
                    continue;
                }

                //password validation checking system:
                if (userpasswordInput.Length > 40 || userpasswordInput.Length < 8)
                {
                    System.Console.WriteLine("Your password is too short or too long, please type your password again.");
                    continue;
                }

                //splitting string into character array for looping for validation checks
                char[] splitupuserpasswordinput = userpasswordInput.ToCharArray();

                //checking for whitespace
                bool containsSpace = false;
                foreach (char characterinArray5 in splitupuserpasswordinput)
                {
                    if (char.IsWhiteSpace(characterinArray5))
                    {
                        containsSpace = true;
                        break;
                    }

                }

                if (containsSpace == true)
                {
                    System.Console.WriteLine("The password you have entered can not contain whitespace.\nPlease try again.");
                    continue;
                }

                //checking for lowercase
                bool foundLowercase = false;
                foreach (char characterinArray in splitupuserpasswordinput)
                {
                    if (char.IsLower(characterinArray))
                    {
                        foundLowercase = true;
                        break;
                    }
                }

                if (foundLowercase == false)
                {
                    System.Console.WriteLine("The Password you have entered does not contain any lowercase letters.\nPlease try again.");
                    continue;
                }

                //checking for uppercase
                bool foundUppercase = false;
                foreach (char characterinArray2 in splitupuserpasswordinput)
                {
                    if (char.IsUpper(characterinArray2))
                    {
                        foundUppercase = true;
                        break;
                    }
                }
                if (foundUppercase == false)
                {
                    System.Console.WriteLine("The Password you have entered does not contain any uppercase letters.\nPlease try again.");
                    continue;
                }

                //checking for digits 
                bool foundDigit = false;
                foreach (char characterinArray3 in splitupuserpasswordinput)
                {
                    if (char.IsDigit(characterinArray3))
                    {
                        foundDigit = true;
                        break;
                    }
                }
                if (foundDigit == false)
                {
                    System.Console.WriteLine("The Password you have entered does not contain any digits.\nPlease try again.");
                    continue;
                }

                //checking for special characters
                bool foundSpecial = false;
                foreach (char characterinArray4 in splitupuserpasswordinput)
                {
                    if (!char.IsLetterOrDigit(characterinArray4))
                    {
                        foundSpecial = true;
                        break;
                    }
                }

                if (foundSpecial == false)
                {
                    System.Console.WriteLine("The password you have entered does not contain any special characters.\nPlease try again.");
                    continue;
                }

                System.Console.WriteLine("Your password has been created successfully!");
                newaccount = userpasswordInput;
                System.Console.WriteLine("Thankyou for using the Password Validation System!");
                System.Console.WriteLine("Would you like to start over? Type n for new password, l for login or quit/exit to end program.");
                //userpasswordInput = Console.ReadLine().Trim().ToLower();

                // //final validation check
                // if (foundLowercase == true && foundUppercase == true && foundDigit == true && foundSpecial == true && containsSpace == false)
                // {
                //     System.Console.WriteLine("Your password has been created successfully!");
                //     newaccount = userpasswordInput;
                //     System.Console.WriteLine("Thankyou for using the Password Validation System!");
                //     System.Console.WriteLine("Would you like to start over? Type n for new password, l for login or quit/exit to end program.");
                //     //userpasswordInput = Console.ReadLine().Trim().ToLower();
                //     continue;
                // }

            //login system
            if (userinput.Equals("l"))
            {
                System.Console.WriteLine("Great! Please enter your login password!");
                string userloginpasswordinput = Console.ReadLine().Trim();
                //checking for null or empty input
                if (string.IsNullOrEmpty(userloginpasswordinput))
                {
                    System.Console.WriteLine("The Password you have entered can not be empty or null. Please try again.");
                    continue;
                }
                //checking for correct password
                if (userloginpasswordinput.Equals(defaultpassword) || userloginpasswordinput.Equals(newaccount))
                {
                    System.Console.WriteLine("Login Successful! Welcome back!");
                    System.Console.WriteLine("Thankyou for using the Password Validation System!");
                    System.Console.WriteLine("Would you like to start over? Type n for new password, l for login or quit/exit to end program.");
                    userinput = Console.ReadLine().Trim().ToLower();
                    continue;
                }
                else
                {
                    System.Console.WriteLine("Login Failed! Incorrect Password.\nPlease try again.");
                    userinput = Console.ReadLine().Trim().ToLower();
                    continue;
                }
            }
        }
    }
}

//method to display password requirement information
static void passwordrequirementsDisplay()
{
    System.Console.WriteLine("Password must contain atleast one uppercase letter.\nPassword must contain atleast one lowercase letter\nPassword must contain atleast one number\nPassword must contain atleast one special character\nPassword must be between 8 and 40 characters long.");
}

