using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl_NoyesPrivette.Class_Files
{
    public class Enemy : Thing
    {
        private int _health, _attack, _defense, _dexterity, _intelligence, _wisdom;

        public Enemy()
        {
            _health = 10;

            _attack = 0;
            _defense = 0;
            _dexterity = 0;
            _intelligence = 0;
            _wisdom = 0;
        }

        public int health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        public int defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public int dexterity
        {
            get { return _dexterity; }
            set { _dexterity = value; }
        }

        public int intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }

        public int wisdom
        {
            get { return _wisdom; }
            set { _wisdom = value; }
        }
    }
}
