

using roshambo;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using System.Xml.Serialization;
Main();
void Main()
{
    RecordKeeper gameRecord = new();
    bool isPlay = true;
    Player player = GetName();
    while (isPlay)
    {
        gameRecord.CheckGameRecords(player.Name);
        //Console.WriteLine(gameRecord.DisplayGameRecords(player.Name));
        Player opponent = GetOpponent(player.Name);
        gameRecord.CheckGameRecords(opponent.Name);
        //Console.WriteLine(gameRecord.DisplayGameRecords(player.Name));
        gameRecord.CheckGameRecords(opponent.Name);
        //Console.WriteLine(gameRecord.DisplayGameRecords(opponent.Name));
        int choice = -1;
        while (choice == -1)
        {
            Console.WriteLine
            (
            $"Alright all human people know the rules {player.Name}! \n" +
            $"The time has come to choose! \n" +
            $"1) Paper \n" +
            $"2) Rock \n" +
            $"3) Scissors \n"
            );
            choice = Validator.ValidateRoshambo(Console.ReadLine());
        }
        Console.Clear();
        player = new HumanPlayer(player.Name, choice);
        Console.WriteLine
            (
            $"The human person {player.Name} played {player.Roshambo}! \n" +
            $"The superior robot person {opponent.Name} played a {opponent.Roshambo}!"
            );
        Console.WriteLine("Results Computed, press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        //Console.WriteLine(Validator.ValidateGame(player, opponent) + "\n");
        gameRecord.AddResult(player.Name, opponent.Name, Validator.ValidateGame(player, opponent));
        Console.WriteLine(gameRecord.DisplayGameRecords(player.Name));
        Console.WriteLine(gameRecord.DisplayGameRecords(opponent.Name));
        
        Console.ReadKey();
        Console.WriteLine($"Would you like to play again? <y> or <n> \n");
        Console.WriteLine("...");
        isPlay = Validator.ValidateIsPlay(Console.ReadLine());
        Console.Clear();
    }
    Console.WriteLine($"Catch you on the flipbidy flop {player.Name}...");
}

HumanPlayer GetName()
{
    string name = String.Empty;
    Console.WriteLine("Hello human person, what is your name?");
    while (name == String.Empty)
    {
        name = Validator.IsValidName(Console.ReadLine());
    }
    Console.Clear();
    return new HumanPlayer(name);
}
Player GetOpponent(string name)
{
    
    int choice = -1;
    while (choice == -1)
    {
        Console.WriteLine
        (
        $"Alright human person named {name} " +
        $"\nLets play paper, rock, scissors! " +
        $"\nWho would you like to face off against! \n" +
        $"1) Rock Player \n" +
        $"2) Random Player\n" +
        $"...\n"
        );
        choice = Validator.ValidateSelection(Console.ReadLine());
        Console.Clear();
        if (choice == -1)
        {
            continue;
        }
    }
    return choice == 1 ? new RockPlayer("Rock Player") : new RandomPlayer("Random Player"); 
}
