namespace APLI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(textBox1.Text);
            string Opcion1 = comboBox1.Text;
            string Opcion2 = comboBox2.Text;

            string Metro = "Metro";
            string Centimetro = "Centimetro";
            string Pulgada = "Pulgada";



            if (Opcion1 == Metro && Opcion2 == Metro)
            {
                label1.Text = Numero + " Metros";
            }

            else if (Opcion1 == Centimetro && Opcion2 == Centimetro)
            {
                label1.Text = Numero + " Centimetros";
            }
            else if (Opcion1 == Pulgada && Opcion2 == Pulgada)
            {
                label1.Text = Numero + " Pulgadas";
            }
            else if (Opcion1 == Metro && Opcion2 == Centimetro)
            {
                label1.Text = (Numero * 100) + " Centimetros";
            }
            else if (Opcion1 == Centimetro && Opcion2 == Metro)
            {
                label1.Text = (Numero / 100) + " Metros";
            }
            else if (Opcion1 == Pulgada && Opcion2 == Centimetro)
            {
                label1.Text = (Numero * 2.54) + " Centimetros";
            }
            else if (Opcion1 == Centimetro && Opcion2 == Pulgada)
            {
                label1.Text = (Numero / 2.54) + " Pulgadas";
            }
            else if (Opcion1 == Metro && Opcion2 == Pulgada)
            {
                label1.Text = (Numero * 39.37) + " Pulgadas";

            }
            else if (Opcion1 == Pulgada && Opcion2 == Metro)
            {
                label1.Text = (Numero / 39.37) + " Metros";
            }
        }
    }
}
