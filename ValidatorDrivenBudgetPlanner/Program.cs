using System;
using System.ComponentModel;
using System.Net;
using System.Collections;
using System.Collections.Generic;

decimal income = 0m;
decimal expenses = 0m;
decimal totalExpenses = 0m;
List<decimal> incomeList = new List<decimal>();
List<decimal> expenseList = new List<decimal>();


//program start
handleChoice();

//display menu method
static void displayMenu()
{
    Console.WriteLine("Welcome to the Validator Driven Budget Planner!\nPlease select an option:\t\n1. Set Income\n2. Set expenses\n3. View Budget Summary\n4. Remove Expense\n5. Exit");
}

//get menu choice method to avoid using console readline in main method
static string getMenuChoice()
{
    Console.Write("Enter your choice (1-5): ");
    return Console.ReadLine().Trim();
}

static string getIncomeChoice()
{
    Console.Write("Enter your choice (1-2): ");
    return Console.ReadLine().Trim();
}


//handle choice method with built in error detection
void handleChoice()
{
    displayMenu();
    while (true)
    {
        string choice = getMenuChoice();
        switch (choice)
        {
            case "1":
                Console.WriteLine("Set Income selected.");
                //logic to set income
                SetIncome();
                string seelistofincomes = ReadYesOrNo("Would you like to see your list of incomes? (yes/no): ");
                if (seelistofincomes == "yes")
                {
                    ViewIncome();
                }
                else if (seelistofincomes == "no")
                {
                    string returnToMenu = returnToMenuOrExit();
                    if (returnToMenu == "yes")
                    {
                        displayMenu();
                    }
                    else if (returnToMenu == "no")
                    {
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    }
                }

            case "2":
                Console.WriteLine("Set Expenses selected.");
                //logic to set expenses
                SetExpenses();

                string seelistofexpenses = ReadYesOrNo("Would you like to see your list of expenses? (yes/no): ");

                if (seelistofexpenses == "yes")
                {
                    ViewExpenses();
                }
                else
                {
                    string backToMenu = returnToMenuOrExit();
                    if (backToMenu == "yes")
                    {
                        displayMenu();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    }
                }

            case "3":
                Console.WriteLine("View Budget Summary selected.");
                //logic to view budget summary
                ViewBudgetSummary();
                string goBackToMenu = returnToMenuOrExit();
                if (goBackToMenu == "yes")
                {
                    displayMenu();
                    continue;
                }
                else
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                }

            case "4":
                Console.WriteLine("Remove Expense selected.");
                //logic to remove expense
                RemoveExpense();

                string returnbackToMenu = ReadYesOrNo("Would you like to return to the main menu? (yes/no): ");
                if (returnbackToMenu == "yes")
                {
                    displayMenu();
                    continue;
                }
                else
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                }

            case "5":
                //exit program
                Console.WriteLine("Exiting the program. Goodbye!");
                return;

            default:
                //invalid choice handling
                InvalidChoice();
                continue;
        }
    }
}

decimal SetIncome()
{
    System.Console.WriteLine("Please enter your income amount:");

    //setting the validated input to income variable using the validation method
    decimal Validatedincome = ValidateDecimalInput();

    //letting user know the income has been set
    System.Console.WriteLine($"Income set to: {Validatedincome:C}");
    return Validatedincome;

}


void ViewIncome()
{
    System.Console.WriteLine("You have selected to view income\n1. View List of incomes \n2.View Total Income");
    string incomeChoice = getIncomeChoice();

    switch (incomeChoice)
    {
        case "1":
            System.Console.WriteLine("List of Incomes:");
            foreach (var inc in incomeList)
            {
                System.Console.WriteLine($"{inc:C}");
            }
            break;

        case "2":
            decimal totalIncome = 0m;
            foreach (var inc in incomeList)
            {
                totalIncome += inc;
            }
            System.Console.WriteLine($"Total Income: {totalIncome:C}");
            break;

        default:
            InvalidChoice();
            break;
    }

}

