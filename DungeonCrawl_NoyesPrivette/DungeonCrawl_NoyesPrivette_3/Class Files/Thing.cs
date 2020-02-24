using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl_NoyesPrivette.Class_Files
{
    public class Thing : Object
    {
        private string _name;
        private string _description;

        public Thing()
        {
            _name = "";
            _description = "";
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
    }

}
