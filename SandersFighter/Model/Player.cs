using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandersFighter.Model;

internal class Player
{
    public Player(string name, int hitPoints = 100)
    {
        Name = name;
        HitPoints = hitPoints;
    }

    public string Name { get; set; }
    public int HitPoints { get; set; }
    public Weapon Weapon { get; set; }
    public List<Condition> Conditions { get; set; } = new();
}
