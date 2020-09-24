using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        //create a List to store all inventory objects
        List<Player> playerList = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //gather all information from screen 
            string name = nameInput.Text;
            int age = Convert.ToInt16(ageInput.Text);
            string team = teamInput.Text;
            string position = positionInput.Text;

            Player newPlayer = new Player(name, age, team, position); //create object with gathered information

            playerList.Add(newPlayer); //add object to global list

            outputLabel.Text = "New Player Added."; //display message to indicate addition made

            //clear input boxes
            nameInput.Text = "";
            ageInput.Text = "";
            teamInput.Text = "";
            positionInput.Text = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // TODO - if object is in list remove it
            // TODO - display message to indicate deletion made
            int index = playerList.FindIndex(x => x.name == removeInput.Text);

            if (index >= 0)
            {
                playerList.RemoveAt(index);
                outputLabel.Text = "Player Removed Successfully.";
            }
            else
            {
                outputLabel.Text = "Error, no players with that name exist.";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = ""; //clear output label

            //if player entered exists in list show it
            //else show not found message
            List<Player> foundPlayers = playerList.FindAll(x => x.name == searchInput.Text);

            if (foundPlayers.Count > 0)
            {
                foreach (Player p in foundPlayers)
                {
                    outputLabel.Text += p.name + " - " + p.age + " - " + p.team + " - " + p.position + "\r\n";
                }
            }
            else
            {
                outputLabel.Text = "Error, no players with that name exist.";
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = ""; //clear output label

            playerList = playerList.OrderBy(x => x.name).ThenBy(x => x.age).ThenBy(x => x.team).ThenBy(x => x.position).ToList();

            //show all objects in list
            foreach (Player p in playerList)
            {
                outputLabel.Text += p.name + " - " + p.age + " - " + p.team + " - " + p.position + "\r\n";
            }
        }
    }
}
