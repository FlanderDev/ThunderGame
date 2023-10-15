// Ignore Spelling: Inflictor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandersFighter.Model;

internal class ConditionInflictor
{
    public ConditionInflictor(int chance, Condition condition)
    {
        Chance = chance;
        Condition = condition;
    }

    public int Chance { get; set; }
    public Condition Condition { get; set; }
}
