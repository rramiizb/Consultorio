namespace Consultorio
{
    partial class Form2
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            Apellido = new Label();
            txtTelefono = new TextBox();
            DNI = new Label();
            txtDNI = new TextBox();
            label4 = new Label();
            txtObraSocial = new TextBox();
            label5 = new Label();
            txtMotivo = new TextBox();
            label6 = new Label();
            txtFecha = new TextBox();
            label7 = new Label();
            txtHora = new TextBox();
            label8 = new Label();
            monthCalendar1 = new MonthCalendar();
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            label9 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(37, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(236, 52);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 23);
            txtApellido.TabIndex = 3;
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(236, 34);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(51, 15);
            Apellido.TabIndex = 2;
            Apellido.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(631, 52);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 23);
            txtTelefono.TabIndex = 5;
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Location = new Point(433, 34);
            DNI.Name = "DNI";
            DNI.Size = new Size(27, 15);
            DNI.TabIndex = 4;
            DNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(433, 52);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(150, 23);
            txtDNI.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 34);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Teléfono";
            // 
            // txtObraSocial
            // 
            txtObraSocial.Location = new Point(37, 116);
            txtObraSocial.Name = "txtObraSocial";
            txtObraSocial.Size = new Size(150, 23);
            txtObraSocial.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 98);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "Obra Social";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(236, 116);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(236, 23);
            txtMotivo.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 98);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 10;
            label6.Text = "Motivo de la Consulta";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(519, 116);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(150, 23);
            txtFecha.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(519, 98);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 12;
            label7.Text = "Fecha";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(37, 171);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(150, 23);
            txtHora.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 153);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 14;
            label8.Text = "Hora";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(811, 80);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(953, 154);
            dataGridView1.TabIndex = 17;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(37, 264);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(192, 23);
            txtBuscar.TabIndex = 19;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 246);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 18;
            label9.Text = "Buscar Paciente";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(236, 168);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 27);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(381, 168);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 27);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(885, 41);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 27);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 462);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(monthCalendar1);
            Controls.Add(txtHora);
            Controls.Add(label8);
            Controls.Add(txtFecha);
            Controls.Add(label7);
            Controls.Add(txtMotivo);
            Controls.Add(label6);
            Controls.Add(txtObraSocial);
            Controls.Add(label5);
            Controls.Add(txtDNI);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(DNI);
            Controls.Add(txtApellido);
            Controls.Add(Apellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label Apellido;
        private TextBox txtTelefono;
        private Label DNI;
        private TextBox txtDNI;
        private Label label4;
        private TextBox txtObraSocial;
        private Label label5;
        private TextBox txtMotivo;
        private Label label6;
        private TextBox txtFecha;
        private Label label7;
        private TextBox txtHora;
        private Label label8;
        private MonthCalendar monthCalendar1;
        private DataGridView dataGridView1;
        private TextBox txtBuscador;
        private Label label9;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtBuscar;
    }
}