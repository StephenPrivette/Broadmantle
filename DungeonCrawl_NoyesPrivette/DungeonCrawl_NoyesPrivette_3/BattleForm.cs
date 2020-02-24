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
using DungeonCrawl_NoyesPrivette.Class_Files;

namespace DungeonCrawl_NoyesPrivette
{
    public partial class BattleForm : Form
    {
        // fields to contain player and enemy. will eventually be brought over from main form
        private Enemy _battleEnemy;
        private Player _battlePlayer;

        // to count the line number in the combat label for clarity
        private int lineCount = 0;

        public BattleForm()
        {
            InitializeComponent();
        }

        // sets for enemy and player so they can be brought over from main form
        public Player battlePlayer
        {
            set { _battlePlayer = value; }
        }

        public Enemy battleEnemy
        {
            set { _battleEnemy = value; }
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {
            // if player used the trophy of tribulation the enemy is buffed
            if (_battlePlayer.newGamePlus)
            {
                _battleEnemy.attack += 2;
                _battleEnemy.defense += 1;
                combatOutputLabel.Text = "The Trophy of Tribulation has strengthened the enemy!" + System.Environment.NewLine + combatOutputLabel.Text;
            }
            // displaying stats of enemy and player when form loads
            displayStats();
        }
        
        // displays enemy and player stats in appropriate labels
        private void displayStats()
        {
            enemyNameLabel.Text = _battleEnemy.name;
            enemyHealthLabel.Text = _battleEnemy.health.ToString();
            enemyAttackLabel.Text = _battleEnemy.attack.ToString();
            enemyDefenseLabel.Text = _battleEnemy.defense.ToString();

            playerNameLabel.Text = _battlePlayer.name;
            playerHealthLabel.Text = _battlePlayer.health.ToString();
            playerAttackLabel.Text = _battlePlayer.totalAttack.ToString();
            playerDefenseLabel.Text = _battlePlayer.totalDefense.ToString();
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            // for attack
            Random rand = new Random();

            // player attacks enemy first. take player's total attack plus or minus 2.
            // then take that and subtract the enemy's defense and that gives us the hit
            int hitOnEnemy = _battlePlayer.totalAttack + rand.Next(-2, 2) - _battleEnemy.defense;
            // if the player hits the enemy for less than 1 we say its a miss for 0
            if (hitOnEnemy < 1)
            {
                lineCount += 1;
                combatOutputLabel.Text = "Round " + lineCount.ToString() + ". " + _battlePlayer.name + " misses. " + System.Environment.NewLine + combatOutputLabel.Text;
            }
            else
            {
                // enemy's health is reduced by the hit amount
                _battleEnemy.health -= hitOnEnemy;
                lineCount += 1;
                combatOutputLabel.Text = "Round " + lineCount.ToString() + ". " + _battlePlayer.name + " hits " + _battleEnemy.name + " for " + hitOnEnemy + ". " + System.Environment.NewLine + combatOutputLabel.Text;
            }

            // if enemy is still alive
            if (_battleEnemy.health > 0)
            {
                // enemy attacks player next. take enemy's attack plus or minus 2.
                // then take that and subtract the enemy's defense and that gives us the hit
                int hitOnPlayer = _battleEnemy.attack + rand.Next(-2, 2) - _battlePlayer.totalDefense;
                // if the enemy hits the player for less than 1 we say its a miss for 0
                if (hitOnPlayer < 1)
                {
                    lineCount += 1;
                    combatOutputLabel.Text = "Round " + lineCount.ToString() + ". " + _battleEnemy.name + " misses. " + System.Environment.NewLine + combatOutputLabel.Text;
                }
                else
                {
                    // player's health is reduced by the hit amount
                    _battlePlayer.health -= hitOnPlayer;
                    lineCount += 1;
                    combatOutputLabel.Text = "Round " + lineCount.ToString() + ". " + _battleEnemy.name + " hits " + _battlePlayer.name + " for " + hitOnPlayer + ". " + System.Environment.NewLine + combatOutputLabel.Text;
                }
            }
            else // enemy must be dead
            {
                MessageBox.Show(_battleEnemy.name + " has been defeated by " + _battlePlayer.name + ".");
                _battleEnemy.health = 0; // health could be less than zero so we say its zero
                //close the form.
                this.Close();
            }

            // if enemy hit kills player
            if (_battlePlayer.health < 1)
            {
                MessageBox.Show("You have been defeated by " + _battleEnemy.name + ".");
                _battlePlayer.health = 0; // health could be less than zero so we say its zero
                //close the form.
                this.Close();
            }
            else // enemy and player must have survived so we displayed the new stats and end round
            {
                displayStats();
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // if you run away enemy recovers back to full health but you do not
            _battleEnemy.health = 10;
            this.Close();
        }
    }
}