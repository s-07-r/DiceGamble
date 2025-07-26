using System;
class Dice
{
    static void Main( string[] args)
    {
        Console.WriteLine("Welcome to the game :D\n");
        Console.WriteLine("Please roll the die !\n");
        Console.WriteLine("press Enter to roll the die.\n");
        Console.ReadLine();
        Random random = new Random();
        int roll = random.Next(1, 7);
        int count = 1;
        while (roll != 6)
        {
          
            do
            {
                Console.WriteLine("Not quite there yet! Try again. You rolled, {0}.", roll);
                Console.WriteLine("LET'S GO AGAIN.  ");
                Console.ReadLine();
                roll = random.Next(1, 7);
                count++;

            } while (roll != 6);
        }
        Console.WriteLine("You rolled the die {0} times before you got a 6, Loser.", count);

    }
}
