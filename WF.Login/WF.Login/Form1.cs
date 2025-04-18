using System.Diagnostics;

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
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void KravMaga_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void KravMaga_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void KravMaga_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.bing.com/search?pglt=43&q=google&cvid=dcf2c87218bd4dfe95472069c1e2f8d3&gs_lcrp=EgRlZGdlKgYIABBFGDkyBggAEEUYOTIGCAEQABhAMgYIAhAuGEAyBggDEC4YQDIGCAQQABhAMgYIBRAFGEAyBggGEAUYQDIGCAcQBRhAMgYICBAFGEAyCAgJEOkHGPxV0gEINzk3NmowajGoAgiwAgE&FORM=ANNAB1&PC=U531",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.google.com.br/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja encerrar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta != DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja encerrar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta != DialogResult.No)
            {
                Application.Exit();
            }

        }

        private void Botão_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }
    }
}