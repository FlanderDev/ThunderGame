using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandersFighter.Model;

internal class Turn
{
    public Turn(int number, params string[] combatLog)
    {
        Number = number;
        CombatLog.AddRange(combatLog);
    }

    public int Number { get; set; }
    public List<string> CombatLog { get; set; } = new();
}
