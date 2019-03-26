using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAdventure1
{
    public partial class Title : Form
    {
        System.Media.SoundPlayer splayer;
        public Title()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // stop the textbox from being highlighted
            this.ActiveControl = label1;
            // load and play the sound file
            splayer = new System.Media.SoundPlayer();
            splayer.Stream = Properties.Resources.dragon_growl;
            splayer.PlayLooping();

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Form getName = new ChooseName();
            getName.ShowDialog();
            // change textbox to welcome message
            this.textBox1.Text = "Welcome: " + Game.name + "\r\n Enjoy playing the game...";

        }

        private void button_start_Click_1(object sender, EventArgs e)
        {
            if (Game.name != null)
            {

                // load first location form
                Form location = new location1();
                location.Show();
                // hide the title form and stop playing sound
                this.Hide();
                splayer.Stop();
            }
            else
            {
                MessageBox.Show("Please choose a name first");
            }
        }
    }
}