using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl_NoyesPrivette.Class_Files
{
    public class Armor : Thing
    {
        private int _defense;

        public Armor()
        {
            _defense = 0;
        }

        public int defense
        {
            get { return _defense; }
            set { _defense = value; }
        }
    }
}
