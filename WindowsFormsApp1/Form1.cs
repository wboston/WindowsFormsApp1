using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    // Pause the Game
                    // Call Pause Menu overlay
                    break;

                case Keys.Right:
                    break;
                case Keys.Left:
                    break;
                case Keys.Up:
                    break;
                case Keys.Down:
                    break;

                case Keys.W:
                    break;
                case Keys.S:
                    break;
                case Keys.A:
                    break;
                case Keys.D:
                    break;

                case Keys.Space:
                    // create new projectile
                    // space shoots from the user.
                    // get shot(user.x, user.y)
                    break;
            }

            // user.doWork(sender, e)
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
