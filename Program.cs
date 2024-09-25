using NumberGusserGame.Models;

namespace NumberGusserGame
{
    internal class Program
    {
        public static string Name ;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Enter your name");
            Name = Console.ReadLine();
            Switches();
        }

        public static void Switches()
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine($"\n0. Exit\n" +
                    $"1. Start game\n" );
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 0:
                        run = false;
                        break;

                    case 1:
                        
                        PlayGame();
                        break;

                    default:
                        Console.WriteLine("Please choose correct option");
                        break;
                }
            }
        }

        public static void PlayGame()
        {
            Gusser gusser = new Gusser();

            int number = gusser.Gusse();

            Console.WriteLine("Gusse number in range 10-20");

            for (int i = 0; i < 3; i++)
            {
                int value = InputNumber();
                if (value == number)
                {
                    Console.WriteLine($"{Name} You gussed the correct number Hurry you won!");
                    return;
                }
                Console.WriteLine($"{Name} you gussed wrong try again you have more {3-i-1} chance left");
            }

            Console.WriteLine($"You lost! the number was {number}");
        }

        public static int InputNumber()
        {
            int number = int.Parse(Console.ReadLine());
            if(number >=10 && number < 20)
            {
                return number;
            }
            Console.WriteLine("Please gusse number in range 10-20");
            return InputNumber();
        }
    }
}
