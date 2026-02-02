// See https://aka.ms/new-console-template for more information
// namespace PasswordValidationSystem

using System;
// class RockPaperScissorsGame
// {
//     private int userScore = 0;
//     private int computerScore = 0;
//     private int drawCount = 0;
//     private Random random = new Random();
//     private readonly string[] choices = { "rock", "paper", "scissors" };
    
//     static void Main(string[] args)
//     {
//         RockPaperScissorsGame game = new RockPaperScissorsGame();
//         game.Start();
//     }
    
//     public void Start()
//     {
//         DisplayWelcome();
        
//         if (!GetYesNo("Are you ready to play?"))
//         {
//             Console.WriteLine("\n👋 Maybe next time! Goodbye!");
//             return;
//         }
        
//         Console.WriteLine("\n🎮 Let's begin!\n");
//         GameLoop();
//         DisplayFinalScore();
//     }
    
//     private void DisplayWelcome()
//     {
//         Console.Clear();
//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Console.WriteLine("╔════════════════════════════════════════╗");
//         Console.WriteLine("║   🪨  ROCK PAPER SCISSORS SHOWDOWN  ✂️   ║");
//         Console.WriteLine("╔════════════════════════════════════════╗");
//         Console.ResetColor();
//         Console.WriteLine("\n📜 Rules:");
//         Console.WriteLine("   • Rock crushes Scissors");
//         Console.WriteLine("   • Paper covers Rock");
//         Console.WriteLine("   • Scissors cuts Paper");
//         Console.WriteLine("\n💡 Type 'rock', 'paper', or 'scissors' to play!");
//         Console.WriteLine("   Type 'quit' anytime to exit.\n");
//     }
    
//     private void GameLoop()
//     {
//         while (true)
//         {
//             Console.ForegroundColor = ConsoleColor.Yellow;
//             Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
//             Console.ResetColor();
//             Console.Write("\n🎯 Rock! Paper! Scissors! Shoot! → ");
            
//             string userChoice = Console.ReadLine()?.Trim().ToLower() ?? "";
            
//             if (userChoice == "quit" || userChoice == "exit" || userChoice == "q")
//             {
//                 break;
//             }
            
//             if (!IsValidChoice(userChoice))
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine("❌ Invalid choice! Please choose rock, paper, or scissors.\n");
//                 Console.ResetColor();
//                 continue;
//             }
            
//             string computerChoice = GetComputerChoice();
//             DisplayChoices(userChoice, computerChoice);
            
//             GameResult result = DetermineWinner(userChoice, computerChoice);
//             DisplayResult(result, userChoice, computerChoice);
//             UpdateScore(result);
//             DisplayCurrentScore();
            
//             Console.WriteLine();
//             if (!GetYesNo("Play again?"))
//             {
//                 break;
//             }
//             Console.WriteLine();
//         }
//     }
    
//     private bool IsValidChoice(string choice)
//     {
//         return Array.Exists(choices, c => c == choice);
//     }
    
//     private string GetComputerChoice()
//     {
//         return choices[random.Next(choices.Length)];
//     }
    
//     private void DisplayChoices(string userChoice, string computerChoice)
//     {
//         Console.WriteLine();
//         Console.ForegroundColor = ConsoleColor.Blue;
//         Console.Write($"   You chose: {GetEmoji(userChoice)} {userChoice.ToUpper()}");
//         Console.ResetColor();
        
//         System.Threading.Thread.Sleep(500);
//         Console.Write(" ... ");
//         System.Threading.Thread.Sleep(500);
        
//         Console.ForegroundColor = ConsoleColor.Magenta;
//         Console.WriteLine($"Computer chose: {GetEmoji(computerChoice)} {computerChoice.ToUpper()}");
//         Console.ResetColor();
//         Console.WriteLine();
//     }
    
//     private GameResult DetermineWinner(string userChoice, string computerChoice)
//     {
//         if (userChoice == computerChoice)
//             return GameResult.Draw;
        
//         bool userWins = (userChoice == "rock" && computerChoice == "scissors") ||
//                        (userChoice == "paper" && computerChoice == "rock") ||
//                        (userChoice == "scissors" && computerChoice == "paper");
        
