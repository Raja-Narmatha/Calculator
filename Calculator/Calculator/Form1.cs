namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String tot;
        int num1, num2;
        String opt;
        int ans;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
        }

        private void add_Click(object sender, EventArgs e)
        {
            opt = "+";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            opt = "-";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            opt = "*";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            opt = "/";
            num1 = int.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            num1 = (0);
            num2= (0);
            ans = (0);
        }

        private void res_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);
            if (opt.Equals("+"))
                ans = num1 + num2;
            if (opt.Equals("-"))
                ans = num1 - num2;
            if (opt.Equals("*"))
                ans = num1 * num2;
            if (opt.Equals("/"))
                ans = num1 / num2;
            txtTotal.Text = ans + " ";
        }
    }
}
