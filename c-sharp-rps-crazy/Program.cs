// Crazy Mode

// define general variables
string computerChoice;
string computerChoiceIcon;
string userChoice;
string userChoiceIcon;
int randomChoiceComputer;
int randomChoiceUser;
// points counter
int totalPointsUser = 0;
int totalPointsComputer = 0;
int totalPointsTie = 0;
// set game length
int rounds;
// go again or exit game
bool exitGame = false;
//bool exitGameSwitch = false;


// art
string genPath = "C:\\Users\\eduar\\Umschulung\\SE-Grundlagen\\Uebungen\\rps-crazy-mode";

string welcomePath = $"{genPath}\\welcome.txt";
string rockPath = $"{genPath}\\rock.txt";
string paperPath = $"{genPath}\\paper.txt";
string scissorsPath = $"{genPath}\\scissors.txt";

string welcome = File.ReadAllText(welcomePath);
string rock = File.ReadAllText(rockPath);
string paper = File.ReadAllText(paperPath);
string scissors = File.ReadAllText(scissorsPath);


Console.WriteLine("Enter Rounds, 1 - 10:");
rounds = Convert.ToInt16(Console.ReadLine());


while (exitGame == false)
{
    bool exitGameSwitch = false;

    for (int i = 0; i < rounds; i++)
    {
    
        int pointsUser = 0;
        int pointsComputer = 0;
        int pointsTie = 0;
    
    
        // random comp choice: create list with all choices
        List<string> choicesComputer = new List<string>
        {
            "rock",
            "paper",
            "scissors"
        };
        // generate a random number with the range of list choices
        Random randomComputer = new Random();
        randomChoiceComputer = randomComputer.Next(0, choicesComputer.Count);
        computerChoiceIcon = choicesComputer[randomChoiceComputer];
        // get random computer choice
        if (computerChoiceIcon == "rock")
        {
            computerChoiceIcon = rock;
            computerChoice = "rock";
        }
        else if (computerChoiceIcon == "paper")
        {
            computerChoiceIcon = paper;
            computerChoice = "paper";
        }
        else
        {
            computerChoiceIcon = scissors;
            computerChoice = "scissors";
        }
    
    
        while (true)
        {
    
    
            // clear for shuffle effect
            Console.Clear();
    
    
            // print the rest for static effect (variables for computer choice don't change)
            Console.WriteLine(welcome);
            Console.WriteLine();
            Console.WriteLine($"User: {totalPointsUser}, Computer: {totalPointsComputer}, Ties: {totalPointsTie}");
            Console.WriteLine();
            Console.WriteLine("The Machine Chooses:\n" +
                $"{computerChoiceIcon}\n" +
                $"{computerChoice}\n");
    
    
            // random user choice: create list with all choices
            List<string> choicesUser = new List<string>
            {
                "rock",
                "paper",
                "scissors"
            };
            // generate a random number with the range of list choices
            Random randomUser = new Random();
            randomChoiceUser = randomUser.Next(0, choicesUser.Count);
            userChoiceIcon = choicesComputer[randomChoiceUser];
            // get random computer choice
            if (userChoiceIcon == "rock")
            {
                userChoiceIcon = rock;
                userChoice = "rock";
            }
            else if (userChoiceIcon == "paper")
            {
                userChoiceIcon = paper;
                userChoice = "paper";
            }
            else
            {
                userChoiceIcon = scissors;
                userChoice = "scissors";
            }
    
    
            // print user choice shuffle
            Console.WriteLine("The User Chooses:\n" +
            $"{userChoiceIcon}\n" +
            $"{userChoice}\n");
    
    
            // delay setting
            Thread.Sleep(500);
    
    
            // wait for enter key to be pressed
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    // evaluate
                    //// determine winner
                    if (userChoice == computerChoice)
                    {
                        Console.WriteLine("tie.");
                        pointsTie += 1;
                        Thread.Sleep(2000);
                    }
                    else if (userChoice == "rock" && computerChoice == "scissors" || userChoice == "paper" && computerChoice == "rock" || userChoice == "scissors" && computerChoice == "paper")
                    {
                        Console.WriteLine("you win.");
                        pointsUser += 1;
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("you lose.");
                        pointsComputer += 1;
                        Thread.Sleep(2000);
                    }
                    break;
                }
            }
        }
    
    
        totalPointsUser += pointsUser;
        totalPointsComputer += pointsComputer;
        totalPointsTie += pointsTie;
    }
    
    Console.Clear();
    Console.WriteLine(welcome);
    Console.WriteLine();
    Console.WriteLine($"User: {totalPointsUser}, Computer: {totalPointsComputer}, Ties: {totalPointsTie}");


    while (!exitGameSwitch)
    {
        // ask user to go again or quit
        Console.WriteLine("Play? (y/n): ");
        string exit = Console.ReadLine().ToLower();

        switch (exit)
        {
            case "y":
            case "yes":
            case "ja":
            case "yea":
            case "jep":
            case "jap":
                exitGameSwitch = true;
                totalPointsUser = 0;
                totalPointsComputer = 0;
                totalPointsTie = 0;
                break;

            case "n":
            case "no":
            case "nein":
            case "nope":
            case "nah":
                exitGameSwitch = true;
                exitGame = true;
                break;

            default:
                Console.Clear();
                Console.WriteLine(welcome);
                Console.WriteLine();
                Console.WriteLine($"User: {totalPointsUser}, Computer: {totalPointsComputer}, Ties: {totalPointsTie}");
                break;
        }
    }
}