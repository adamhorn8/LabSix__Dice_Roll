using System;

namespace LabFive_Dice_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Circus Casino!");

            //Ask the user if they want to roll the dice and store input as a string
            Console.Write("Roll the dice? (y/n):");
            string RollDice = Console.ReadLine().ToUpper();

            //If else statement to direct the program what to do based on response
            if (RollDice == "Y")
            {
                while (RollDice == "Y")
                {
                    //Ask User how many sides
                    Console.WriteLine("How many sides should each die have?");
                    string NumOfSidesS = Console.ReadLine();

                    //Convert string from user input into an int
                    int NumOfSides;
                    bool SidesBool = int.TryParse(NumOfSidesS, out NumOfSides);
                    {
                        Console.WriteLine("Roll 1");

                        //Pull the random number generator from the GenerateRandom method
                        Console.WriteLine("Dice 1:" + GenerateRandom(NumOfSides));
                        Console.WriteLine("Dice 2:" + GenerateRandom(NumOfSides));

                        //Ask user if they would like to roll again, if Y, while loop is satisfied and asks how many sides.
                        Console.WriteLine("Would you like to roll again? (y/n)");
                        RollDice = Console.ReadLine().ToUpper();
                    }
                }
            }
            //If user inputs N program ends
            else if (RollDice == "N")
            {
                Console.WriteLine("Thank you, have a great day");
            }
            else
            {
                //If user inputs anything other than N program ends
                Console.WriteLine("You did not enter Y or N");
            }
        }
        //Created new method to house random numebr generator
        static int GenerateRandom(int NumOfSides)
        {
            //Used Random function to generate random number
            Random rnd = new Random();
            int DiceOne = rnd.Next(1, NumOfSides);
            return DiceOne;
        }
    }
}