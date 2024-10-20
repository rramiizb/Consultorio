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
            btnAcceder = new Button();
            label1 = new Label();
            txtContraseña = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(435, 267);
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
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 36);
            label1.Name = "label1";
            label1.Size = new Size(341, 40);
            label1.TabIndex = 1;
            label1.Text = "\"Consultorio Dr. Amado\"";
            
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(435, 238);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(173, 23);
            txtContraseña.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura1;
            pictureBox1.Location = new Point(64, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(381, 205);
            label2.Name = "label2";
            label2.Size = new Size(287, 21);
            label2.TabIndex = 4;
            label2.Text = "Para registrar turnos ingrese la clave";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1012, 450);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txtContraseña);
            Controls.Add(label1);
            Controls.Add(btnAcceder);
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
        private PictureBox pictureBox1;
        private Label label2;
    }
}
