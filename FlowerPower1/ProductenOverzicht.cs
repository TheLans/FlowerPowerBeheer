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
    public partial class ProductenOverzicht : Form
    {
        public ProductenOverzicht()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ProductenOverzicht_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
            buttonWijzigen.Enabled = true;
            buttonToevoegen.Enabled = true;

            if (general.OrderOverzicht == true)
            {
                buttonOrderOverzicht.BackColor = Color.Aqua;
            }

            if (general.ProductenOverzicht == true)
            {
                buttonProductenOverzicht.BackColor = Color.Aqua;
            }

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

        private void buttonSelecteerOverzicht_Click(object sender, EventArgs e)
        {
            general.Almere = false;
            general.Breda = false;
            general.Arnhem = false;
            general.Utrecht = false;
            general.ProductenOverzicht = false;
            general.OrderOverzicht = false;
            Overzicht f5 = new Overzicht();
            Hide();
            f5.Show();
        }

        private void buttonToevoegen_Click(object sender, EventArgs e)
        {
            ArtikelToevoegen f6 = new ArtikelToevoegen();
            Hide();
            f6.Show();
        }

        private void buttonWijzigen_Click(object sender, EventArgs e)
        {
            ArtikelWijzigen f7 = new ArtikelWijzigen();
            Hide();
            f7.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
