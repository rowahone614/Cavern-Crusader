using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSystemServices;

namespace Cavern
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }
        
        private void button_Enter(object sender, EventArgs e)
        {
            //start by changing all the buttons to the default colour
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                    c.BackColor = Color.Red;
            }

            //change the current button to the active colour
            Button btn = (Button)sender;
            btn.BackColor = Color.Green;
            lastscoreLabel.Text = "Last Score: " + Convert.ToString(MainForm.lastScore);
        }
    
        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "GameScreen");  
        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "ScoreScreen");
            crusaderImage.Visible = false;
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            crusaderImage.Visible = false;
        }
    }
}
