Console.WriteLine("Hello and welcome to the guessing game 💩");
System.Console.WriteLine("You are going to guess a number between 1 - 20, press y for Yes and n for No :)");

List<int> numbers = new List<int>();
Random random = new Random();
int randomNumber = random.Next(1, 20);


ConsoleKeyInfo initiateGameKey = Console.ReadKey();
char initiateGame = initiateGameKey.KeyChar;




if (initiateGame == 'y')
{
    ;
    numbers.Add(randomNumber);
    Console.Clear();
    System.Console.WriteLine("Alright, lets begin!");
    System.Console.WriteLine("Enter your number: ");

    bool controlGuess = true;

    while (controlGuess)
    {


        if (!int.TryParse(Console.ReadLine(), out int userGuess))
        {
            System.Console.WriteLine("You must write a number..");
            continue;
        }
        else if (userGuess > 20 || userGuess < 1)
        {
            System.Console.WriteLine("Must be between 1 - 20, try again :");
        }
        else if (userGuess < randomNumber)
        {
            System.Console.WriteLine("Too low, try again: ");
        }
        else if (userGuess > randomNumber)
        {
            System.Console.WriteLine("Too high, try again");
        }
        else if (userGuess == randomNumber)
        {
            System.Console.WriteLine($"Correct! the right number was {randomNumber}");
        }

    }


}
else if (initiateGame == 'n')
{
    System.Console.WriteLine("Alright, maybe another time!");
}






