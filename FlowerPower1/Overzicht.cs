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
    public partial class Overzicht : Form
    {
        public Overzicht()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonDoorgaan_Click(object sender, EventArgs e)
        {
            if (general.OrderOverzicht == false && general.ProductenOverzicht == false)
            {
                MessageBox.Show("Geen keuze gemaakt tussen 'Order Overzicht' en 'Producten Overzicht', maak keuze.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

            if (general.Almere == false &&
                general.Breda == false &&
                general.Utrecht == false &&
                general.Arnhem == false)
            {
                MessageBox.Show("Geen keuze gemaakt tussen 'Almere-Breda-Utrecht-Arnhem', pmaak keuze.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (general.OrderOverzicht == true)
            {
                OrderOverzicht f2 = new OrderOverzicht();
                Hide();
                f2.Show();
            }
            if (general.ProductenOverzicht == true)
            {
                ProductenOverzicht f3 = new ProductenOverzicht();
                Hide();
                f3.Show();
            }
        }

        private void buttonOrderOverzicht_Click(object sender, EventArgs e)
        {
            general.OrderOverzicht = true;
            buttonOrderOverzicht.BackColor = Color.Aqua;
            buttonProductenOverzicht.BackColor = System.Drawing.SystemColors.Control;
            general.ProductenOverzicht = false;
        }

        private void buttonProductenOverzicht_Click(object sender, EventArgs e)
        {
            general.ProductenOverzicht = true;
            buttonProductenOverzicht.BackColor = Color.Aqua;
            buttonOrderOverzicht.BackColor = System.Drawing.SystemColors.Control;
            general.OrderOverzicht = false;
        }

        private void buttonAlmere_Click(object sender, EventArgs e)
        {
            general.Almere = true;
            general.Breda = false;
            general.Utrecht = false;
            general.Arnhem = false;
            buttonAlmere.BackColor = Color.Aqua;
            buttonBreda.BackColor = System.Drawing.SystemColors.Control;
            buttonUtrecht.BackColor = System.Drawing.SystemColors.Control;
            buttonArnhem.BackColor = System.Drawing.SystemColors.Control;
        }

        private void buttonBreda_Click(object sender, EventArgs e)
        {
            general.Breda = true;
            general.Almere = false;
            general.Utrecht = false;
            general.Arnhem = false;
            buttonBreda.BackColor = Color.Aqua;
            buttonAlmere.BackColor = System.Drawing.SystemColors.Control;
            buttonUtrecht.BackColor = System.Drawing.SystemColors.Control;
            buttonArnhem.BackColor = System.Drawing.SystemColors.Control;
        }

        private void buttonUtrecht_Click(object sender, EventArgs e)
        {
            general.Utrecht = true;
            general.Almere = false;
            general.Breda = false;
            general.Arnhem = false;
            buttonUtrecht.BackColor = Color.Aqua;
            buttonAlmere.BackColor = System.Drawing.SystemColors.Control;
            buttonBreda.BackColor = System.Drawing.SystemColors.Control;
            buttonArnhem.BackColor = System.Drawing.SystemColors.Control;
        }

        private void buttonArnhem_Click(object sender, EventArgs e)
        {
            general.Arnhem = true;
            general.Almere = false;
            general.Breda = false;
            general.Utrecht = false;
            buttonArnhem.BackColor = Color.Aqua;
            buttonAlmere.BackColor = System.Drawing.SystemColors.Control;
            buttonBreda.BackColor = System.Drawing.SystemColors.Control;
            buttonUtrecht.BackColor = System.Drawing.SystemColors.Control;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Overzicht_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
