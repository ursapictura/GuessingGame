// See https://aka.ms/new-console-template for more information

// Get user guess

Console.WriteLine(@"Can you guess the secret number?
It's a number between 1 - 100.
What level of difficulty to do you want play at?
Easy: 8 guesses
Medium: 6 guesses
Hard: 4 guesses
Cheater: infinite guesses
");

int difficulty;
while (true)
{
    string chosenDifficulty= Console.ReadLine();

    if (chosenDifficulty.ToLower() == "easy")
    {
        difficulty = 8;
        break;
    }
    else if (chosenDifficulty.ToLower() == "medium") 
    {
        difficulty = 6;
        break;
    }
    else if (chosenDifficulty.ToLower() == "hard") 
    {
        difficulty = 4;
        break;
    }
    else if (chosenDifficulty.ToLower() == "cheater") 
    {
        difficulty = 10;
        break;
    }
    else{
        Console.WriteLine("Sorry, but your entry was not valid. Please select a level of difficulty: easy, medium, hard, or cheater.");
    }
}

Console.WriteLine("Ready to guess the secret number? Give it your best shot!");

int guess;
void Guess()
{
 while(true)
    {
        if (Int32.TryParse(Console.ReadLine(), out guess))
        {
            break;
        }
        else
        {
            Console.WriteLine("Sorry, but that wasn't a number! Want to try again?");
        }
    }   

    Console.Clear();
    Console.WriteLine($"You guessed {guess}.");
}

Random randomNum = new Random();
int secretNumber = randomNum.Next(1, 101);

int round = 0;
int remainingGuesses = difficulty;
while (round != difficulty)
{
    Guess();
    if (guess == secretNumber)
    {
        Console.WriteLine(@"Congratulations! You guessed the secret number! Are you psychic? That was an amazing guess!");
        round = difficulty;
    }
    else if (difficulty < 10)
    {
        round += 1;
        remainingGuesses -= 1;
        if (remainingGuesses > 0)
        {
        Console.WriteLine(@$"You guessed {(guess < secretNumber ? "too low!" : "too high!")} You have {remainingGuesses} left!");
        }
        else
        { 
            Console.WriteLine($"Wah Wah Waaahhhh. You're REALLY bad at this game. YOU LOST! The secretNumber was {secretNumber}");
        }
    }
    else{
        Console.WriteLine(@$"You guessed {(guess < secretNumber ? "too low!" : "too high!")}");
    }
}