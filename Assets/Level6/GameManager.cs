using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameManager
{
    static GameManager _instance = new GameManager();
    public static GameManager Instance => _instance;
    private GameManager() { }


    Player _player;
    List<firing> _enemies = new List<firing>();

    public Player Player => _player;
    public List<firing> Enemies => _enemies;

    public void Register(Player p) { _player = p; }
    public void Register(firing e) { _enemies.Add(e); }
    public void Remove(firing e) { _enemies.Remove(e); }
}
