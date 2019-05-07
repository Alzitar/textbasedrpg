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
    public partial class Textbasedrpg : Form
    {
        private Player playerTim;

        public Textbasedrpg()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 300);


            playerTim = new Player
            {
                CurrentHitpoints = 10,
                MaximumHitpoints = 10,
                Gold = 20,
                ExperiencePoints = 0,
                Level = 1
            };

            lblHitPoints.Text = playerTim.CurrentHitpoints.ToString();
            lblGold.Text = playerTim.Gold.ToString();
            lblExperience.Text = playerTim.ExperiencePoints.ToString();
            lblLevel.Text = playerTim.Level.ToString();

        }
    }
}
