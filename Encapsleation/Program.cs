using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsleation
{
    class Program
    {
        static void Main()
        {
            Player player1 = new Player(health: 100, lv: 1, name: "");
            Player player2 = new Player(health: 100, lv: 1, name: "");
            Console.WriteLine("Player 1. Please enter your name: ");
            player1.SetName(Console.ReadLine());
            player1.PrintStats();
            Console.WriteLine();
            Console.WriteLine("Player 2. Please enter your name: ");
            player2.SetName(Console.ReadLine());
            player2.PrintStats();
            Console.ReadKey();
            Console.Clear();
            player1.TakeDmg(20);
            Console.WriteLine("Player 1 took 20 damage");
            player1.PrintStats();
            player2.LevelUp();
            Console.WriteLine("Player 2 leveled up!");
            player2.PrintStats();
            Console.ReadKey();
        }
    }
    class Player
    {
        int _hp;
        int _level;
        string _name;
        
        public Player(int health, int lv, string name)
        {
            _hp = health;
            _level = lv;
            _name = name;
        }
        public void TakeDmg(int amount)
        {
            _hp -= amount;
        }
        public void LevelUp()
        {
            _level++;
        }
        public void PrintStats()
        {
            Console.WriteLine($"Name: {_name} Health: {_hp} Level: {_level} ");
        }
        public void SetName(string newname)
        {
            _name = newname;
        } 

    }
    //classes let you make multiple things that work seperate from one another, like code a prefab.
    /*
    class Enemy
    {
        public Enemy(int health, int x, int y)
        {
            _hp = health;
            _posx = x;
            _posy = y;
        }
        //if the variables are private they CAN NOT BE ACSESSED without a method
        int _hp;
        int _posx;
        int _posy;
        int _dmg;
        bool _isalive;
        public void death()
        {
            if (_hp <= 0)
            {
                _isalive = false;
            }
        }
        public int gethp()
        {
            //this is the only way to get a private variable in a class
            return _hp;
        }
    }
    */
}