//method to set expenses with validation
decimal SetExpenses()
{
    //prompting user for their expense ammount
    System.Console.WriteLine("Please enter your expense amount:");

    //setting validated expenses by passing it to validation method
    decimal Validatedexpenses = ValidateDecimalInput();
    expenseList.Add(Validatedexpenses);

    //letting the user know the expenses have been set
    System.Console.WriteLine($"Expenses set to: {Validatedexpenses:C}");

    return Validatedexpenses;
}

decimal AddExpense()
{
    string addedexpense = Console.ReadLine();
    decimal validatedAddedExpense = ValidateDecimalInput();
    expenseList.Add(validatedAddedExpense);
    return validatedAddedExpense;
}

void ViewExpenses()
{
    if (expenseList.Count == 0)
    {
        System.Console.WriteLine("No expenses recorded.");
        return;
    }

    foreach (var expense in expenseList)
    {
        System.Console.WriteLine($"{expense:C}");
        totalExpenses += expense;
    }
    System.Console.WriteLine($"Total Expenses: {totalExpenses:C}");

}


//method to remove expenses that calls readyesorno for validation
decimal RemoveExpense()
{
    if (expenseList.Count == 0)
    {
        System.Console.WriteLine("No expenses to remove.");
        return 0m;
    }

    System.Console.WriteLine("Current expenses:");
    for (int i = 0; i < expenseList.Count; i++)
    {
        System.Console.WriteLine($"{i + 1}. {expenseList[i]:C}");
    }

    System.Console.Write("Enter the number of the expense to remove: ");
    string input = Console.ReadLine()?.Trim();

    if (int.TryParse(input, out int expenseIndex) && expenseIndex >= 1 && expenseIndex <= expenseList.Count)
    {
        decimal removedExpense = expenseList[expenseIndex - 1];
        expenseList.RemoveAt(expenseIndex - 1);
        System.Console.WriteLine($"Removed expense: {removedExpense:C}");
        return removedExpense;
    }
    else
    {
        System.Console.WriteLine("Invalid input. No expense removed.");
        return 0m;
    }
}

//method to read yes or no input with validation
string ReadYesOrNo(string prompt)
{
    while (true)
    {
        //passing prompt to user in the call to this method and using that prompt in this method
        Console.Write(prompt);

        //normalising string input
        string input = Console.ReadLine()?.Trim().ToLower();

        //checking for valid yes or no input
        if (input == "yes" || input == "no")
        {
            return input;
        }
        else
        {
            System.Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
        }
    }
}

//this just prints the invalid choice message
void InvalidChoice()
{
    System.Console.WriteLine("Invalid choice. Please try again.");
}


//this method validates the decimal input in setincome and setexpenses methods
//irealised that i was validating the input in both methods repetitively so i created this method
decimal ValidateDecimalInput()
{
    //taking user input as soon as running method since we prompt the user for input before calling this method
    string inputToValidate = Console.ReadLine()?.Trim();

    //running loop to keep prompting user to please enter valid input until they do so
    while (true)
    {
        //if returns boolean true if the input is a valid decimal
        if (decimal.TryParse(inputToValidate, out decimal defaultValueValidated))
        {
            if (defaultValueValidated < 0)
            {
                System.Console.WriteLine("Value cannot be negative. Please enter a valid number:");
                inputToValidate = Console.ReadLine()?.Trim();
                continue;
            }
            //if checks for null or empty or whitespace input
            else if (string.IsNullOrWhiteSpace(inputToValidate))
            {
                System.Console.WriteLine("Input cannot be empty or contain spaces. Please enter a valid number:");
                inputToValidate = Console.ReadLine()?.Trim();
                continue;
            }
            return defaultValueValidated;
        }
        //default case for any other invalid input
        else
        {
            System.Console.WriteLine("Invalid input. Please enter a valid number:");
            inputToValidate = Console.ReadLine()?.Trim();
            continue;
        }
    }
}

void ViewBudgetSummary()
{
    //lowk simple method to view the budget summary
    System.Console.WriteLine("this is the viewbudgetsummary method");
    System.Console.WriteLine($"Income: {income:C}");
    System.Console.WriteLine($"Expenses: {expenses:C}");
    System.Console.WriteLine($"Net Budget: {income - expenses:C}");

}

string returnToMenuOrExit()
{
    string returnToMenu = ReadYesOrNo("Do you want to return to the main menu? (yes/no): ");
    return returnToMenu;
}
