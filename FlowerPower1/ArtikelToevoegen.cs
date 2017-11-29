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
    public partial class ArtikelToevoegen : Form
    {
        public ArtikelToevoegen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.Enabled = false;

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

        private void buttonSelecteerAfbeelding_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*,*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Toevoegen afbeelding mislukt, probeer opnieuw","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTerug_Click(object sender, EventArgs e)
        {
            ProductenOverzicht f6 = new ProductenOverzicht();
            Hide();
            f6.Show();
        }

        private void buttonToevoegen_Click(object sender, EventArgs e)
        {
            ProductenOverzicht f7 = new ProductenOverzicht();
            Hide();
            f7.Show();
        }

        private void ArtikelToevoegen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
