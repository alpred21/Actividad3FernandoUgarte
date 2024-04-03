namespace SistemaPedidos.VISTAS
{
    partial class Interfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz));
            listBox1 = new ListBox();
            panelcargarform = new Panel();
            pictureBox3 = new PictureBox();
            panelmenu = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            buttoning = new Button();
            buttonpersona = new Button();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panelcargarform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelmenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(129, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 0;
            // 
            // panelcargarform
            // 
            panelcargarform.BackColor = Color.White;
            panelcargarform.Controls.Add(pictureBox3);
            panelcargarform.Dock = DockStyle.Fill;
            panelcargarform.Location = new Point(0, 177);
            panelcargarform.MaximumSize = new Size(1000, 500);
            panelcargarform.MinimumSize = new Size(849, 341);
            panelcargarform.Name = "panelcargarform";
            panelcargarform.Size = new Size(849, 341);
            panelcargarform.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(299, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(20);
            pictureBox3.Size = new Size(285, 259);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panelmenu
            // 
            panelmenu.BackColor = Color.FromArgb(224, 224, 224);
            panelmenu.BackgroundImageLayout = ImageLayout.None;
            panelmenu.Controls.Add(button3);
            panelmenu.Controls.Add(panel5);
            panelmenu.Controls.Add(buttoning);
            panelmenu.Controls.Add(buttonpersona);
            panelmenu.Dock = DockStyle.Top;
            panelmenu.Location = new Point(0, 130);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(849, 47);
            panelmenu.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F);
            button3.ForeColor = Color.Red;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(754, 5);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(90, 38);
            button3.TabIndex = 2;
            button3.Text = "SALIR";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 655);
            panel5.Name = "panel5";
            panel5.Size = new Size(203, 87);
            panel5.TabIndex = 19;
            // 
            // buttoning
            // 
            buttoning.BackColor = Color.Transparent;
            buttoning.BackgroundImageLayout = ImageLayout.Zoom;
            buttoning.Cursor = Cursors.Hand;
            buttoning.Dock = DockStyle.Left;
            buttoning.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttoning.FlatAppearance.CheckedBackColor = Color.Silver;
            buttoning.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttoning.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttoning.FlatStyle = FlatStyle.Flat;
            buttoning.Font = new Font("Arial Rounded MT Bold", 9.75F);
            buttoning.ForeColor = Color.Black;
            buttoning.Image = (Image)resources.GetObject("buttoning.Image");
            buttoning.ImageAlign = ContentAlignment.MiddleLeft;
            buttoning.Location = new Point(203, 0);
            buttoning.Name = "buttoning";
            buttoning.Size = new Size(203, 47);
            buttoning.TabIndex = 14;
            buttoning.Text = "INGRESOS";
            buttoning.UseVisualStyleBackColor = false;
            // 
            // buttonpersona
            // 
            buttonpersona.BackColor = Color.Transparent;
            buttonpersona.BackgroundImageLayout = ImageLayout.Zoom;
            buttonpersona.Cursor = Cursors.Hand;
            buttonpersona.Dock = DockStyle.Left;
            buttonpersona.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttonpersona.FlatAppearance.CheckedBackColor = Color.Silver;
            buttonpersona.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonpersona.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonpersona.FlatStyle = FlatStyle.Flat;
            buttonpersona.Font = new Font("Arial Rounded MT Bold", 9.75F);
            buttonpersona.ForeColor = Color.Black;
            buttonpersona.Image = (Image)resources.GetObject("buttonpersona.Image");
            buttonpersona.ImageAlign = ContentAlignment.MiddleLeft;
            buttonpersona.Location = new Point(0, 0);
            buttonpersona.Name = "buttonpersona";
            buttonpersona.Size = new Size(203, 47);
            buttonpersona.TabIndex = 5;
            buttonpersona.Text = "PERSONAS";
            buttonpersona.UseVisualStyleBackColor = false;
            buttonpersona.Click += buttonpersona_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 130);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Magneto", 36F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(158, 3);
            label4.Name = "label4";
            label4.Padding = new Padding(60, 35, 50, 30);
            label4.Size = new Size(473, 123);
            label4.TabIndex = 17;
            label4.Text = "PREDSHOP";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(20);
            pictureBox2.Size = new Size(152, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Interfas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 518);
            Controls.Add(panelcargarform);
            Controls.Add(panelmenu);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(865, 557);
            Name = "Interfas";
            Text = "Interfas";
            panelcargarform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelmenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Panel panelcargarform;
        private PictureBox pictureBox3;
        private Panel panelmenu;
        private Panel panel5;
        private Button button3;
        private Button buttoning;
        private Button buttonpersona;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox2;
    }
}