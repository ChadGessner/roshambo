using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo
{
    public static class Validator
    {
        public static int ValidateSelection(string selection)
        {
            if (IsRockPlayer(selection))
            {
                return 1;
            }
            else if (IsRandomPlayer(selection))
            {
                return 2;
            }
            Console.WriteLine("That is not a valid selection");
            Console.WriteLine("Presss any key to try again...");
            Console.ReadKey();
            Console.Clear();
            return -1;
        }
        static bool IsRockPlayer(string selection)
        {
            selection = selection.ToLower().Trim();
            return selection == "rock" || selection == "rock player" || selection == "1";
        }
        static bool IsRandomPlayer(string selection)
        {
            selection = selection.ToLower().Trim();
            return selection == "random" || selection == "random player" || selection == "2";
        }
        public static string IsValidName(string name)
        {
            name = name.Trim();
            if(name == null || name == string.Empty)
            {
                Console.WriteLine("Don't be scurred, type your name or something...");
                return name;
            }
            return name;
        }
        public static int ValidateRoshambo(string choice)
        {
            if(IsPaper(choice) || IsRock(choice) || IsScissors(choice))
            {
                return IsPaper(choice) ? 0 : IsRock(choice) ? 1 : 2;
            }
            Console.WriteLine("That was not a valid selection, press any key to try again...");
            Console.ReadKey();
            Console.Clear();
            return -1;
        }
        public static bool IsPaper(string paper)
        {
            paper = paper.ToLower().Trim();
            return paper == "paper" || paper == "1";
        }
        public static bool IsRock(string rock)
        {
            rock = rock.ToLower().Trim();
            return rock == "rock" || rock == "2";
        }
        public static bool IsScissors(string scissors)
        {
            scissors = scissors.ToLower().Trim();
            return scissors == "scissors" || scissors == "3";
        }
        public static bool? ValidateGame(Player human, Player robot)
        {
            Roshambo humanRoshambo = human.Roshambo;
            Roshambo robotRoshambo = robot.Roshambo;
            bool isWinner = true;
            if (humanRoshambo == robotRoshambo)
            {
                Console.WriteLine($"IMPOSSIBLE! The superior robot opponent {robot.Name}\nis merely toiling with their prey!\n");
                return null;
            }
            switch (robotRoshambo)
            {
                case (Roshambo)0:
                    isWinner = humanRoshambo == (Roshambo)2;
                    break;
                case (Roshambo)1:
                    isWinner = humanRoshambo == (Roshambo)0;
                    break;
                case (Roshambo)2:
                    isWinner = humanRoshambo == (Roshambo)1;
                    break;
                default:
                    break;
            }
            string message = isWinner ? $"IMPOSSIBLE! {robot.Name}\nis malfunctioning!\nThe developer has failed!\n" : $"The superior robot player {robot.Name}\nhas vanquished their pathetic human opponent {human.Name}!\nThe program is working perfectly!\n";
            Console.WriteLine(message);
            return isWinner;
        }
        public static bool ValidateIsPlay(string yN)
        {
            yN = yN.ToLower().Trim();
            if(yN == null || yN == string.Empty)
            {
                Console.WriteLine("That was not a valid response, have a great day!");
            }
            return yN == "y";
        }
    }
}