//         return userWins ? GameResult.UserWin : GameResult.ComputerWin;
//     }
    
//     private void DisplayResult(GameResult result, string userChoice, string computerChoice)
//     {
//         switch (result)
//         {
//             case GameResult.UserWin:
//                 Console.ForegroundColor = ConsoleColor.Green;
//                 Console.WriteLine($"🎉 YOU WIN! {userChoice.ToUpper()} beats {computerChoice.ToUpper()}!");
//                 break;
//             case GameResult.ComputerWin:
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine($"💔 YOU LOSE! {computerChoice.ToUpper()} beats {userChoice.ToUpper()}!");
//                 break;
//             case GameResult.Draw:
//                 Console.ForegroundColor = ConsoleColor.Yellow;
//                 Console.WriteLine($"🤝 IT'S A DRAW! Both chose {userChoice.ToUpper()}!");
//                 break;
//         }
//         Console.ResetColor();
//     }
    
//     private void UpdateScore(GameResult result)
//     {
//         switch (result)
//         {
//             case GameResult.UserWin:
//                 userScore++;
//                 break;
//             case GameResult.ComputerWin:
//                 computerScore++;
//                 break;
//             case GameResult.Draw:
//                 drawCount++;
//                 break;
//         }
//     }
    
//     private void DisplayCurrentScore()
//     {
//         Console.WriteLine($"\n📊 Score: You {userScore} - {computerScore} Computer | Draws: {drawCount}");
//     }
    
//     private void DisplayFinalScore()
//     {
//         Console.WriteLine("\n");
//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Console.WriteLine("╔════════════════════════════════════════╗");
//         Console.WriteLine("║            FINAL RESULTS               ║");
//         Console.WriteLine("╔════════════════════════════════════════╗");
//         Console.ResetColor();
//         Console.WriteLine($"\n   Your Score:     {userScore}");
//         Console.WriteLine($"   Computer Score: {computerScore}");
//         Console.WriteLine($"   Draws:          {drawCount}");
//         Console.WriteLine($"   Total Games:    {userScore + computerScore + drawCount}");
        
//         if (userScore > computerScore)
//         {
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine("\n🏆 CONGRATULATIONS! You're the champion! 🏆");
//         }
//         else if (computerScore > userScore)
//         {
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine("\n💻 The computer wins this round! Better luck next time!");
//         }
//         else
//         {
//             Console.ForegroundColor = ConsoleColor.Yellow;
//             Console.WriteLine("\n🤝 It's a tie! Perfectly matched!");
//         }
//         Console.ResetColor();
//         Console.WriteLine("\n👋 Thanks for playing! Goodbye!\n");
//     }
    
//     private bool GetYesNo(string question)
//     {
//         while (true)
//         {
//             Console.Write($"{question} (yes/no): ");
//             string response = Console.ReadLine()?.Trim().ToLower() ?? "";
            
//             if (response == "yes" || response == "y")
//                 return true;
//             if (response == "no" || response == "n")
//                 return false;
            
//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine("Please answer 'yes' or 'no'.");
//             Console.ResetColor();
//         }
//     }
    
//     private string GetEmoji(string choice)
//     {
//         return choice switch
//         {
//             "rock" => "🪨",
//             "paper" => "📄",
//             "scissors" => "✂️",
//             _ => "❓"
//         };
//     }
    
//     private enum GameResult
//     {
//         UserWin,
//         ComputerWin,
//         Draw
//     }
// }


// {
//     class Program
//     {
//         private static Dictionary<string, string> userAccounts = new Dictionary<string, string>
//         {
//             { "demo", "basicP@ssword1!" }
//         };

//         private static readonly string[] commonPasswords = new[]
//         {
//             "password", "123456", "12345678", "qwerty", "abc123",
//             "password123", "admin", "letmein", "welcome", "monkey"
//         };

//         static void Main(string[] args)
//         {
//             Console.ForegroundColor = ConsoleColor.Cyan;
//             DisplayWelcomeBanner();
//             Console.ResetColor();

//             bool running = true;
//             while (running)
//             {
//                 running = MainMenu();
//             }

