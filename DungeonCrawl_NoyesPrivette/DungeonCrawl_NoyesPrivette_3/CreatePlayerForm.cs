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
    public partial class CreatePlayerForm : Form
    {
        // lists to hold cast and race attributes from main form
        private List<List<string>> castsList;
        private List<List<string>> racesList;

        public CreatePlayerForm()
        {
            InitializeComponent();

            // creating a mainform object to retrieve casts and races lists from it
            MainForm mainForm1 = new MainForm();
            castsList = mainForm1.castsList;
            racesList = mainForm1.racesList;
            // adding casts and races names to combo boxes
            foreach (List<string> cast in castsList)
            {
                castComboBox.Items.Add(cast[0]);
            }
            foreach (List<string> race in racesList)
            {
                raceComboBox.Items.Add(race[0]);
            }
        }

        private void CreatePlayerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'objectsDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.objectsDataSet.Players);

        }

        // if password is valid returns true
        private bool passVal (string password)
        {
            // flags for each condition
            bool upper = false;
            bool lower = false;
            bool special = false;

            // validating password length
            if (password.Length < 3 || password.Length > 10)
            {
                return false;
            }
            else
            {
                // for every char in password check to see if it meets each condition. if so that flag is true
                foreach (char ch in password)
                {
                    if (Char.IsUpper(ch))
                    {
                        upper = true;
                    }

                    if (Char.IsLower(ch))
                    {
                        lower = true;
                    }

                    if (!Char.IsLetterOrDigit(ch))
                    {
                        special = true;
                    }
                }

                // if all conditions are met then password is valid and method returns true
                if (upper == true && lower == true && special == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            // comparing name with name of players that already exist
            bool flag = false;
            foreach (DataRow i in objectsDataSet.Players.Rows)
            {
                if (nameTextBox.Text == i["Name"].ToString())
                {
                    flag = true;
                }
            }

            // password validation
            if (passVal(passTextBox.Text))
            {
                // name and description validation
                if (nameTextBox.Text.Length > 0 && nameTextBox.Text.Length < 16 &&
                    descTextBox.Text.Length > 0 && descTextBox.Text.Length < 16)
                {
                    // making sure name of new player doesn't already exist in a saved player
                    if (flag == false)
                    {
                        // making sure something was selected from race and cast combo boxes
                        if (castComboBox.SelectedIndex > -1 && raceComboBox.SelectedIndex > -1)
                        {
                            // adding a new row to players table containing the user selections for player and saving it to DB
                            DataRow row = objectsDataSet.Players.NewRow();
                            row["Name"] = nameTextBox.Text;
                            row["Description"] = descTextBox.Text;
                            row["Password"] = passTextBox.Text;
                            row["Cast"] = castComboBox.SelectedItem;
                            row["Race"] = raceComboBox.SelectedItem;
                            row["Victories"] = 0;
                            objectsDataSet.Players.Rows.Add(row);
                            this.tableAdapterManager.UpdateAll(this.objectsDataSet);

                            MessageBox.Show("You have created a new character!");
                            this.Close(); // closing form to return to intro form
                        }
                        else
                        {
                            MessageBox.Show("You must select a cast and race");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is already a player with this name.");
                    }   
                }
                else
                {
                    MessageBox.Show("Please make sure name and description meet criteria");
                }
            }
            else
            {
                MessageBox.Show("Please make sure password meets criteria");
            }
        }

        private void castComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // displaying each cast attribute when user changes selection
            // uses the information originally brought over from a main form instance
            castListBox.Items.Clear();
            
            castListBox.Items.Add("Name: " + castsList[castComboBox.SelectedIndex][0]);
            castListBox.Items.Add("Description: " + castsList[castComboBox.SelectedIndex][1]);
            castListBox.Items.Add("Attack: " + castsList[castComboBox.SelectedIndex][2]);
            castListBox.Items.Add("Defense: " + castsList[castComboBox.SelectedIndex][3]);
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // displaying each race attribute when user changes selection
            // uses the information originally brought over from a main form instance
            raceListBox.Items.Clear();

            raceListBox.Items.Add("Name: " + racesList[raceComboBox.SelectedIndex][0]);
            raceListBox.Items.Add("Description: " + racesList[raceComboBox.SelectedIndex][1]);
            raceListBox.Items.Add("Attack: " + racesList[raceComboBox.SelectedIndex][2]);
            raceListBox.Items.Add("Defense: " + racesList[raceComboBox.SelectedIndex][3]);
        }
    }
}