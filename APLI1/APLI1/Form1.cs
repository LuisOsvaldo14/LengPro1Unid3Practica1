namespace APLI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(textBox1.Text);

            for (int i = 1;i <= 10; i++ )
            {
                listBox1.Items.Add(Numero +" * "+i+" = "+Numero * i);
            }
        }
    }
}
