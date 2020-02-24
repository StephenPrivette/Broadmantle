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
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'objectsDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.objectsDataSet.Players);
            // loads players in combo box
            loadPlayers();
        }

        // loads saved players from DB into combo box
        private void loadPlayers()
        {
            playerComboBox.Items.Clear();
            passwordTextBox.Text = "";
            victoriesOutLabel.Text = "";

            // for every row in players table add the name column to the combo box
            foreach (DataRow row in objectsDataSet.Players.Rows)
            {
                playerComboBox.Items.Add(row["Name"]);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreatePlayerForm createPlayerForm1 = new CreatePlayerForm(); // displays new player creation form
            // hide and show so intro form will not be displayed while create form is up
            this.Hide();
            createPlayerForm1.ShowDialog();
            this.Show();

            // after create form closes these refresh the data in the combo box
            this.playersTableAdapter.Fill(this.objectsDataSet.Players);
            loadPlayers();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            if (playerComboBox.SelectedIndex >= 0)
            {
                // for every row in players table if name matches combo box selection and password is correct pass the name to main form
                foreach (DataRow row in objectsDataSet.Players.Rows)
                {
                    if (row["Name"].ToString() == playerComboBox.SelectedItem.ToString())
                    {
                        if (row["Password"].ToString() == passwordTextBox.Text)
                        {
                            MainForm mainForm2 = new MainForm(); // creating main form
                            // adding starting player to main form field before displaying form
                            mainForm2.startingPlayerName = playerComboBox.SelectedItem.ToString();

                            // hide and show so intro form will not be displayed while main form is up
                            this.Hide();
                            mainForm2.ShowDialog();
                        }
                        else
                        {
                            // if password does not match main form does not load
                            MessageBox.Show("Incorrect password. Please try again.");
                        }
                    }
                }
                this.Show();

                this.playersTableAdapter.Fill(this.objectsDataSet.Players);
                // loads players in combo box
                loadPlayers();
            }
            else
            {
                MessageBox.Show("You must select a player.");
            }
        }

        private void playerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in objectsDataSet.Players.Rows)
            {
                if (row["Name"].ToString() == playerComboBox.SelectedItem.ToString())
                {
                    victoriesOutLabel.Text = row["Victories"].ToString();
                }
            }
        }
    }
}
