using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1Game
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> stats;

        public Form1()
        {
            InitializeComponent();

            stats = new Dictionary<string, int>();

            stats.Add("PlayerHealth", (int)this.PlayerHealthNumeric.Value);
            stats.Add("PlayerSpeed", (int)this.PlayerSpeedNumeric.Value);
            stats.Add("EnemyHealth", (int)this.EnemyHealthNumeric.Value);
            stats.Add("EnemySpeed", (int)this.EnemySpeedNumeric.Value);
            stats.Add("ProjectileSpeed", (int)this.ProjectileSpeedNumeric.Value);
            stats.Add("ProjectileDamage", (int)this.ProjectileDamageNumeric.Value);
            stats.Add("BossHealth", (int)this.BossHealthNumeric.Value);
            stats.Add("BossSpeed", (int)this.BossSpeedNumeric.Value);
        }

        /// <summary>
        /// Fills the dictionary with values once the enter button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enterbutton_Click(object sender, EventArgs e)
        {
            stats = new Dictionary<string, int>();

            stats.Add("PlayerHealth", (int)this.PlayerHealthNumeric.Value);
            stats.Add("PlayerSpeed", (int)this.PlayerSpeedNumeric.Value);
            stats.Add("EnemyHealth", (int)this.EnemyHealthNumeric.Value);
            stats.Add("EnemySpeed", (int)this.EnemySpeedNumeric.Value);
            stats.Add("ProjectileSpeed", (int)this.ProjectileSpeedNumeric.Value);
            stats.Add("ProjectileDamage", (int)this.ProjectileDamageNumeric.Value);
            stats.Add("BossHealth", (int)this.BossHealthNumeric.Value);
            stats.Add("BossSpeed", (int)this.BossSpeedNumeric.Value);

            // Closes the form
            this.Close();
        }

        public Dictionary<string, int> Stats
        { get { return stats; } }

    }
}
