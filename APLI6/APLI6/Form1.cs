namespace APLI6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(maskedTextBox1.Text);
            int sumatoria = 0;

            for (int i = 1; i <= Numero / 2; i++)
            {
                if (Numero % i == 0)
                {
                    sumatoria = sumatoria + i;
                }
            }
            if (sumatoria == Numero)
            {
                MessageBox.Show("Es numero es perfecto");
            }
            else { MessageBox.Show("este numero no es perfecto"); }

        }
    }
}
