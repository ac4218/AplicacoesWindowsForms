namespace TrocaValores
{
    public partial class FrmTroca : Form
    {
        public FrmTroca()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            string aux = TxtValor.Text;
            TxtValor.Text = TxtValor2.Text;
            TxtValor2.Text = aux;
        }

    

        private void BtnClick_Click_1(object sender, EventArgs e)
        {

        }
    }
}
