namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            res = num1 + num2;
            label5.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            res = num1 - num2;
            label5.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            res = num1 * num2;
            label5.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2, res;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            res = num1 / num2;
            label5.Text = res.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}