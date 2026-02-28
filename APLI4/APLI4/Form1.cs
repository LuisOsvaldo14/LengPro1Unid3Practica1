namespace APLI4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Palabra = textBox1.Text.ToLower();
            string Invertida = "";
            
            for (int i = Palabra.Length - 1; i >= 0; i--)
            {
                Invertida += Palabra[i];
            }

            if (Palabra == Invertida)
            {
                MessageBox.Show("Es palíndroma");
            }
            else
            {
                MessageBox.Show("No es palíndroma");
            }
        }
    }
}
