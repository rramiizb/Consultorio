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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 29);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(37, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(236, 52);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 27);
            txtApellido.TabIndex = 3;
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Apellido.Location = new Point(236, 29);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(67, 20);
            Apellido.TabIndex = 2;
            Apellido.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(631, 52);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 27);
            txtTelefono.TabIndex = 5;
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DNI.Location = new Point(433, 29);
            DNI.Name = "DNI";
            DNI.Size = new Size(37, 20);
            DNI.TabIndex = 4;
            DNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDNI.Location = new Point(433, 52);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(150, 27);
            txtDNI.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(631, 29);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Teléfono";
            // 
            // txtObraSocial
            // 
            txtObraSocial.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObraSocial.Location = new Point(37, 116);
            txtObraSocial.Name = "txtObraSocial";
            txtObraSocial.Size = new Size(150, 27);
            txtObraSocial.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 93);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 8;
            label5.Text = "Obra Social";
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotivo.Location = new Point(236, 116);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(236, 27);
            txtMotivo.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(236, 93);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 10;
            label6.Text = "Motivo de la Consulta";
            // 
            // txtFecha
            // 
            txtFecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFecha.Location = new Point(519, 116);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(150, 27);
            txtFecha.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(519, 93);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 12;
            label7.Text = "Fecha";
            // 
            // txtHora
            // 
            txtHora.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHora.Location = new Point(37, 171);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(150, 27);
            txtHora.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 148);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 14;
            label8.Text = "Hora";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(710, 93);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(37, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(953, 154);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(37, 264);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(192, 27);
            txtBuscar.TabIndex = 19;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(37, 246);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 18;
            label9.Text = "Buscar Paciente";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(236, 168);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 30);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(381, 168);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 30);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(564, 168);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 30);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
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
            DoubleClick += Form2_DoubleClick;
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
