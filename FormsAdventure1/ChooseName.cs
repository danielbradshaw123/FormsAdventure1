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
    public partial class ChooseName : Form
    {
        public ChooseName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game.name = this.textBox1.Text;
            this.Close();
        }
    }
}
