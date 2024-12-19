using Claw_Machine;

bool continuePlay = true;
do
{
    Console.WriteLine("**************************************************************");
    Console.WriteLine("Press any key to play the claw machine! Each play costs $1.50");
    Console.WriteLine("**************************************************************");
    Console.ReadKey();
    Console.WriteLine();
    ClawMachine.Play();
    Console.WriteLine("Would you like to play again? (y/n)");
    string userResponse = Console.ReadLine().ToLower();
    if (userResponse == "y")
    {
        Console.Clear();
        continuePlay = true;
    }
    else
    {
        continuePlay = false;
    }
} while (continuePlay == true);
Console.WriteLine("Goodbye!");

