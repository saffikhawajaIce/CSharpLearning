// See https://aka.ms/new-console-template for more information

//input loop
using System.Net;
using System.Reflection;


System.Console.WriteLine("welcome to my Quiz!\nTo begin i'd like to ask you to choose a difficulty level!\nType 1 for Easy\nType 2 for Medium\nType 3 for Hard");
while (true)
{
    string difficultyInput = System.Console.ReadLine().Trim();

    if (string.IsNullOrWhiteSpace(difficultyInput))
    {
        System.Console.WriteLine("Invalid Input, please try again.");
        continue;
    }

    if (difficultyInput != "1" && difficultyInput != "2" && difficultyInput != "3")
    {
        System.Console.WriteLine("Invalid Input, please try again.");
        continue;
    }

    if (difficultyInput.Equals("1"))
    {
        EasyQuestions();
    }

    else if (difficultyInput.Equals("2"))
    {
        MediumQuestions();
    }

    else if (difficultyInput.Equals("3"))
    {
        HardQuestions();
    }
}

//easy question logic
static int EasyQuestions()
{
    int correctAnswers = 0;
    System.Console.WriteLine("What is 2 + 2?");
    string answer = System.Console.ReadLine().Trim();
    if (answer.Equals("4"))
    {
        System.Console.WriteLine("Correct!");
        correctAnswers++;
    }
    else
    {
        System.Console.WriteLine("Incorrect, the correct answer is 4.");
    }

    System.Console.WriteLine("What color is the sky on a clear day?");
    answer = System.Console.ReadLine().Trim().ToLower();
    if (answer.Equals("blue"))
    {
        System.Console.WriteLine("Correct!");
        correctAnswers++;
    }
    else
    {
        System.Console.WriteLine("Incorrect, the correct answer is blue.");
    }

    System.Console.WriteLine("What is the capital of France?");
    answer = System.Console.ReadLine().Trim().ToLower();
    if (answer.Equals("paris"))
    {
        System.Console.WriteLine("Correct!");
        correctAnswers++;
    }
    else
    {
        System.Console.WriteLine("Incorrect, the correct answer is Paris.");
    }

    System.Console.WriteLine("What is the largest planet in our solar system?");
    answer = System.Console.ReadLine().Trim().ToLower();
    if (answer.Equals("jupiter"))
    {
        System.Console.WriteLine("Correct!");
        correctAnswers++;
    }
    else
    {
        System.Console.WriteLine("Incorrect, the correct answer is Jupiter.");
    }

    System.Console.WriteLine("What is the boiling point of water in degrees Celsius?");
    answer = System.Console.ReadLine().Trim().ToLower();
    if (answer.Equals("100"))
    {
        System.Console.WriteLine("Correct!");
        correctAnswers++;
    }
    else
    {
        System.Console.WriteLine("Incorrect, the correct answer is 100.");
    }

    System.Console.WriteLine("who wrote 'Romeo and Juliet'?");
    answer = System.Console.ReadLine().Trim().ToLower();
    if (answer.Equals("shakespeare") || answer.Equals("william shakespeare"))
    {
        System.Console.WriteLine("Correct!");
        correctAnswers++;
    }
    else
    {
        System.Console.WriteLine("Incorrect, the correct answer is William Shakespeare.");
    }

    System.Console.WriteLine("How many continents are there on Earth?");
    answer = System.Console.ReadLine().Trim().ToLower();
    if (answer.Equals("7"))
    {
        System.Console.WriteLine("Correct!");
        correctAnswers++;
    }
    else
    {
        System.Console.WriteLine("Incorrect, the correct answer is 7.");
    }

    System.Console.WriteLine("where is the Great Wall located?");
    answer = System.Console.ReadLine().Trim().ToLower();
    if (answer.Equals("china"))
    {
        System.Console.WriteLine("Correct!");
        correctAnswers++;
    }
    else
    {
        System.Console.WriteLine("Incorrect, the correct answer is China.");
    }

    System.Console.WriteLine("What is the chemical symbol for gold?");
    answer = System.Console.ReadLine().Trim().ToLower();
    if (answer.Equals("au"))
    {
        System.Console.WriteLine("Correct!");
        correctAnswers++;
    }
    else
    {
        System.Console.WriteLine("Incorrect, the correct answer is Au.");
    }

    System.Console.WriteLine("What is the smallest prime number?");
    answer = System.Console.ReadLine().Trim().ToLower();
    if (answer.Equals("2"))
    {
        System.Console.WriteLine("Correct!");
        correctAnswers++;
    }
    else
    {
        System.Console.WriteLine("Incorrect, the correct answer is 2.");
    }

    System.Console.WriteLine("would you like to see your results? Type Y for yes or N for no.");
    string resultsInput = System.Console.ReadLine().Trim().ToUpper();
    if (resultsInput.Equals("Y"))
    {
        DisplayEasyResults(correctAnswers);
    }
    else
    {
        System.Console.WriteLine("Thank you for playing!");
    }
    return correctAnswers;

}

//medium question logic
static int MediumQuestions()
{
    int correctMediumAnswers = 0;
    var questions = new List<(string Question, string[] Answers)>
    {
        ("What is the chemical symbol for gold?", new[] { "au" }),
        ("What is the capital of Canada?", new[] { "ottawa" }),
        ("Which planet is known as the Red Planet?", new[] { "mars" }),
        ("What does HTTP stand for?", new[] { "hypertext transfer protocol" }),
        ("What is the largest ocean on Earth?", new[] { "pacific", "pacific ocean" }),
        ("What galaxy is Earth located in?", new[] { "milky way", "the milky way" }),
        ("How many strings does a standard violin have?", new[] { "4", "four" }),
        ("What is the currency of Japan?", new[] { "yen", "japanese yen" }),
        ("What does CPU stand for?", new[] { "central processing unit" }),
        ("In chess, which piece moves only diagonally?", new[] { "bishop", "the bishop" })
    };

    foreach (var q in questions)
    {
        if (AskQuestion(q.Question, q.Answers))
        {
            Console.WriteLine("Correct!");
            correctMediumAnswers++;
        }
        else
        {
            Console.WriteLine($"Incorrect. Acceptable answer(s): {string.Join(", ", q.Answers)}\n");
        }

        Console.WriteLine(); 
    }
    System.Console.WriteLine("would you like to see your results? Type Y for yes or N for no.");
    string resultsInput = System.Console.ReadLine().Trim().ToUpper();
    if (resultsInput.Equals("Y"))
    {
        DisplayMediumResults(correctMediumAnswers, questions.Count);
    }
    else
    {
        System.Console.WriteLine("Thank you for playing!");
    }
    return correctMediumAnswers;
}

static bool AskQuestion(string question, string[] acceptableAnswers)
{
    Console.WriteLine(question);

    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
        return false;

    input = input.Trim().ToLower();

    foreach (var answer in acceptableAnswers)
    {
        if (input == answer)
            return true;
    }

    return false;
}


static void HardQuestions()
{
    System.Console.WriteLine("Not implemented yet.");
}

static void DisplayEasyResults(int correctAnswers)
{
    System.Console.WriteLine($"You got {correctAnswers} questions correct.");
}
static void DisplayMediumResults(int MediumcorrectAnswers, int totalQuestions)
{
    System.Console.WriteLine($"You got {MediumcorrectAnswers} out of {totalQuestions} questions correct.");
}
