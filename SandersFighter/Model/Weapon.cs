// Ignore Spelling: Inflictor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandersFighter.Model;

internal class Weapon
{
    public Weapon(string name, int damage, ConditionInflictor inflictor)
    {
        Name = name;
        Damage = damage;
        Inflictor = inflictor;
    }

    public string Name { get; set; }
    public int Damage { get; set; }
    public ConditionInflictor Inflictor { get; set; }
}
