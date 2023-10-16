namespace SandersFighter.Model;

internal class Game
{
    private int _turnCounter = 0;

    public int Id { get; set; }
    public List<Player> Players { get; set; } = new();
    public List<Turn> Turns { get; set; } = new();


    public void RunGame()
    {
        var initalTurn = new Turn(_turnCounter, $"Fighting are: {string.Join(", ", Players.Select(s => s.Name).ToList())}");
        Turns.Add(initalTurn);

        // This is by far the worst thing in the code & could easily be improved. I'm sleepy tho, so no.
        var p1 = Players[0];
        var p2 = Players[1];

        while (p1.HitPoints > 0 && p2.HitPoints > 0)
        {
            var fightingTurn = new Turn(++_turnCounter);
            Turns.Add(fightingTurn);
            fightingTurn.CombatLog.AddRange(p1.DoTurn(p2));
            fightingTurn.CombatLog.AddRange(p2.DoTurn(p1));
        }

        var winner = Players.MaxBy(p => p.HitPoints) ?? throw new Exception("Uwu, Felix made an upsi.");
        var endTurn = new Turn(++_turnCounter, $"{winner.Name} won, with {winner.HitPoints} HP left.");
        Turns.Add(endTurn);
    }
}
