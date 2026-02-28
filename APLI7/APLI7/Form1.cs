namespace APLI7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Inicio = int.Parse(textBox1.Text);
            int Final = int.Parse(textBox2.Text);
            

            for (int i = Inicio; i <= Final; i++)
            {
                int contador = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }


                }
                if (contador == 2)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
