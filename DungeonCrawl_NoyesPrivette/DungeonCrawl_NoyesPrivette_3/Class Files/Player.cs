using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl_NoyesPrivette.Class_Files
{
    public class Player : Thing
    {
        private int _health, _mana, _attack, _defense, _dexterity, _intelligence, _wisdom, _victories;
        private string _password, _cast, _race;
        private List<Thing> _inventory;
        private Weapon _bareHands;
        private Weapon _equippedWeapon;
        private Armor _clothes;
        private Armor _equippedArmor;
        private bool _newGamePlus;

        public Player()
        {
            _password = "";

            _cast = "Warrior";
            _race = "Human";

            _health = 10;
            _mana = 10;

            _attack = 0;
            _defense = 0;
            _dexterity = 0;
            _intelligence = 0;
            _wisdom = 0;
            _victories = 0;

            _inventory = new List<Thing>();

            _bareHands = new Weapon();
            _bareHands.name = "Bare Hands";

            _equippedWeapon = _bareHands;

            _clothes = new Armor();
            _clothes.name = "Clothes";

            _equippedArmor = _clothes;

            _newGamePlus = false;
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string cast
        {
            get { return _cast; }
            set { _cast = value; }
        }

        public string race
        {
            get { return _race; }
            set { _race = value; }
        }

        public int health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int mana
        {
            get { return _mana; }
            set { _mana = value; }
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

        public int victories
        {
            get { return _victories; }
            set { _victories = value; }
        }

        public Weapon equippedWeapon
        {
            get { return _equippedWeapon; }
        }

        public int totalAttack
        {
            get { return _attack + _equippedWeapon.attack; }
        }

        public Armor equippedArmor
        {
            get { return _equippedArmor; }
        }

        public int totalDefense
        {
            get { return _defense + _equippedArmor.defense; }
        }

        public List<Thing> inventory
        {
            get { return _inventory; }
        }

        public bool newGamePlus
        {
            get { return _newGamePlus; }
            set { _newGamePlus = value; }
        }

        public void pickUpItem (Thing item)
        {
            _inventory.Add(item);
        }

        public void dropItem (Thing item)
        {
            _inventory.Remove(item);
        }

        public void equipWeapon (Weapon weapon)
        {
            if (_equippedWeapon != _bareHands)
            {
                _inventory.Add(_equippedWeapon);
            }
            _equippedWeapon = weapon;
            _inventory.Remove(weapon);
        }

        public void unequipWeapon()
        {
            if (_equippedWeapon != _bareHands)
            {
                _inventory.Add(_equippedWeapon);
            }

            _equippedWeapon = _bareHands;
        }

        public void equipArmor (Armor armor)
        {
            if (_equippedArmor != _clothes)
            {
                _inventory.Add(_equippedArmor);
            }
            _equippedArmor = armor;
            _inventory.Remove(armor);
        }

        public void unequipArmor()
        {
            if (_equippedArmor != _clothes)
            {
                _inventory.Add(_equippedArmor);
            }

            _equippedArmor = _clothes;
        }

        public void usePotion(Potion potion)
        {
            _health += 5;
            if (_health > 10)
            {
                _health = 10;
            }
            _inventory.Remove(potion);
        }
    }
}
