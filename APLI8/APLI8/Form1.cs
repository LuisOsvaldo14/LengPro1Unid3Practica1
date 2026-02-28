namespace APLI8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oracion = textBox1.Text.Trim();



            string[] palabras = oracion.Split(new char[] { ' ' },
                                StringSplitOptions.RemoveEmptyEntries);

            label1.Text = "Cantidad de palabras: " + palabras.Length;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
