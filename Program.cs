using System;

namespace GithubConfirmation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Title;
            Title = "Dendrodome";

            int lives;
            lives = 3;

            float exp;
            exp = 0.0f;

            int health;
            health = 5;

            int expMultiplyer;
            expMultiplyer = 2;

            int level;
            level = 1;

            string Role;
            Role = "Healer";

            string Race;
            Race = "Human";


            Console.WriteLine("Hello World!");
            Console.ReadKey();

            Console.WriteLine("Are you allowed to play?");
            Console.ReadKey();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|" + "Class:" + Role + "                        |");
            Console.WriteLine("|" + "Race:" + Race + "                          |");
            Console.WriteLine("|" + "Level:" + level + "  " + "Exp:" + exp + "                      |");
            Console.WriteLine("|" + "Current Health:" + health + "  " + "Current Lives:" + lives + "   |");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
