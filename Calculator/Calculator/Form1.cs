using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button3.Text;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button8.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button6.Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button4.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + button0.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + dot.Text;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textDisplay.Text);
            textDisplay.Clear();

        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textDisplay.Text);
            if (option.Equals("+"))
                result = num1 + num2;
            if (option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("*"))
                result = num1 * num2;
            if (option.Equals("/"))
                result = num1 / num2;
            textDisplay.Text = result + "";
        }
    }
}