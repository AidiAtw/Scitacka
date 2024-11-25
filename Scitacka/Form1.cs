namespace Scitacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSectiStr_Click(object sender, EventArgs e)
        {
            textBox3.Text = (textBox1.Text + " " + textBox2.Text);
        }

        private void btnSectiInt_Click(object sender, EventArgs e)
        {

            int prvniCislo = -1;
            int druheCislo = -1;
            int vysledek = -1;

            try
            {
                prvniCislo = Convert.ToInt32(textBox1.Text);
                druheCislo = Convert.ToInt32(textBox2.Text);
                vysledek = prvniCislo + druheCislo;
                textBox3.Text = vysledek.ToString();
            }
            catch (Exception)
            {

                textBox3.Text = "spatne ty kkt";
            }
        }
    }
}
