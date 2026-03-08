namespace Tp_Modul3_103022400121
{
    public partial class Form1 : Form
    {
        int hasil;
        int operand1;
        string op = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { label2.Text += "1"; }
        private void label2_Click(object sender, EventArgs e) { }

        private void button11_Click(object sender, EventArgs e) { label2.Text += "0"; }

        private void button2_Click(object sender, EventArgs e) { label2.Text += "2"; }

        private void button3_Click(object sender, EventArgs e) { label2.Text += "3"; }

        private void button4_Click(object sender, EventArgs e) { label2.Text += "4"; }

        private void button5_Click(object sender, EventArgs e) { label2.Text += "5"; }

        private void button6_Click(object sender, EventArgs e) { label2.Text += "6"; }

        private void button7_Click(object sender, EventArgs e) { label2.Text += "7"; }

        private void button8_Click(object sender, EventArgs e) { label2.Text += "8"; }

        private void button9_Click(object sender, EventArgs e) { label2.Text += "9"; }

        private void button10_Click(object sender, EventArgs e)
        {
            if (int.TryParse(label2.Text, out int v))
            {
                operand1 = v;
            }
            else
            {
                operand1 = 0;
            }
            op = "+";
            label2.Text = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(label2.Text, out int operand2))
            {
                operand2 = 0;
            }

            switch (op)
            {
                case "+":
                    hasil = operand1 + operand2;
                    break;
                default:
                    hasil = operand2;
                    break;
            }

            label2.Text = hasil.ToString();
            op = string.Empty;
        }
    }
}
