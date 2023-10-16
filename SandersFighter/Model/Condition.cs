using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandersFighter.Model;

internal class Condition
{
    public Condition(string name, int chance, Action<Player> effect)
    {
        Name = name;
        Chance = chance;
        Effect = effect;
    }

    public string Name { get; set; }
    public int Chance { get; set; }
    public Action<Player> Effect { get; set; }

    /// <summary>
    /// Executes the <see cref="Effect"/> on the target <paramref name="target"/>
    /// </summary>
    /// <returns><see langword="true"/> if the effect was executed, <see langword="false"/> if not.</returns>
    public bool RollExecuteEffect(Player target)
    {
        var rngResult = new Random().Next(0, 100);
        if (rngResult < Chance)
        {
            Effect(target);
            return true;
        }
            return false;
    }
}
