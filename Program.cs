// See https://aka.ms/new-console-template for more information

// Get user guess

Console.WriteLine(@"Can you guess the secret number?
It's a number between 1 - 100.
Enter your guess!
");

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
int remainingGuesses = 4 ;
while (round != 4)
{
    Guess();
    if (guess == secretNumber)
    {
        Console.WriteLine(@"
Congratulations!
You guessed the secret number!
Are you psychic?
That was an amazing guess!
");
        round = 4;
    }
    else
    {
        round += 1;
        remainingGuesses -= 1;
        if (remainingGuesses > 0)
        {
        Console.WriteLine(@$"
Oh no!
You guessed wrong.
You have {remainingGuesses} left!
");
        }
        else
        { 
            Console.WriteLine(@"
Wah Wah Waaahhhh.
You're REALLY bad at this game.
YOU LOST!
");
        }
    }
}