//             ExitProgram();
//         }

//         static void DisplayWelcomeBanner()
//         {
//             Console.Clear();
//             Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
//             Console.WriteLine("║                                                            ║");
//             Console.WriteLine("║          🔐  SECURE PASSWORD VALIDATION SYSTEM  🔐         ║");
//             Console.WriteLine("║                                                            ║");
//             Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
//             Console.WriteLine();
//         }

//         static bool MainMenu()
//         {
//             Console.ForegroundColor = ConsoleColor.White;
//             Console.WriteLine("\n┌─────────────────────────────────────┐");
//             Console.WriteLine("│           MAIN MENU                 │");
//             Console.WriteLine("├─────────────────────────────────────┤");
//             Console.WriteLine("│  [N] Create New Account             │");
//             Console.WriteLine("│  [L] Login to Existing Account      │");
//             Console.WriteLine("│  [V] View Account List              │");
//             Console.WriteLine("│  [Q] Quit Program                   │");
//             Console.WriteLine("└─────────────────────────────────────┘");
//             Console.ResetColor();
//             Console.Write("\nYour choice: ");

//             string input = Console.ReadLine()?.Trim().ToLower() ?? "";

//             switch (input)
//             {
//                 case "n":
//                     CreateNewAccount();
//                     return true;
//                 case "l":
//                     LoginToAccount();
//                     return true;
//                 case "v":
//                     ViewAccounts();
//                     return true;
//                 case "q":
//                 case "quit":
//                 case "exit":
//                     return false;
//                 default:
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine("❌ Invalid option. Please try again.");
//                     Console.ResetColor();
//                     return true;
//             }
//         }

//         static void CreateNewAccount()
//         {
//             Console.Clear();
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
//             Console.WriteLine("║              CREATE NEW ACCOUNT                            ║");
//             Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
//             Console.ResetColor();
//             Console.WriteLine();

//             // Get username
//             string username;
//             while (true)
//             {
//                 Console.Write("Enter username (or 'back' to return): ");
//                 username = Console.ReadLine()?.Trim() ?? "";

//                 if (username.ToLower() == "back")
//                     return;

//                 if (string.IsNullOrWhiteSpace(username))
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine("❌ Username cannot be empty.");
//                     Console.ResetColor();
//                     continue;
//                 }

//                 if (userAccounts.ContainsKey(username))
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine("❌ Username already exists. Please choose another.");
//                     Console.ResetColor();
//                     continue;
//                 }

//                 break;
//             }

//             // Get password
//             Console.WriteLine();
//             DisplayPasswordRequirements();
//             Console.WriteLine();

//             string password;
//             while (true)
//             {
//                 Console.Write("Enter password (or 'back' to return): ");
//                 password = ReadPassword();

//                 if (password.ToLower() == "back")
//                     return;

//                 var validation = ValidatePassword(password);
//                 if (validation.IsValid)
//                 {
//                     DisplayPasswordStrength(password);
//                     Console.WriteLine();
//                     Console.ForegroundColor = ConsoleColor.Green;
//                     Console.WriteLine("✓ Password meets all requirements!");
//                     Console.ResetColor();
//                     break;
//                 }
//                 else
//                 {
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine("\n❌ Password validation failed:");
//                     foreach (var error in validation.Errors)
//                     {
//                         Console.WriteLine($"   • {error}");
//                     }
//                     Console.ResetColor();
//                     Console.WriteLine();
//                 }
//             }

//             // Confirm password
//             Console.WriteLine();
//             Console.Write("Confirm password: ");
//             string confirmPassword = ReadPassword();

//             if (password != confirmPassword)
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine("\n❌ Passwords do not match. Account creation cancelled.");
//                 Console.ResetColor();
//                 PressAnyKeyToContinue();
//                 return;
//             }

//             // Create account
//             userAccounts[username] = password;
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine("\n✓ Account created successfully!");
//             Console.WriteLine($"✓ Welcome, {username}!");
//             Console.ResetColor();
//             PressAnyKeyToContinue();
//         }

