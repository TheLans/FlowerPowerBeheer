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
    public partial class OrderOverzicht : Form
    {
        public OrderOverzicht()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void OrderOverzicht_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = true;
            buttonWijzigen.Enabled = false;
            buttonOpslaan.Enabled = false;

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

        private void buttonOrderOverzicht_Click(object sender, EventArgs e)
        {

        }

        private void buttonProductenOverzicht_Click(object sender, EventArgs e)
        {

        }


        private void buttonDoorgaan_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            buttonWijzigen.Enabled = true;
            buttonOpslaan.Enabled = true;

            if (checkVandaag.Checked == false && checkDezeWeek.Checked == false)
            {
                MessageBox.Show("Geen keuze gemaakt tussen 'Vandaag' en 'Deze week', probeer het opnieuw.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (general.Vandaag == true)
                {
                    labelResultaat.Text = "Vandaag";
                    labelBedrag.Text = "€0,01"; //general.berekeningVandaag
                }
                else if (general.DezeWeek == true)
                {
                    labelResultaat.Text = "Deze week";
                    labelBedrag.Text = "€0,02"; //berekeningDezeWeek
                }
            }
        }

        private void buttonAlmere_Click(object sender, EventArgs e)
        {
            general.Almere = true;
            general.Breda = false;
            general.Utrecht = false;
            general.Arnhem = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = true;
            checkVandaag.Checked = false;
            checkDezeWeek.Checked = false;
            buttonDoorgaan.Enabled = false;
            buttonWijzigen.Enabled = false;
            buttonOpslaan.Enabled = false;
            buttonAlmere.BackColor = Color.Aqua;
            buttonBreda.BackColor = System.Drawing.SystemColors.Control;
            buttonUtrecht.BackColor = System.Drawing.SystemColors.Control;
            buttonArnhem.BackColor = System.Drawing.SystemColors.Control;
        }

        private void buttonBreda_Click(object sender, EventArgs e)
        {
            general.Almere = false;
            general.Breda = true;
            general.Utrecht = false;
            general.Arnhem = false;
            checkVandaag.Checked = false;
            checkDezeWeek.Checked = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = true;
            buttonDoorgaan.Enabled = false;
            buttonWijzigen.Enabled = false;
            buttonOpslaan.Enabled = false;
            buttonAlmere.BackColor = System.Drawing.SystemColors.Control;
            buttonBreda.BackColor = Color.Aqua;
            buttonUtrecht.BackColor = System.Drawing.SystemColors.Control;
            buttonArnhem.BackColor = System.Drawing.SystemColors.Control;
        }

        private void buttonUtrecht_Click(object sender, EventArgs e)
        {
            general.Almere = false;
            general.Breda = false;
            general.Utrecht = true;
            general.Arnhem = false;
            checkVandaag.Checked = false;
            checkDezeWeek.Checked = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = true;
            buttonDoorgaan.Enabled = false;
            buttonWijzigen.Enabled = false;
            buttonOpslaan.Enabled = false;
            buttonAlmere.BackColor = System.Drawing.SystemColors.Control;
            buttonBreda.BackColor = System.Drawing.SystemColors.Control;
            buttonUtrecht.BackColor = Color.Aqua;
            buttonArnhem.BackColor = System.Drawing.SystemColors.Control;
        }

        private void buttonArnhem_Click(object sender, EventArgs e)
        {
            general.Almere = false;
            general.Breda = false;
            general.Utrecht = false;
            general.Arnhem = true;
            checkVandaag.Checked = false;
            checkDezeWeek.Checked = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = true;
            buttonDoorgaan.Enabled = false;
            buttonWijzigen.Enabled = false;
            buttonOpslaan.Enabled = false;
            buttonAlmere.BackColor = System.Drawing.SystemColors.Control;
            buttonBreda.BackColor = System.Drawing.SystemColors.Control;
            buttonUtrecht.BackColor = System.Drawing.SystemColors.Control;
            buttonArnhem.BackColor = Color.Aqua;
        }

        private void checkVandaag_CheckedChanged(object sender, EventArgs e)
        {
            if(checkVandaag.Checked == true)
            {
                checkDezeWeek.Checked = false;
                general.Vandaag = true;
                general.DezeWeek = false;
                buttonDoorgaan.Enabled = true;
                groupBox3.Enabled = false;
                buttonWijzigen.Enabled = false;
                buttonOpslaan.Enabled = false;
            }
        }

        private void checkDezeWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDezeWeek.Checked == true)
            {
                checkVandaag.Checked = false;
                general.DezeWeek = true;
                general.Vandaag = false;
                buttonDoorgaan.Enabled = true;
                groupBox3.Enabled = false;
                buttonWijzigen.Enabled = false;
                buttonOpslaan.Enabled = false;
            }
        }

        private void buttonSelecteerOverzicht_Click(object sender, EventArgs e)
        {
            Overzicht f4 = new Overzicht();
            Hide();
            f4.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}