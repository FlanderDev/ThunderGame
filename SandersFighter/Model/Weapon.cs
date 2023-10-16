// Ignore Spelling: Inflictor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SandersFighter.Model;

internal class Weapon
{
    internal static Weapon Fist = new("Fist", (4,4), null);

    public Weapon(string name, (int Min, int Max) damageRange, ConditionInflictor? inflictor)
    {
        Name = name;
        DamageRange = damageRange;
        Inflictor = inflictor;
    }

    public string Name { get; set; }
    public (int Min, int Max) DamageRange { get; set; }
    public ConditionInflictor? Inflictor { get; set; }

    public int RollDamage()
    {
        var rng = new Random();
        return rng.Next(DamageRange.Min, DamageRange.Max);
    }
}