//         static void LoginToAccount()
//         {
//             Console.Clear();
//             Console.ForegroundColor = ConsoleColor.Cyan;
//             Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
//             Console.WriteLine("║                    LOGIN                                   ║");
//             Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
//             Console.ResetColor();
//             Console.WriteLine();

//             int attempts = 0;
//             const int maxAttempts = 3;

//             while (attempts < maxAttempts)
//             {
//                 Console.Write("Username (or 'back' to return): ");
//                 string username = Console.ReadLine()?.Trim() ?? "";

//                 if (username.ToLower() == "back")
//                     return;

//                 Console.Write("Password: ");
//                 string password = ReadPassword();
//                 Console.WriteLine();

//                 if (userAccounts.TryGetValue(username, out string storedPassword) && 
//                     storedPassword == password)
//                 {
//                     Console.ForegroundColor = ConsoleColor.Green;
//                     Console.WriteLine($"\n✓ Login successful! Welcome back, {username}!");
//                     Console.ResetColor();
//                     PressAnyKeyToContinue();
//                     return;
//                 }
//                 else
//                 {
//                     attempts++;
//                     Console.ForegroundColor = ConsoleColor.Red;
//                     Console.WriteLine($"\n❌ Invalid credentials. Attempts remaining: {maxAttempts - attempts}");
//                     Console.ResetColor();
//                     Console.WriteLine();
//                 }
//             }

//             Console.ForegroundColor = ConsoleColor.Red;
//             Console.WriteLine("❌ Maximum login attempts exceeded. Returning to main menu.");
//             Console.ResetColor();
//             PressAnyKeyToContinue();
//         }

//         static void ViewAccounts()
//         {
//             Console.Clear();
//             Console.ForegroundColor = ConsoleColor.Yellow;
//             Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
//             Console.WriteLine("║                  REGISTERED ACCOUNTS                       ║");
//             Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
//             Console.ResetColor();
//             Console.WriteLine();

//             if (userAccounts.Count == 0)
//             {
//                 Console.WriteLine("No accounts registered.");
//             }
//             else
//             {
//                 Console.WriteLine($"Total accounts: {userAccounts.Count}\n");
//                 int index = 1;
//                 foreach (var username in userAccounts.Keys)
//                 {
//                     Console.WriteLine($"{index}. {username}");
//                     index++;
//                 }
//             }

//             PressAnyKeyToContinue();
//         }

//         static void DisplayPasswordRequirements()
//         {
//             Console.ForegroundColor = ConsoleColor.Yellow;
//             Console.WriteLine("┌─────────────────────────────────────────────────────────┐");
//             Console.WriteLine("│              PASSWORD REQUIREMENTS                      │");
//             Console.WriteLine("├─────────────────────────────────────────────────────────┤");
//             Console.WriteLine("│  ✓ Minimum 8 characters, maximum 40 characters          │");
//             Console.WriteLine("│  ✓ At least one uppercase letter (A-Z)                  │");
//             Console.WriteLine("│  ✓ At least one lowercase letter (a-z)                  │");
//             Console.WriteLine("│  ✓ At least one number (0-9)                            │");
//             Console.WriteLine("│  ✓ At least one special character (!@#$%^&*...)         │");
//             Console.WriteLine("│  ✓ No whitespace allowed                                │");
//             Console.WriteLine("│  ✓ Should not be a common password                      │");
//             Console.WriteLine("└─────────────────────────────────────────────────────────┘");
//             Console.ResetColor();
//         }

//         static (bool IsValid, List<string> Errors) ValidatePassword(string password)
//         {
//             var errors = new List<string>();

//             if (string.IsNullOrWhiteSpace(password))
//             {
//                 errors.Add("Password cannot be empty");
//                 return (false, errors);
//             }

//             if (password.Length < 8)
//                 errors.Add("Password must be at least 8 characters long");

//             if (password.Length > 40)
//                 errors.Add("Password must not exceed 40 characters");

//             if (password.Any(char.IsWhiteSpace))
//                 errors.Add("Password cannot contain whitespace");

//             if (!password.Any(char.IsUpper))
//                 errors.Add("Password must contain at least one uppercase letter");

