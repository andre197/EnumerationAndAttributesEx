using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();

        var a = Enum.GetValues(typeof(CardRank));

        if (command== "Card Deck")
        {
            foreach (var suit in Enum.GetNames(typeof(CardSuit)))
            {
                foreach (var rank in Enum.GetValues(typeof(CardRank)))
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }

    }
}

