using System;

namespace LabFive_Dice_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");

            Console.Write("Roll the dice? (y/n):");
            string RollDice = Console.ReadLine().ToUpper();

            //string RollAgain = "Y";

            if (RollDice == "Y")
            {
                while (RollDice == "Y")
                {
                    Console.WriteLine("How many sides should each die have?");
                    string NumOfSidesS = Console.ReadLine();

                    int NumOfSides;
                    bool SidesBool = int.TryParse(NumOfSidesS, out NumOfSides);
                    {
                        Console.WriteLine("Roll 1");

                        Console.WriteLine("Dice 1:" + GenerateRandom(NumOfSides));
                        Console.WriteLine("Dice 2:" + GenerateRandom(NumOfSides));

                        Console.WriteLine("Would you like to roll again? (y/n)");
                        RollDice = Console.ReadLine().ToUpper();
                    }
                }
            }
            else if (RollDice == "N")
            {
                Console.WriteLine("Thank you, have a great day");
            }
            else
            {
                Console.WriteLine("You did not enter Y or N");
            }
        }
        static int GenerateRandom(int NumOfSides)
        {
            
            Random rnd = new Random();
            int DiceOne = rnd.Next(1, NumOfSides);
            return DiceOne;
        }
    }
}