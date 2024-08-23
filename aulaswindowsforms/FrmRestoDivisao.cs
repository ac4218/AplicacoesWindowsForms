using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaswindowsforms
{
    public partial class FrmRestoDivisao : Form
    {
        private object txtDividendo;

        public FrmRestoDivisao()
        {
            InitializeComponent();
        }

        private void FrmRestoDivisao_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                int dividendo = Convert.ToInt32(txtdividendo.Text);
                int divisor = Convert.ToInt32(txtdivisor.Text);
                int resto = dividendo % divisor;
                txtresto.Text = resto.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("ocorreu um erro!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
