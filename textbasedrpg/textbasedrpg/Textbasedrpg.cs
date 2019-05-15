using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbasedrpg
{
    public partial class Form1 : Form
    {
        private Player playerTim;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);

            playerTim = new Player(10, 10, 20, 0, 1);

            Location location = new Location(1, "Home", "This is your house");

            lblHitPoints.Text = playerTim.CurrentHitPoints.ToString();
            lblGold.Text = playerTim.Gold.ToString();
            lblExperience.Text = playerTim.ExperiencePoints.ToString();
            lblLevel.Text = playerTim.Level.ToString();

        }

        private void BtnNorth_Click(object sender, EventArgs e)
        {

        }

        private void BtnWest_Click(object sender, EventArgs e)
        {

        }

        private void BtnEast_Click(object sender, EventArgs e)
        {

        }

        private void BtnSouth_Click(object sender, EventArgs e)
        {

        }

        private void BtnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void BtnUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
