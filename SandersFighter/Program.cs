using SandersFighter.Model;

namespace SandersFighter;

internal class Program
{
    public static void Main()
    {
        //Create game and add players.
        var game = new Game();
        var heinrich = new Player("Heinrich");
        var dude = new Player("KekW");
        game.Players.Add(heinrich);
        game.Players.Add(dude);

        //Give first player weapon
        var stunLogic = (Player player) => { player.Actions = 0; };
        var condition = new Condition("Stun", 20, stunLogic);
        var inflictor = new ConditionInflictor(0, condition);
        heinrich.Weapon = new Weapon("Mace", (2, 10), inflictor);


        game.RunGame(); //Run the game.

        // Print the game result, somewhat formatted.
        foreach (var turn in game.Turns)
        {
            Print($"Start turn: {turn.Number}");
            foreach (var logLine in turn.CombatLog)
            {
                Print(logLine);
            }
            Console.WriteLine();
        }
    }

    private static void Print(string text)
    {
        Console.WriteLine(text);
        Thread.Sleep(100);
    }
}