using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vormen
{
    public partial class Form1 : Form
    {
        Cirkel c;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMaken_Click(object sender, EventArgs e)
        {
            UInt32 _straal = Convert.ToUInt32(txtStraal.Text);
            try
            {
                c = new Cirkel(_straal);
                MessageBox.Show("Het maken van de cirkel is gelukt!");
                MessageBox.Show("De cirkel heeft de straal " + c.Straal);
                picBord.Invalidate();
                listCirkels.Items.Add(c);
            }
            catch (Exception exc)
            {
                txtStraal.BackColor = Color.Red;
            }
        }

        private void TxtStraal_TextChanged(object sender, EventArgs e)
        {
            txtStraal.BackColor = Color.White;
        }

        private void PicBord_Paint(object sender, PaintEventArgs e)
        {
            if (c != null)
                c.Paint(e.Graphics);
        }
    }
}
