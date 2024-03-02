using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // Global Variabales go here
        List<playerObjects> playerObjectsList = new List<playerObjects>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string team = teamInput.Text;
            string position = positionInput.Text;
            int age = Convert.ToInt32(ageInput.Text);

            playerObjects player = new playerObjects(name, team, position, age);
            playerObjectsList.Add(player);

            label1.Text = "Player Created";
        }
        private void ListDisplaySort()
        {
            playerObjectsList.Sort();
        }

        private void PlayerSearch(TextBox textBox, string command)
        {
            //Lambda code
            string name = textBox.Text;
            playerObjects playerFound = playerObjectsList.Find(t => t.name == name);

            if (command == "remove")
            {
                playerObjectsList.Remove(playerFound);
                label1.Text = "player was removed";
            }
            else
            {
                label1.Text = "no player found";
            }

            if (command == "display")
            {
                if (playerFound == null)
                {
                    label1.Text = "No player found";
                }
                else
                {
                    DisplayPlayers();
                }
            }
            if (command == "search")
            {
                label1.Text = playerFound.name;
                label1.Text = $"{playerFound.name} {playerFound.team} {playerFound.position} {playerFound.age}\n";
            }
        }
        private void removeButton_Click(object sender, EventArgs e)
        {

            PlayerSearch(removeInput, "remove");

            ////Normal Solution
            //int listSize = playerObjectsList.Count();
            //foreach (playerObjects p in playerObjectsList)
            //{
            //    if (p.name == name)
            //    {
            //        playerObjectsList.Remove(p);
            //        break; //break out of the foreach loop
            //    }
            //}
            //if(listSize == playerObjectsList.Count)
            //{
            //    label1.Text = "Nothing was found";
            //}
            //DisplayPlayers();
        }
        private void DisplayPlayers()
        {
            label1.Text = "";
            for (int i = 0; i < playerObjectsList.Count; i++)
            {
                label1.Text += $"{playerObjectsList[i].name} {playerObjectsList[i].team} {playerObjectsList[i].position} {playerObjectsList[i].age}\n";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions. 
            //---------------------------
            PlayerSearch(nameSearchInput,"search");
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            DisplayPlayers();
        }
    }
}
