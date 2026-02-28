namespace APLI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int tiempoTotal;

        private void button1_Click(object sender, EventArgs e)
        {
            int minutos = int.Parse(textBox1.Text);
            int segundos = int.Parse(textBox2.Text);


            tiempoTotal = (minutos * 60) + segundos;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempoTotal > 0)
            {
                tiempoTotal--;

                int minutos = tiempoTotal / 60;
                int segundos = tiempoTotal % 60;

                label1.Text = minutos.ToString("00") + ":" + segundos.ToString("00");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("¡Tiempo agotado!");

            }
        }
    }
}
