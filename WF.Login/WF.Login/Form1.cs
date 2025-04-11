namespace WF.Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "USUARIO:")
                textBox3.Text = "";

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                textBox3.Text = "USUARIO:";
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "SENHA:")
                textBox4.Text = "";
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                textBox4.Text = "SENHA:";
        }
    }
}