//             if (!password.Any(char.IsLower))
//                 errors.Add("Password must contain at least one lowercase letter");

//             if (!password.Any(char.IsDigit))
//                 errors.Add("Password must contain at least one digit");

//             if (!password.Any(c => !char.IsLetterOrDigit(c)))
//                 errors.Add("Password must contain at least one special character");

//             // Check for common passwords
//             if (commonPasswords.Any(cp => password.ToLower().Contains(cp)))
//                 errors.Add("Password contains a common password pattern");

//             // Check for sequential characters
//             if (ContainsSequentialCharacters(password))
//                 errors.Add("Password contains sequential characters (e.g., '123', 'abc')");

//             return (errors.Count == 0, errors);
//         }

//         static bool ContainsSequentialCharacters(string password)
//         {
//             for (int i = 0; i < password.Length - 2; i++)
//             {
//                 if (char.IsDigit(password[i]) && char.IsDigit(password[i + 1]) && char.IsDigit(password[i + 2]))
//                 {
//                     if (password[i + 1] == password[i] + 1 && password[i + 2] == password[i] + 2)
//                         return true;
//                 }
//                 if (char.IsLetter(password[i]) && char.IsLetter(password[i + 1]) && char.IsLetter(password[i + 2]))
//                 {
//                     if (char.ToLower(password[i + 1]) == char.ToLower(password[i]) + 1 && 
//                         char.ToLower(password[i + 2]) == char.ToLower(password[i]) + 2)
//                         return true;
//                 }
//             }
//             return false;
//         }

//         static void DisplayPasswordStrength(string password)
//         {
//             int strength = CalculatePasswordStrength(password);
//             Console.ForegroundColor = strength switch
//             {
//                 <= 2 => ConsoleColor.Red,
//                 <= 4 => ConsoleColor.Yellow,
//                 _ => ConsoleColor.Green
//             };

//             string strengthText = strength switch
//             {
//                 <= 2 => "Weak",
//                 <= 4 => "Medium",
//                 _ => "Strong"
//             };

//             string bar = new string('█', strength) + new string('░', 6 - strength);
//             Console.WriteLine($"\nPassword Strength: [{bar}] {strengthText}");
//             Console.ResetColor();
//         }

//         static int CalculatePasswordStrength(string password)
//         {
//             int strength = 0;

//             if (password.Length >= 8) strength++;
//             if (password.Length >= 12) strength++;
//             if (password.Any(char.IsUpper)) strength++;
//             if (password.Any(char.IsLower)) strength++;
//             if (password.Any(char.IsDigit)) strength++;
//             if (password.Count(c => !char.IsLetterOrDigit(c)) >= 2) strength++;

//             return Math.Min(strength, 6);
//         }

//         static string ReadPassword()
//         {
//             string password = "";
//             ConsoleKeyInfo key;

//             do
//             {
//                 key = Console.ReadKey(true);

//                 if (key.Key == ConsoleKey.Backspace && password.Length > 0)
//                 {
//                     password = password[0..^1];
//                     Console.Write("\b \b");
//                 }
//                 else if (!char.IsControl(key.KeyChar))
//                 {
//                     password += key.KeyChar;
//                     Console.Write("*");
//                 }
//             } while (key.Key != ConsoleKey.Enter);

//             Console.WriteLine();
//             return password;
//         }

//         static void PressAnyKeyToContinue()
//         {
//             Console.WriteLine("\nPress any key to continue...");
//             Console.ReadKey(true);
//         }

//         static void ExitProgram()
//         {
//             Console.Clear();
//             Console.ForegroundColor = ConsoleColor.Cyan;
//             Console.WriteLine("\n╔════════════════════════════════════════════════════════════╗");
//             Console.WriteLine("║                                                            ║");
//             Console.WriteLine("║          Thank you for using the Password                 ║");
//             Console.WriteLine("║              Validation System! 🔐                         ║");
//             Console.WriteLine("║                                                            ║");
//             Console.WriteLine("║                  Stay Secure! 👋                           ║");
//             Console.WriteLine("║                                                            ║");
//             Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
//             Console.ResetColor();
//             Console.WriteLine();
//         }
//     }
// }

