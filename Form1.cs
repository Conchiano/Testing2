using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing2
{
    public partial class Form1 : Form
    {
        public bool var;
        int s;
        int tries;
        string Player1;
        string Player2;

        public Form1()
        {
            InitializeComponent();
            var = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (tries = 3; tries > 0; tries--)
            {

            }
                if (var==true)
                {
                    tries = 3;
                    lblTries.Text = Convert.ToString(3);
                    if (txtBXRand.Text==txtBxAnswer.Text)
                    {
                        s = 4 * 3;
                    }
                    else
                    {
                        s = 4 * 5;
                    }
            }
            else
            { 
               
                MessageBox.Show("Try Again!");
                tries--;
            }

            txtBxS.Text = Convert.ToString(s);
            txtBxPlayer.Text = Player1;

            if(tries==0)
            {
                var = false;
                txtBxPlayer.Text = Player2;
            }
        }
    }
}
