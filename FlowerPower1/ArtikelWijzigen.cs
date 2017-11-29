using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerPower
{
    public partial class ArtikelWijzigen : Form
    {
        public ArtikelWijzigen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            if (general.Almere == true)
            {
                buttonAlmere.BackColor = Color.Aqua;
            }

            if (general.Breda == true)
            {
                buttonBreda.BackColor = Color.Aqua;
            }

            if (general.Utrecht == true)
            {
                buttonUtrecht.BackColor = Color.Aqua;
            }

            if (general.Arnhem == true)
            {
                buttonArnhem.BackColor = Color.Aqua;
            }
        }

        private void buttonTerug_Click(object sender, EventArgs e)
        {
            ProductenOverzicht f7 = new ProductenOverzicht();
            Hide();
            f7.Show();
        }

        private void buttonToevoegen_Click(object sender, EventArgs e)
        {
            ProductenOverzicht f8 = new ProductenOverzicht();
            Hide();
            f8.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void ArtikelWijzigen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
