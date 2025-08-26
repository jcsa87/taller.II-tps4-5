namespace practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGenerarFuncion_Click(object sender, EventArgs e)
        {
            float desde = TBDesde();
            while ()
        }

        private float TBDesde_TextChanged(object sender, EventArgs e)
        {
            string datoIngresado = TBDesde.Text;
            float numIngresado;
            bool esNumero = float.TryParse(datoIngresado, out numIngresado);

            if (esNumero)
            {
                return numIngresado;
            }
            else
            {
                return 0;
            }
        }


        private float TBHasta_TextChanged(object sender, EventArgs e)
        {
            string datoIngresado = TBDesde.Text;
            float numIngresado;
            bool esNumero = float.TryParse(datoIngresado, out numIngresado);

            if (esNumero)
            {
                return numIngresado;
            }
            else
            {
                return 0;
            }

        }

        private void TBListaNumeros_TextChanged(object sender, EventArgs e)
        {
            TBListaNumeros.Text += "Números ingresados\n";
        }

        private void BGenerarFuncion_Enter(object sender, EventArgs e)
        {

        }
    }
}
