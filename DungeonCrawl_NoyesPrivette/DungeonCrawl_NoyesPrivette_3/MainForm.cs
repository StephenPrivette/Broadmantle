/*
 * Stephen Privette
 * Chris Noyes
 * CSC-253
 * Dungeon Crawl
 * Fall 2017
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DungeonCrawl_NoyesPrivette.Class_Files;

namespace DungeonCrawl_NoyesPrivette
{
    public partial class MainForm : Form
    {
        // fields to hold lists of a list of each objects attributes. originally read from database.
        // this info will be used to create objects from each class except for casts and races,
        // those two lists will be used to fill in player objects attributes.

        private List<List<string>> _armorList;
        private List<List<string>> _castsList;
        private List<List<string>> _enemiesList;
        private List<List<string>> _lootList;
        private List<List<string>> _playersList;
        private List<List<string>> _potionsList;
        private List<List<string>> _racesList;
        private List<List<string>> _roomsList;
        private List<List<string>> _trinketsList;
        private List<List<string>> _weaponsList;

        // field to hold the name of active player brought over from intro form
        private string _startingPlayerName;

        // creating player object
        private Player player;

        private List<Room> roomObjectsList; //list to hold all rooms for easier manipualtion

        public MainForm()
        {
            InitializeComponent();

            // moved table adapter methods here cause we need the data on main form creation before form load

            // TODO: This line of code loads data into the 'objectsDataSet.Weapons' table. You can move, or remove it, as needed.
            this.weaponsTableAdapter.Fill(this.objectsDataSet.Weapons);
            // TODO: This line of code loads data into the 'objectsDataSet.Trinkets' table. You can move, or remove it, as needed.
            this.trinketsTableAdapter.Fill(this.objectsDataSet.Trinkets);
            // TODO: This line of code loads data into the 'objectsDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.objectsDataSet.Rooms);
            // TODO: This line of code loads data into the 'objectsDataSet.Races' table. You can move, or remove it, as needed.
            this.racesTableAdapter.Fill(this.objectsDataSet.Races);
            // TODO: This line of code loads data into the 'objectsDataSet.Potions' table. You can move, or remove it, as needed.
            this.potionsTableAdapter.Fill(this.objectsDataSet.Potions);
            // TODO: This line of code loads data into the 'objectsDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.objectsDataSet.Players);
            // TODO: This line of code loads data into the 'objectsDataSet.Loot' table. You can move, or remove it, as needed.
            this.lootTableAdapter.Fill(this.objectsDataSet.Loot);
            // TODO: This line of code loads data into the 'objectsDataSet.Enemies' table. You can move, or remove it, as needed.
            this.enemiesTableAdapter.Fill(this.objectsDataSet.Enemies);
            // TODO: This line of code loads data into the 'objectsDataSet.Casts' table. You can move, or remove it, as needed.
            this.castsTableAdapter.Fill(this.objectsDataSet.Casts);
            // TODO: This line of code loads data into the 'objectsDataSet.Armor' table. You can move, or remove it, as needed.
            this.armorTableAdapter.Fill(this.objectsDataSet.Armor);

            // initializing these object attribute lists in constructor so that they may also be used
            // by create player form when it creates an instance of this form.
            // if put in form load event entire form would have to be displayed in order for them to be accessed.
            // calling method to load object attributes from DB into lists of lists
            _armorList = loadClassFromDB("armor");
            _castsList = loadClassFromDB("cast");
            _enemiesList = loadClassFromDB("enemy");
            _lootList = loadClassFromDB("loot");
            _playersList = loadClassFromDB("player");
            _potionsList = loadClassFromDB("potion");
            _racesList = loadClassFromDB("race");
            _roomsList = loadClassFromDB("room");
            _trinketsList = loadClassFromDB("trinket");
            _weaponsList = loadClassFromDB("weapon");

            _startingPlayerName = "";
        }
    
        private void MainForm_Load(object sender, EventArgs e)
        {
            // initializing objects and displaying things here in load event so they will not
            // load when instance of this form is used elsewhere

            player = (Player)createObject("Player", _startingPlayerName);
            //displays states of inventory and player in list boxes
            displayPlayer();
            displayInventory();

            // initializing all rooms
            roomObjectsList = new List<Room>();

            // using create object method to create objects and then add them to each room
            roomObjectsList.Add((Room)createObject("Room", "Armory"));
            roomObjectsList[0].addEnemyToRoom((Enemy)createObject("Enemy", "Vermin"));
            roomObjectsList[0].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[0].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[0].addTreasureToChest((Trinket)createObject("Trinket", "Map"));
            roomObjectsList[0].addTreasureToChest((Weapon)createObject("Weapon", "Spear"));
            roomObjectsList[0].addTreasureToChest((Armor)createObject("Armor", "Chain Mail"));

            roomObjectsList.Add((Room)createObject("Room", "Crypt"));
            roomObjectsList[1].addEnemyToRoom((Enemy)createObject("Enemy", "Goblin"));
            roomObjectsList[1].addEnemyToRoom((Enemy)createObject("Enemy", "Hydra"));
            roomObjectsList[1].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[1].addTreasureToChest((Trinket)createObject("Trinket", "Lantern"));
            roomObjectsList[1].addTreasureToChest((Weapon)createObject("Weapon", "Axe"));
            roomObjectsList[1].addTreasureToChest((Loot)createObject("Loot", "Ruby"));

            roomObjectsList.Add((Room)createObject("Room", "Forge"));
            roomObjectsList[2].addEnemyToRoom((Enemy)createObject("Enemy", "Vermin"));
            roomObjectsList[2].addEnemyToRoom((Enemy)createObject("Enemy", "Goblin"));
            roomObjectsList[2].addEnemyToRoom((Enemy)createObject("Enemy", "Kobold"));
            roomObjectsList[2].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[2].addTreasureToChest((Weapon)createObject("Weapon", "Club"));
            roomObjectsList[2].addTreasureToChest((Loot)createObject("Loot", "Gold"));
            roomObjectsList[2].addTreasureToChest((Armor)createObject("Armor", "Full Plate"));

            roomObjectsList.Add((Room)createObject("Room", "Laboratory"));
            roomObjectsList[3].addEnemyToRoom((Enemy)createObject("Enemy", "Vermin"));
            roomObjectsList[3].addEnemyToRoom((Enemy)createObject("Enemy", "Goblin"));
            roomObjectsList[3].addEnemyToRoom((Enemy)createObject("Enemy", "Hydra"));
            roomObjectsList[3].addEnemyToRoom((Enemy)createObject("Enemy", "Kobold"));
            roomObjectsList[3].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[3].addTreasureToChest((Potion)createObject("Potion", "Life"));
            roomObjectsList[3].addTreasureToChest((Weapon)createObject("Weapon", "Sword"));

            roomObjectsList.Add((Room)createObject("Room", "Prison"));
            roomObjectsList[4].addEnemyToRoom((Enemy)createObject("Enemy", "Lich"));
            roomObjectsList[4].addTreasureToChest((Loot)createObject("Loot", "Trophy of Tribulation"));

            displayRoom(0); // displays armory to start game
        }

        // so starting player field can be set from intro form
        public string startingPlayerName
        {
            set { _startingPlayerName = value; }
        }

        // so create player form can retrieve info
        public List<List<string>> castsList
        {
            get { return _castsList; }
        }

        // so create player form can retrieve info
        public List<List<string>> racesList
        {
            get { return _racesList; }
        }

        // displays active player attributes to label and player list box
        private void displayPlayer()
        {
            playerDescLabel.Text = player.name;

            playerListBox.Items.Clear();

            playerListBox.Items.Add("Description: " + player.description);
            playerListBox.Items.Add("Cast: " + player.cast);
            playerListBox.Items.Add("Race: " + player.race);
            playerListBox.Items.Add("Health: " + player.health);
            playerListBox.Items.Add("Base Attack: " + player.attack);
            playerListBox.Items.Add("Total Attack: " + player.totalAttack);
            playerListBox.Items.Add("Base Defense: " + player.defense);
            playerListBox.Items.Add("Total Defense: " + player.totalDefense);
            playerListBox.Items.Add("");
            playerListBox.Items.Add("Weapon: " + player.equippedWeapon.name);
            playerListBox.Items.Add("Armor: " + player.equippedArmor.name);
            
        }

        // displays player inventory to inventory list box
        private void displayInventory()
        {
            // capturing the current inventory in a list for later comparison
            List<string> oldInventory = new List<string>();
            foreach (string i in inventoryListBox.Items)
            {
                oldInventory.Add(i);
            }

            inventoryListBox.Items.Clear();

            // creating flags for comparison
            bool outFlag = false;
            bool inFlag = false;
            // for each item in player inventory compare the old inventory to it.
            // if one item is not in the old inventory change the color to green
            // to signal new items
            // also using loop to add new inventory to list box
            foreach (Thing i in player.inventory)
            {
                inFlag = false;
                foreach (string old in oldInventory)
                {
                    if (old == i.name)
                    {
                        inFlag = true;
                    }
                }
                if (inFlag == false)
                {
                    outFlag = true;
                }
                inventoryListBox.Items.Add(i.name);
            }
            if (outFlag)
            {
                inventoryListBox.ForeColor = Color.GreenYellow;
            }
            else
            {
                inventoryListBox.ForeColor = Color.Beige;
            }
        }

        // loads a class's info from the database.
        // takes a string parameter to specify class
        private List<List<string>> loadClassFromDB(string name)
        {
            // list of lists to hold a class and then its different objects
            List<List<string>> x = new List<List<string>>();

            // iterates through the database's rows and returns a list of lists that
            // contain each object's attributes for the class name passed in
            switch (name)
            {
                case "armor":
                    foreach (DataRow row in objectsDataSet.Armor.Rows)
                    {
                        List<string> y = new List<string>();
                        foreach (DataColumn col in objectsDataSet.Armor.Columns)
                        {
                            y.Add(row[col].ToString());
                        }
                        x.Add(y);
                    }
                    return x;

                case "cast":
                    foreach (DataRow row in objectsDataSet.Casts.Rows)
                    {
                        List<string> y = new List<string>();
                        foreach (DataColumn col in objectsDataSet.Casts.Columns)
                        {
                            y.Add(row[col].ToString());
                        }
                        x.Add(y);
                    }
                    return x;

                case "enemy":
                    foreach (DataRow row in objectsDataSet.Enemies.Rows)
                    {
                        List<string> y = new List<string>();
                        foreach (DataColumn col in objectsDataSet.Enemies.Columns)
                        {
                            y.Add(row[col].ToString());
                        }
                        x.Add(y);
                    }
                    return x;

                case "loot":
                    foreach (DataRow row in objectsDataSet.Loot.Rows)
                    {
                        List<string> y = new List<string>();
                        foreach (DataColumn col in objectsDataSet.Loot.Columns)
                        {
                            y.Add(row[col].ToString());
                        }
                        x.Add(y);
                    }
                    return x;

                case "player":
                    foreach (DataRow row in objectsDataSet.Players.Rows)
                    {
                        List<string> y = new List<string>();
                        foreach (DataColumn col in objectsDataSet.Players.Columns)
                        {
                            y.Add(row[col].ToString());
                        }
                        x.Add(y);
                    }
                    return x;

                case "potion":
                    foreach (DataRow row in objectsDataSet.Potions.Rows)
                    {
                        List<string> y = new List<string>();
                        foreach (DataColumn col in objectsDataSet.Potions.Columns)
                        {
                            y.Add(row[col].ToString());
                        }
                        x.Add(y);
                    }
                    return x;

                case "race":
                    foreach (DataRow row in objectsDataSet.Races.Rows)
                    {
                        List<string> y = new List<string>();
                        foreach (DataColumn col in objectsDataSet.Races.Columns)
                        {
                            y.Add(row[col].ToString());
                        }
                        x.Add(y);
                    }
                    return x;

                case "room":
                    foreach (DataRow row in objectsDataSet.Rooms.Rows)
                    {
                        List<string> y = new List<string>();
                        foreach (DataColumn col in objectsDataSet.Rooms.Columns)
                        {
                            y.Add(row[col].ToString());
                        }
                        x.Add(y);
                    }
                    return x;

                case "trinket":
                    foreach (DataRow row in objectsDataSet.Trinkets.Rows)
                    {
                        List<string> y = new List<string>();
                        foreach (DataColumn col in objectsDataSet.Trinkets.Columns)
                        {
                            y.Add(row[col].ToString());
                        }
                        x.Add(y);
                    }
                    return x;

                case "weapon":
                    foreach (DataRow row in objectsDataSet.Weapons.Rows)
                    {
                        List<string> y = new List<string>();
                        foreach (DataColumn col in objectsDataSet.Weapons.Columns)
                        {
                            y.Add(row[col].ToString());
                        }
                        x.Add(y);
                    }
                    return x;

                default:
                    return x;
            }
        }

        // takes a room object parameter and displays its contents
        private void displayRoom(int index)
        {
            // changing current room to the room passed in
            foreach (Room i in roomObjectsList)
            {
                i.currentRoom = false;
            }

            roomObjectsList[index].currentRoom = true;

            roomDescLabel.Text = roomObjectsList[index].name; // room header
            enemyListBox.Items.Clear(); 
            treasureChestListBox.Items.Clear();
            // for every enemy in the rooms enemylist add it to list box
            foreach(Enemy i in roomObjectsList[index].enemiesList)
            {
                enemyListBox.Items.Add(i.name);
            }
            // for every item in the rooms treasureChestlist add it to list box
            foreach (Thing i in roomObjectsList[index].treasureChestList)
            {
                treasureChestListBox.Items.Add(i.name);
            }
        }

        // creates object instances
        private Thing createObject(string className, string objectName)
        {
            // the class name determines which object to create and which attributes to define
            switch (className)
            {
                case "Armor":
                    Armor armor1 = new Armor();
                    // for each list in the armorlist field
                    foreach (List<string> i in _armorList)
                    {
                        // if the name passed in and the name in the list match we have found our object
                        if (objectName == i[0])
                        {
                            armor1.name = i[0];
                            armor1.description = i[1];
                            armor1.defense = int.Parse(i[2]);
                        }
                    }
                    // returns the correct new object
                    return armor1;

                case "Enemy":
                    Enemy enemy1 = new Enemy();
                    // for each list in the enemieslist field
                    foreach (List<string> i in _enemiesList)
                    {
                        // if the name passed in and the name in the list match we have found our object
                        if (objectName == i[0])
                        {
                            enemy1.name = i[0];
                            enemy1.description = i[1];
                            enemy1.attack = int.Parse(i[2]);
                            enemy1.defense = int.Parse(i[3]);
                            enemy1.dexterity = int.Parse(i[4]);
                            enemy1.intelligence = int.Parse(i[5]);
                            enemy1.wisdom = int.Parse(i[6]);
                        }
                    }
                    // returns the correct new object
                    return enemy1;

                case "Loot":
                    Loot loot1 = new Loot();
                    // for each list in the lootlist field
                    foreach (List<string> i in _lootList)
                    {
                        // if the name passed in and the name in the list match we have found our object
                        if (objectName == i[0])
                        {
                            loot1.name = i[0];
                            loot1.description = i[1];
                        }
                    }
                    return loot1;

                case "Player":
                    Player player1 = new Player();
                    // for each list in the playerslist field
                    foreach (List<string> i in _playersList)
                    {
                        // if the name passed in and the name in the list match we have found our object
                        if (objectName == i[0])
                        {
                            player1.name = i[0];
                            player1.description = i[1];
                            player1.password = i[2];
                            player1.cast = i[3];
                            player1.race = i[4];
                            player1.victories = int.Parse(i[5]);

                            // if game has been beaten player starts out with the Trophy of Tribulation in their inventory
                            if (player1.victories > 0)
                            {
                                player1.pickUpItem((Loot)createObject("Loot", "Trophy of Tribulation"));
                            }

                            // adding super weapons and armor to any player named Riley or Steve
                            // so we can easily beat enemies for testing
                            if (objectName == "Steve" || objectName == "Riley")
                            {
                                Weapon superWeapon = new Weapon();
                                superWeapon.name = "God Sword";
                                superWeapon.description = "for testing purposes";
                                superWeapon.attack = 100;
                                player1.pickUpItem(superWeapon);

                                Armor superArmor = new Armor();
                                superArmor.name = "God Mail";
                                superArmor.description = "for testing purposes";
                                superArmor.defense = 100;
                                player1.pickUpItem(superArmor);
                            }
                        }
                    }

                    // each list in list is attributes for a certain object
                    foreach (List<string> cast in _castsList)
                    {
                        // if the cast type in player matches the name of the cast in list
                        if (cast[0] == player1.cast)
                        {
                            // adds attribues to player
                            player1.attack = int.Parse(cast[2]);
                            player1.defense = int.Parse(cast[3]);
                            player1.dexterity = int.Parse(cast[4]);
                            player1.intelligence = int.Parse(cast[5]);
                            player1.wisdom = int.Parse(cast[6]);
                        }
                    }

                    // each list in list is attributes for a certain object
                    foreach (List<string> race in _racesList)
                    {
                        // if the race type in player matches the name of the race in list
                        if (race[0] == player1.race)
                        {
                            // adds attributes to player
                            player1.attack += int.Parse(race[2]);
                            player1.defense += int.Parse(race[3]);
                            player1.dexterity += int.Parse(race[4]);
                            player1.intelligence += int.Parse(race[5]);
                            player1.wisdom += int.Parse(race[6]);
                        }
                    }
                    // returns the correct new object
                    return player1;

                case "Potion":
                    Potion potion1 = new Potion();
                    // for each list in the potionslist field
                    foreach (List<string> i in _potionsList)
                    {
                        // if the name passed in and the name in the list match we have found our object
                        if (objectName == i[0])
                        {
                            potion1.name = i[0];
                            potion1.description = i[1];
                            potion1.type = i[2];
                        }
                    }
                    return potion1;


                case "Room":
                    Room room1 = new Room();
                    // for each list in the roomslist field
                    foreach (List<string> i in _roomsList)
                    {
                        // if the name passed in and the name in the list match we have found our object
                        if (objectName == i[0])
                        {
                            room1.name = i[0];
                            room1.description = i[1];
                        }
                    }
                    return room1;

                case "Trinket":
                    Trinket trinket1 = new Trinket();
                    // for each list in the trinketslist field
                    foreach (List<string> i in _trinketsList)
                    {
                        // if the name passed in and the name in the list match we have found our object
                        if (objectName == i[0])
                        {
                            trinket1.name = i[0];
                            trinket1.description = i[1];
                        }
                    }
                    return trinket1;

                case "Weapon":
                    Weapon weapon1 = new Weapon();
                    // for each list in the weaponslist field
                    foreach (List<string> i in _weaponsList)
                    {
                        // if the name passed in and the name in the list match we have found our object
                        if (objectName == i[0])
                        {
                            weapon1.name = i[0];
                            weapon1.description = i[1];
                            weapon1.attack = int.Parse(i[2]);
                        }
                    }
                    return weapon1;

                // must have a default case for switch so makes a blank Thing and returns it
                // will never be used
                default:
                    Thing thing1 = new Thing();
                    return thing1;
            }
        }

        // advances player north to the next room
        private void northButton_Click(object sender, EventArgs e)
        {
            // if you're in the last room you can't go anymore north
            if(roomObjectsList[4].currentRoom == true)
            {
                MessageBox.Show("You have reached the end of the dungeon.");
                eventListBox.Items.Insert(0, "Can't leave just yet");
            }
            else
            {
                int index = 0;
                bool flag = false;
                // searching rooms to find which one you're in and capturing the index of that room
                // also capturing if that room's enemies are dead
                foreach (Room i in roomObjectsList)
                {
                    if (i.currentRoom == true)
                    {
                        index = roomObjectsList.IndexOf(i) + 1;
                        if (i.enemiesList.Count < 1)
                        {
                            flag = true;
                        }
                        else
                        {
                            MessageBox.Show("You must first defeat the enemies in this room.");
                            eventListBox.Items.Insert(0, "I wish I could walk through monsters too.");
                        }
                    }
                }
                if (flag == true)
                {
                    displayRoom(index);
                    eventListBox.Items.Insert(0, "You have moved North into the " + roomObjectsList[index].name + ".");
                }
            }
        }

        // moves player south to previous room
        private void southButton_Click(object sender, EventArgs e)
        {
            // if you're in the first room you can't move any further south
            if (roomObjectsList[0].currentRoom == true)
            {
                MessageBox.Show("There are no rooms south of this one.");
                eventListBox.Items.Insert(0, "Trying to leave already?");
            }
            else
            {
                int index = 0;
                // searching rooms to find which one you're in and capturing the index of that room
                foreach (Room i in roomObjectsList)
                {
                    if (i.currentRoom == true)
                    {
                        index = roomObjectsList.IndexOf(i) - 1;
                    }
                }
                displayRoom(index);
                eventListBox.Items.Insert(0, "You have moved South into the " + roomObjectsList[index].name + ".");
            }
        }

        // for displaying info in the info box
        private void enemyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoListBox.Items.Clear();
            if (enemyListBox.SelectedItem != null)
            {
                foreach (Room room in roomObjectsList)
                {
                    // finding current room
                    if (room.currentRoom == true)
                    {
                        // searching enemies in current room
                        foreach (Enemy enemy in room.enemiesList)
                        {
                            // if the name selected matches the enemy in the current room
                            if (enemyListBox.SelectedItem.ToString() == enemy.name)
                            {
                                // adds enemy info to list box 
                                infoListBox.Items.Add(enemy.name);
                                infoListBox.Items.Add(enemy.description);
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        // for displaying info in the info box
        private void treasureChestListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoListBox.Items.Clear();
            if (treasureChestListBox.SelectedItem != null)
            {
                foreach (Room room in roomObjectsList)
                {
                    // finding current room
                    if (room.currentRoom == true)
                    {
                        // searching treasures in current room
                        foreach (Thing treasure in room.treasureChestList)
                        {
                            // if the name selected matches the treasure in the current room
                            if (treasureChestListBox.SelectedItem.ToString() == treasure.name)
                            {
                                // adds treasure info to list box 
                                infoListBox.Items.Add(treasure.name);
                                infoListBox.Items.Add(treasure.description);
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        // for displaying info in the info box
        private void playerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoListBox.Items.Clear();
            if (playerListBox.SelectedItem != null)
            {
                // displaying selected items info
                if (playerListBox.SelectedItem.ToString().StartsWith("Des"))
                {
                    infoListBox.Items.Add("A description of");
                    infoListBox.Items.Add("your character");
                }
                else if (playerListBox.SelectedItem.ToString().StartsWith("Cas"))
                {
                    infoListBox.Items.Add("Your character's cast");
                }
                else if (playerListBox.SelectedItem.ToString().StartsWith("Rac"))
                {
                    infoListBox.Items.Add("Your character's race");
                }
                else if (playerListBox.SelectedItem.ToString().StartsWith("Hea"))
                {
                    infoListBox.Items.Add("Your character's health");
                }
                else if (playerListBox.SelectedItem.ToString().StartsWith("Base Att"))
                {
                    infoListBox.Items.Add("Your character's attack");
                    infoListBox.Items.Add("without a weapon");
                }
                else if (playerListBox.SelectedItem.ToString().StartsWith("Base Def"))
                {
                    infoListBox.Items.Add("Your character's defense");
                    infoListBox.Items.Add("without armor");
                }
                else if (playerListBox.SelectedItem.ToString().StartsWith("Wea"))
                {
                    infoListBox.Items.Add("Your character's");
                    infoListBox.Items.Add("equipped weapon");
                }
                else if (playerListBox.SelectedItem.ToString().StartsWith("Total Att"))
                {
                    infoListBox.Items.Add("Your character's attack");
                    infoListBox.Items.Add("with currently equipped");
                    infoListBox.Items.Add("weapon");
                }
                else if (playerListBox.SelectedItem.ToString().StartsWith("Arm"))
                {
                    infoListBox.Items.Add("Your character's");
                    infoListBox.Items.Add("equipped armor");
                }
                else if (playerListBox.SelectedItem.ToString().StartsWith("Total Def"))
                {
                    infoListBox.Items.Add("Your character's defense");
                    infoListBox.Items.Add("with currently equipped");
                    infoListBox.Items.Add("armor");
                }
                else
                {
                    infoListBox.Items.Add("");
                }
            }
        }

        // for displaying info in the info box
        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // changing color back to normal when player highlights anything in list box
            // in case color was green from new items
            inventoryListBox.ForeColor = Color.Beige;

            infoListBox.Items.Clear();
            if (inventoryListBox.SelectedItem != null)
            {
                // searching items in player inventory
                foreach (Thing item in player.inventory)
                {
                    // if the name selected matches the item
                    if (inventoryListBox.SelectedItem.ToString() == item.name)
                    {
                        // adds item info to list box 
                        infoListBox.Items.Add(item.name);
                        infoListBox.Items.Add(item.description);
                        break;
                    }
                }
            }
        }

        // starts a battle form
        private void fightButton_Click(object sender, EventArgs e)
        {
            // making sure an enemy was selected
            if(enemyListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You haven't selected an enemy to fight.");
                eventListBox.Items.Insert(0, "Trying to fight a ghost?");
            }
            else
            {
                int roomIndex = 0;
                int enemyIndex = 0;

                // finding current room and recording the index where it exists in roomObjectsList to roomIndex
                foreach (Room i in roomObjectsList)
                {
                    if (i.currentRoom)
                    {
                        roomIndex = roomObjectsList.IndexOf(i);
                        // finding the selected enemy to fight in enemyListBox and
                        // recording the index of where it exists in the current room's
                        // enemiesList to enemyIndex
                        foreach (Enemy enem in i.enemiesList)
                        {
                            if (enemyListBox.SelectedItem.ToString() == enem.name)
                            {
                                enemyIndex = i.enemiesList.IndexOf(enem);
                            }
                        }
                    }
                }

                // creating new battle object and using roomIndex and enemyIndex to pass correct enemy
                BattleForm battleForm1 = new BattleForm();
                battleForm1.battlePlayer = player;
                battleForm1.battleEnemy = roomObjectsList[roomIndex].enemiesList[enemyIndex];
                // hide and show so main form will not be displayed while battle form is up
                this.Hide();
                battleForm1.ShowDialog(); // showing battle field
                this.Show();

                // after battle if you are dead its game over
                if (player.health < 1)
                {
                    MessageBox.Show("Your quest is over.");
                    this.Close();
                }

                // after battle if enemy is dead                
                if (roomObjectsList[roomIndex].enemiesList[enemyIndex].health < 1)
                {
                    roomObjectsList[roomIndex].removeEnemyFromRoom(roomObjectsList[roomIndex].enemiesList[enemyIndex]);
                    eventListBox.Items.Insert(0, "Victory!");
                }
                // if enemy is not dead it means you ran
                else
                {
                    if (player.newGamePlus)
                    {
                        eventListBox.Items.Insert(0, "Since you have used the");
                        eventListBox.Items.Insert(1, "trophy running only further");
                        eventListBox.Items.Insert(2, "strengthens the enemy!");
                    }
                    else
                    {
                        eventListBox.Items.Insert(0, "Not your finest hour.");
                    }
                }

                // if you have defeated all the enemies in the room you get the treasure chest
                if (roomObjectsList[roomIndex].enemiesList.Count < 1)
                {
                    while(roomObjectsList[roomIndex].treasureChestList.Count > 0)
                    {
                        player.pickUpItem(roomObjectsList[roomIndex].treasureChestList[0]);
                        roomObjectsList[roomIndex].removeTreasureFromChest(roomObjectsList[roomIndex].treasureChestList[0]);
                    }
                    eventListBox.Items.Insert(0, "The glorious treasure chest is yours!");

                    // if you have defeated all the enemies in a room and it's the last room
                    // you've beaten the game
                    if (roomIndex == 4)
                    {
                        player.victories += 1;

                        foreach (DataRow row in objectsDataSet.Players.Rows)
                        {
                            if (row["Name"].ToString() == player.name)
                            {
                                row["Victories"] = player.victories;
                            }
                        }
                        this.tableAdapterManager.UpdateAll(this.objectsDataSet);

                        MessageBox.Show("You have conquered Broadmantle!");
                        this.Close();
                    }
                }

                displayInventory();
                displayPlayer();
                displayRoom(roomIndex);

                infoListBox.Items.Clear(); //clearing out info box 
            }
        }

        // equips a weapon or armor
        private void equipButton_Click(object sender, EventArgs e)
        {
            // making sure an item was selected
            if (inventoryListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You haven't selected anything to Equip. Select an item from the inventory.");
                eventListBox.Items.Insert(0, "Can't equip nothing.");
            }
            // if user selected a weapon equip it
            else if (player.inventory[inventoryListBox.SelectedIndex] is Weapon)
            {
                eventListBox.Items.Insert(0, "You have equipped the " + player.inventory[inventoryListBox.SelectedIndex].name + " weapon.");
                player.equipWeapon((Weapon)player.inventory[inventoryListBox.SelectedIndex]);
                displayPlayer();
                displayInventory();
                infoListBox.Items.Clear(); //clearing out info box
            }
            // if user selected armor equip it
            else if (player.inventory[inventoryListBox.SelectedIndex] is Armor)
            {
                eventListBox.Items.Insert(0, "You have equipped the " + player.inventory[inventoryListBox.SelectedIndex].name + " armor.");
                player.equipArmor((Armor)player.inventory[inventoryListBox.SelectedIndex]);
                displayPlayer();
                displayInventory();
                infoListBox.Items.Clear(); //clearing out info box
            }
            // otherwise it can't be equipped
            else
            {
                MessageBox.Show("This inventory item cannot be equipped.");
                eventListBox.Items.Insert(0, "That would be a strange sight indeed.");
            }
        }

        // unequips a weapon or armor
        private void unequipButton_Click(object sender, EventArgs e)
        {
            // making sure something is selected
            if (playerListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You haven't selected anything to unequip. Select an equipped weapon or armor from your player display.");
                eventListBox.Items.Insert(0, "Can't unequip nothing.");
            }
            // if its a weapon unequip it unless its bare hands
            else if (playerListBox.SelectedItem.ToString().StartsWith("Wea"))
            {
                if (player.equippedWeapon.name == "Bare Hands")
                {
                    MessageBox.Show("There is no weapon to unequip.");
                    eventListBox.Items.Insert(0, "I guess you could cut off your hands.");
                }
                else
                {
                    player.unequipWeapon();
                    displayPlayer();
                    displayInventory();
                    infoListBox.Items.Clear(); //clearing out info box 
                    eventListBox.Items.Insert(0, "I never liked that weapon anyway.");
                }
            }
            // if its armor unequip it unless its clothes
            else if (playerListBox.SelectedItem.ToString().StartsWith("Arm"))
            {
                if (player.equippedArmor.name == "Clothes")
                {
                    MessageBox.Show("There is no armor to unequip.");
                    eventListBox.Items.Insert(0, "No one wants to see that.");
                }
                else
                {
                    player.unequipArmor();
                    displayPlayer();
                    displayInventory();
                    infoListBox.Items.Clear(); //clearing out info box 
                    eventListBox.Items.Insert(0, "I never liked that armor anyway.");
                }
            }
            // otherwise it can't be unequipped
            else
            {
                MessageBox.Show("This cannot be unequipped. Select your equipped weapon or armor.");
                eventListBox.Items.Insert(0, "That would be weird.");
            }
        }

        // uses items from inventory
        private void useItemButton_Click(object sender, EventArgs e)
        {
            // making sure a selection is made
            if (inventoryListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You haven't selected an item to use.");
                eventListBox.Items.Insert(0, "Can't use nothing.");
            }
            // can't use weapons
            else if (player.inventory[inventoryListBox.SelectedIndex] is Weapon)
            {
                MessageBox.Show("A weapon cannot be used like this.");
                eventListBox.Items.Insert(0, "Are you crazy?");
            }
            // can't use armor
            else if (player.inventory[inventoryListBox.SelectedIndex] is Armor)
            {
                MessageBox.Show("Armor cannot be used like this.");
                eventListBox.Items.Insert(0, "I guess if it's Halloween maybe.");
            }
            // can't use loot unless its the trophy of tribulation
            else if (player.inventory[inventoryListBox.SelectedIndex] is Loot)
            {
                if (player.inventory[inventoryListBox.SelectedIndex].name == "Trophy of Tribulation")
                {
                    // activates new game plus
                    eventListBox.Items.Insert(0, "You have used the Trophy of");
                    eventListBox.Items.Insert(1, "Tribulation... I'm not sure that");
                    eventListBox.Items.Insert(2, "was a good idea.");
                    player.newGamePlus = true;
                    player.dropItem(player.inventory[inventoryListBox.SelectedIndex]);
                    displayPlayer();
                    displayInventory();
                    infoListBox.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Loot cannot be used.");
                    eventListBox.Items.Insert(0, "Looks nice though.");
                }
            }
            // adds 5 to health
            else if (player.inventory[inventoryListBox.SelectedIndex] is Potion)
            {
                eventListBox.Items.Insert(0, "You have used the " + player.inventory[inventoryListBox.SelectedIndex].name + " potion.");
                player.usePotion((Potion)player.inventory[inventoryListBox.SelectedIndex]);
                displayPlayer();
                displayInventory();
                infoListBox.Items.Clear();
            }
            // each trinket has a different effect
            else if (player.inventory[inventoryListBox.SelectedIndex] is Trinket)
            {
                // shows contents of room ahead
                if (player.inventory[inventoryListBox.SelectedIndex].name == "Map")
                {
                    int count = 0;
                    int mapIndex = 0;
                    foreach (Room i in roomObjectsList)
                    {
                        if (i.currentRoom)
                        {
                            mapIndex = count + 1;
                        }
                        count += 1;
                    }

                    // if you're trying to view past the last room you can't
                    if (mapIndex == 5)
                    {
                        MessageBox.Show("There are no more rooms ahead to view.");
                        eventListBox.Items.Insert(0, "You have used the Map.");
                        player.dropItem(player.inventory[inventoryListBox.SelectedIndex]);
                        displayPlayer();
                        displayInventory();
                        infoListBox.Items.Clear(); //clearing out info box 
                    }
                    else
                    {
                        // if the room has already been revealed
                        if (roomObjectsList[mapIndex - 1].treasureChestList.Count < 1)
                        {
                            MessageBox.Show("You can already see the " + roomObjectsList[mapIndex].name + ".");
                            eventListBox.Items.Insert(0, "Just go up there and look at it.");
                        }
                        // tells you contents of room in a message box
                        else
                        {
                            Room mr = roomObjectsList[mapIndex];
                            MessageBox.Show("The next room north is the " + mr.name + "." + System.Environment.NewLine
                                + "One of the enemies is a " + mr.enemiesList[0].name + "." + System.Environment.NewLine
                                + "The treasure chest contains a " + mr.treasureChestList[0].name + ".");
                            eventListBox.Items.Insert(0, "You have used the Map.");
                            player.dropItem(player.inventory[inventoryListBox.SelectedIndex]);
                            displayPlayer();
                            displayInventory();
                            infoListBox.Items.Clear(); //clearing out info box
                        }
                    }
                }
                // gives you hidden items
                else if (player.inventory[inventoryListBox.SelectedIndex].name == "Lantern")
                {
                    // if you're in the first room you get the hidden items
                    if (roomObjectsList[0].currentRoom)
                    {
                        player.pickUpItem(createObject("Potion", "Life"));
                        player.pickUpItem(createObject("Potion", "Life"));
                        player.dropItem(player.inventory[inventoryListBox.SelectedIndex]);
                        eventListBox.Items.Insert(0, "You found hidden items!");
                        displayPlayer();
                        displayInventory();
                        infoListBox.Items.Clear(); //clearing out info box
                    }
                    // else there are none
                    else
                    {
                        eventListBox.Items.Insert(0, "Hmm nothing here.");
                    }
                }
            }
            else
            {
                displayPlayer();
                displayInventory();
                infoListBox.Items.Clear(); //clearing out info box 
            }
        }

        // drops items from inventory
        private void dropItemButton_Click(object sender, EventArgs e)
        {
            // making sure something is selected from player inventory
            if (inventoryListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You haven't selected an item to drop.");
                eventListBox.Items.Insert(0, "Can't throw away what's already gone.");
            }
            //removes item
            else
            {
                eventListBox.Items.Insert(0, "You toss the " + player.inventory[inventoryListBox.SelectedIndex].name + " into the abyss.");
                player.dropItem(player.inventory[inventoryListBox.SelectedIndex]);
                displayPlayer();
                displayInventory();
                infoListBox.Items.Clear(); //clearing out info box 
            }
        }
    }
}
