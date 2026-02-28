namespace APLI5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(maskedTextBox1.Text);
            int Contador = 0;

            for (int i = 1; i <= Numero; i++)
            {
                if (Numero % i == 0)
                {
                    Contador++;
                }

            }
            if (Contador == 2)
            {
                MessageBox.Show("Este Numero es Primo");
            }
            else
            {
                MessageBox.Show("Este Numero no es Primo");
            }
            



        }
    }
}
