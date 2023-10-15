using SandersFighter.Model;

namespace SandersFighter;

internal class Program
{
    public static void Main()
    {
        var game = new Game();

        var heinrich = new Player("Heinrich");
        var baum = new Player("Baum");

        game.Players.Add(heinrich);
        game.Players.Add(baum);


        var condition = new Condition();
        var inflictor = new ConditionInflictor(0, condition);

        heinrich.Weapon = new Weapon("Mace", 10, inflictor);


        game.RunGame();

        foreach (var turn in game.Turns)
            Console.WriteLine(turn.CombatLog);
    }
}