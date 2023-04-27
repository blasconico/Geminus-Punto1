namespace Geminus
{
    public partial class frmPunto1 : Form
    {
        static int n = 5;
        public frmPunto1()
        {
            InitializeComponent();
            txtTablero.Enabled = false;
            txtCasillas.Text = n.ToString();
            DibujarTablero(n);
        }

        private void DibujarTablero(int casillas)
        {
            txtTablero.Text = "";

            for (int fila = 0; fila < casillas; fila++)
            {
                for (int col = 0; col < casillas; col++)
                {
                    if ((fila + col) % 2 == 0)
                        txtTablero.Text += "X";
                    else
                        txtTablero.Text += "_";
                }
                txtTablero.Text += System.Environment.NewLine;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCasillas.Text = n.ToString();
            DibujarTablero(n);
        }

        private void txtCasillas_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtCasillas_KeyUp(object sender, KeyEventArgs e)
        {
            int casillas = string.IsNullOrEmpty(txtCasillas.Text) ? n : (Convert.ToInt16(txtCasillas.Text) > 10 ? n : Convert.ToInt16(txtCasillas.Text));
            DibujarTablero(casillas == 0 ? n : casillas);
        }
    }
}