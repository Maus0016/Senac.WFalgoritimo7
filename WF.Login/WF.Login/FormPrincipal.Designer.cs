namespace WF.Login
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new Panel();
            btnDuvidas = new Button();
            btnQuemSomos = new Button();
            btnAssinaturas = new Button();
            btnProdutos = new Button();
            btnPlanos = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnDuvidas);
            panel1.Controls.Add(btnQuemSomos);
            panel1.Controls.Add(btnAssinaturas);
            panel1.Controls.Add(btnProdutos);
            panel1.Controls.Add(btnPlanos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 450);
            panel1.TabIndex = 0;
            // 
            // btnDuvidas
            // 
            btnDuvidas.FlatAppearance.BorderSize = 0;
            btnDuvidas.FlatStyle = FlatStyle.Flat;
            btnDuvidas.Font = new Font("Century Gothic", 8F);
            btnDuvidas.ForeColor = Color.White;
            btnDuvidas.Image = (Image)resources.GetObject("btnDuvidas.Image");
            btnDuvidas.ImageAlign = ContentAlignment.MiddleLeft;
            btnDuvidas.Location = new Point(12, 357);
            btnDuvidas.Name = "btnDuvidas";
            btnDuvidas.Size = new Size(261, 49);
            btnDuvidas.TabIndex = 4;
            btnDuvidas.Text = "Duvidas frequentes";
            btnDuvidas.UseVisualStyleBackColor = true;
            // 
            // btnQuemSomos
            // 
            btnQuemSomos.FlatAppearance.BorderSize = 0;
            btnQuemSomos.FlatStyle = FlatStyle.Flat;
            btnQuemSomos.Font = new Font("Century Gothic", 8F);
            btnQuemSomos.ForeColor = Color.White;
            btnQuemSomos.Image = (Image)resources.GetObject("btnQuemSomos.Image");
            btnQuemSomos.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuemSomos.Location = new Point(12, 302);
            btnQuemSomos.Name = "btnQuemSomos";
            btnQuemSomos.Size = new Size(261, 49);
            btnQuemSomos.TabIndex = 4;
            btnQuemSomos.Text = "Quem somos ?";
            btnQuemSomos.UseVisualStyleBackColor = true;
            btnQuemSomos.Click += button4_Click;
            // 
            // btnAssinaturas
            // 
            btnAssinaturas.FlatAppearance.BorderSize = 0;
            btnAssinaturas.FlatAppearance.MouseDownBackColor = Color.White;
            btnAssinaturas.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAssinaturas.FlatStyle = FlatStyle.Flat;
            btnAssinaturas.Font = new Font("Century Gothic", 8F);
            btnAssinaturas.ForeColor = Color.White;
            btnAssinaturas.Image = (Image)resources.GetObject("btnAssinaturas.Image");
            btnAssinaturas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAssinaturas.Location = new Point(12, 153);
            btnAssinaturas.Name = "btnAssinaturas";
            btnAssinaturas.Size = new Size(261, 49);
            btnAssinaturas.TabIndex = 4;
            btnAssinaturas.Text = "Assinaturas";
            btnAssinaturas.UseVisualStyleBackColor = true;
            btnAssinaturas.Click += button2_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatAppearance.MouseDownBackColor = Color.White;
            btnProdutos.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Century Gothic", 8F);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Image = (Image)resources.GetObject("btnProdutos.Image");
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(12, 100);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(261, 49);
            btnProdutos.TabIndex = 4;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += button2_Click;
            // 
            // btnPlanos
            // 
            btnPlanos.FlatAppearance.BorderSize = 0;
            btnPlanos.FlatStyle = FlatStyle.Flat;
            btnPlanos.Font = new Font("Century Gothic", 9F);
            btnPlanos.ForeColor = Color.White;
            btnPlanos.Image = (Image)resources.GetObject("btnPlanos.Image");
            btnPlanos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlanos.Location = new Point(12, 45);
            btnPlanos.Name = "btnPlanos";
            btnPlanos.Size = new Size(261, 49);
            btnPlanos.TabIndex = 3;
            btnPlanos.Text = "Planos";
            btnPlanos.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(281, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(519, 33);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(312, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 170);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 8F);
            label1.Location = new Point(20, 139);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 3;
            label1.Text = "Self-Defense";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 15F);
            label2.Location = new Point(503, 45);
            label2.Name = "label2";
            label2.Size = new Size(202, 39);
            label2.TabIndex = 3;
            label2.Text = "Real Combat";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._4102606_applications_media_social_whatsapp_icon;
            pictureBox2.Location = new Point(711, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._3146786_instagram_logo_icon;
            pictureBox3.Location = new Point(751, 48);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(432, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            textBox1.Text = "Principal";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            MouseDown += FormPrincipal_MouseDown;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnPlanos;
        private Button btnDuvidas;
        private Button btnQuemSomos;
        private Button btnProdutos;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnAssinaturas;
        private TextBox textBox1;
    }
}