using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandersFighter.Model;

internal class Player
{
    public Player(string name, int hitPoints = 100, int actions = 1)
    {
        Name = name;
        HitPoints = hitPoints;
        Actions = actions;
    }

    public string Name { get; set; }
    public int HitPoints { get; set; }
    public int Actions { get; set; }
    public Weapon Weapon { get; set; } = Weapon.Fist;
    public List<Condition> Conditions { get; set; } = new();

    public List<string> DoTurn(Player target)
    {
        var combatLog = Attack(target);

        Actions = 1;
        return combatLog;
    }

    private List<string> Attack(Player target)
    {
        var combatLog = new List<string>();

        if (HitPoints <= 0)
        {
            combatLog.Add($"{Name} has died.");
            return combatLog;
        }

        if (Actions == 0)
        {
            combatLog.Add($"{Name} is stunned and can't attack.");
            return combatLog;
        }

        var dmg = Weapon.RollDamage();
        target.HitPoints -= dmg;

        combatLog.Add($"{Name} has dealt {dmg} damage with his {Weapon.Name} to {target.Name}, which has {target.HitPoints} left.");

        if (Weapon.Inflictor?.Condition.RollExecuteEffect(target) ?? false)
            combatLog.Add($"{Name} used {Weapon.Name} to {Weapon.Inflictor.Condition.Name} {target.Name}.");

        return combatLog;
    }
}
