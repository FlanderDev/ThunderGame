using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandersFighter.Model;

internal class Game
{
    private int _turnCounter;


    public int Id { get; set; }
    public List<Player> Players { get; set; } = new();
    public List<Turn> Turns { get; set; } = new();

    public void RunGame()
    {

    }
}
