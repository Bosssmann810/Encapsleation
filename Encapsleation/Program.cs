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
        public void takeDmg(int amount)
        {
            _hp -= amount;
        }
        public void levelUp()
        {
            _level++;
        }
        public void printStats()
        {
            Console.WriteLine($"Name: {_name} Health: {_hp} Level: {_level} ");
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
