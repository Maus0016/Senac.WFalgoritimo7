namespace WF.Login
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            Botão = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 524);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(546, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 24);
            textBox2.TabIndex = 2;
            // 
            // Botão
            // 
            Botão.BackColor = Color.DimGray;
            Botão.Cursor = Cursors.Hand;
            Botão.DialogResult = DialogResult.Continue;
            Botão.FlatAppearance.BorderSize = 0;
            Botão.FlatStyle = FlatStyle.Flat;
            Botão.Font = new Font("Segoe UI", 15F);
            Botão.ForeColor = Color.Black;
            Botão.Location = new Point(457, 279);
            Botão.Name = "Botão";
            Botão.Size = new Size(478, 48);
            Botão.TabIndex = 3;
            Botão.Text = "ENTRAR";
            Botão.UseVisualStyleBackColor = false;
            Botão.Click += Botão_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Location = new Point(631, 374);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(141, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Recuperar senha";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Location = new Point(656, 428);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(87, 25);
            linkLabel2.TabIndex = 0;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Cadastrar";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(454, 135);
            label3.Name = "label3";
            label3.Size = new Size(474, 25);
            label3.TabIndex = 8;
            label3.Text = "__________________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(454, 209);
            label4.Name = "label4";
            label4.Size = new Size(474, 25);
            label4.TabIndex = 9;
            label4.Text = "__________________________________________________________________";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Black;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.ForeColor = Color.DimGray;
            textBox3.Location = new Point(457, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(472, 40);
            textBox3.TabIndex = 1;
            textBox3.Text = "USUARIO:";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Black;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.ForeColor = Color.DimGray;
            textBox4.Location = new Point(454, 182);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(472, 40);
            textBox4.TabIndex = 2;
            textBox4.Text = "SENHA:";
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(891, 12);
            button2.Name = "button2";
            button2.Size = new Size(28, 30);
            button2.TabIndex = 5;
            button2.Text = "__";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(925, 12);
            button1.Name = "button1";
            button1.Size = new Size(28, 30);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(983, 524);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(Botão);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Krav maga Company";
            MouseDown += KravMaga_MouseDown;
            MouseMove += KravMaga_MouseMove;
            MouseUp += KravMaga_MouseUp;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private Button Botão;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Button button1;
    }
}
