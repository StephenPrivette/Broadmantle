using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl_NoyesPrivette.Class_Files
{
    public class Room : Thing
    {
        private List<Thing> _treasureChestList;
        private List<Enemy> _enemiesList;

        private bool _currentRoom;

        public Room()
        {
            _treasureChestList = new List<Thing>();
            _enemiesList = new List<Enemy>();
            _currentRoom = false;
        }

        public List<Thing> treasureChestList
        {
            get { return _treasureChestList; }
        }

        public List<Enemy> enemiesList
        {
            get { return _enemiesList; }
        }

        public void addTreasureToChest(Thing thing)
        {
            _treasureChestList.Add(thing);
        }

        public void removeTreasureFromChest(Thing thing)
        {
            _treasureChestList.Remove(thing);
        }

        public void addEnemyToRoom(Enemy enemy)
        {
            _enemiesList.Add(enemy);
        }

        public void removeEnemyFromRoom(Enemy enemy)
        {
            _enemiesList.Remove(enemy);
        }

        public bool currentRoom
        {
            get { return _currentRoom; }
            set { _currentRoom = value; }
        }
    }
}
