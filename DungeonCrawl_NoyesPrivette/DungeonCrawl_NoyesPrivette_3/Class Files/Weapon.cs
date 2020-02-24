using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl_NoyesPrivette.Class_Files
{
    public class Weapon : Thing
    {
        private int _attack;

        public Weapon()
        {
            _attack = 0;
        }

        public int attack
        {
            get { return _attack; }
            set { _attack = value; }
        }
    }
}
