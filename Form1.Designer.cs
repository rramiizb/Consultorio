namespace Consultorio
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
            btnAcceder = new Button();
            label1 = new Label();
            txtContraseña = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(390, 242);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(173, 32);
            btnAcceder.TabIndex = 0;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 35);
            label1.Name = "label1";
            label1.Size = new Size(389, 40);
            label1.TabIndex = 1;
            label1.Text = "\"Consultorio del Dr. Amado\"";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(390, 186);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(173, 23);
            txtContraseña.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(335, 127);
            label2.Name = "label2";
            label2.Size = new Size(293, 21);
            label2.TabIndex = 4;
            label2.Text = "Para Registrar turnos Ingrese la Clave";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSeaGreen;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(964, 400);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtContraseña);
            Controls.Add(label1);
            Controls.Add(btnAcceder);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcceder;
        private Label label1;
        private TextBox txtContraseña;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
