namespace WF.Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            CADASTRAR = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
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
            panel1.Size = new Size(419, 613);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(546, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 24);
            textBox1.TabIndex = 1;
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
            // CADASTRAR
            // 
            CADASTRAR.BackColor = Color.DimGray;
            CADASTRAR.FlatAppearance.BorderSize = 0;
            CADASTRAR.FlatStyle = FlatStyle.Flat;
            CADASTRAR.ForeColor = Color.Black;
            CADASTRAR.Location = new Point(457, 279);
            CADASTRAR.Name = "CADASTRAR";
            CADASTRAR.Size = new Size(478, 48);
            CADASTRAR.TabIndex = 3;
            CADASTRAR.Text = "ENTRAR";
            CADASTRAR.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(631, 431);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(141, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Recuperar senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(447, 87);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 5;
            label1.Text = "LOGIN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(455, 182);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 6;
            label2.Text = "SENHA:";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(656, 473);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(87, 25);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Cadastrar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(981, 613);
            Controls.Add(linkLabel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(CADASTRAR);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.85D;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button CADASTRAR;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel2;
    }
}
