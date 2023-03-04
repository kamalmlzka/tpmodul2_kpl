namespace project1_1302210032
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            label1.Text = "Halo " + inputText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}