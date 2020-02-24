using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl_NoyesPrivette.Class_Files
{
    public class Potion : Thing
    {
        private string _type;

        public Potion()
        {
            _type = "Health";
        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
