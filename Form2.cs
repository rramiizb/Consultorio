using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Consultorio
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=127.0.0.1; Port =3306 ;Database=Pacientes;User Id=root;Password=45891023;";

        // Declarar la variable idPaciente de tipo int
        private int idPaciente;

        private bool isLoading = true; // Bandera para controlar la carga


        public Form2()
        {
            InitializeComponent();
            ConnectToDatabase();
            LimpiarCampos();


            // Desconectar el evento RowEnter antes de cargar datos
            dataGridView1.RowEnter -= dataGridView1_RowEnter;

            CargarDatos();  // Cargar los datos sin activar el evento RowEnter

            // Reconectar el evento RowEnter después de que los datos se carguen
            dataGridView1.RowEnter += dataGridView1_RowEnter;


            // Asegurarse de que los botones estén vinculados a sus eventos
            btnAgregar.Click += btnAgregar_Click;
            btnModificar.Click += btnModificar_Click;
            btnEliminar.Click += btnEliminar_Click;


            isLoading = false; // Establecer a false después de cargar datos
        }




        public void ConnectToDatabase()
        {
            string connectionString = "Server=127.0.0.1; Port=3306;Database=Pacientes;User Id=root;Password=45891023;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {

                    connection.Open();
                    MessageBox.Show("Conexión exitosa!");
                    // Aquí puedes ejecutar tus comandos SQL
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        // Declarar el DataTable como variable de clase
        private DataTable dataTable = new DataTable();



        private void CargarDatos()
        {




            // Consulta SQL para obtener los datos de la tabla
            string query = "SELECT * FROM Turnos"; // Cambia "tu_tabla" por el nombre real de tu tabla

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                dataTable = new DataTable();

                try
                {
                    isLoading = true;

                    connection.Open(); // Abrir la conexión
                    adapter.Fill(dataTable); // Llenar el DataTable con los datos

                    // Asignar el DataTable como fuente de datos del DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Esperar hasta que los datos estén completamente cargados

                    Application.DoEvents();  // Procesar cualquier evento pendiente

                    // Desactivar selección automática
                    dataGridView1.ClearSelection();

                    isLoading = false; //Terminar el estado de carga 


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                }
            }
        }

        // Método para limpiar los campos de los TextBoxes
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtObraSocial.Clear();
            txtMotivo.Clear();
            txtFecha.Clear();
            txtHora.Clear();
        }


        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            // Validar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtObraSocial.Text) ||
                string.IsNullOrWhiteSpace(txtMotivo.Text) ||
                string.IsNullOrWhiteSpace(txtFecha.Text) ||
                string.IsNullOrWhiteSpace(txtHora.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar.");
                return;
            }

            // Validar la fecha
            DateTime fechaTurno;
            if (!DateTime.TryParse(txtFecha.Text, out fechaTurno))
            {
                MessageBox.Show("La fecha no es válida.");
                return;
            }

            if (fechaTurno < DateTime.Today)
            {
                MessageBox.Show("La fecha debe ser de hoy en adelante.");
                return;
            }

            // Validar la hora
            TimeSpan horaTurno;
            if (!TimeSpan.TryParse(txtHora.Text, out horaTurno))
            {
                MessageBox.Show("La hora no es válida.");
                return;
            }

            if (horaTurno < new TimeSpan(9, 0, 0) || horaTurno > new TimeSpan(20, 0, 0))
            {
                MessageBox.Show("La hora debe estar entre las 09:00 y las 20:00.");
                return;
            }

            // Validar si el DNI y el Teléfono son numéricos
            if (!int.TryParse(txtDNI.Text, out _) || !int.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("El DNI y el Teléfono deben ser números válidos.");
                return;
            }

            // Verificar si ya existe un turno con la misma fecha y hora
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string queryCheck = "SELECT COUNT(*) FROM Turnos WHERE Fecha = @Fecha AND Hora = @Hora";
                using (MySqlCommand commandCheck = new MySqlCommand(queryCheck, connection))
                {
                    commandCheck.Parameters.AddWithValue("@Fecha", fechaTurno.ToString("yyyy-MM-dd"));
                    commandCheck.Parameters.AddWithValue("@Hora", horaTurno.ToString(@"hh\:mm"));

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(commandCheck.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Ya existe un turno programado para la misma fecha y hora.");
                            return;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error al verificar los turnos existentes: {ex.Message}");
                        return;
                    }
                }

                // Si no hay duplicados, continuar con la inserción
                string query = "INSERT INTO Turnos (Nombre, Apellido, DNI, Telefono, `Obra Social`, `Motivo Consulta`, Fecha, Hora) " +
                               "VALUES (@Nombre, @Apellido, @Dni, @Telefono, @ObraSocial, @MotivoConsulta, @Fecha, @Hora)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Usar parámetros
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    command.Parameters.AddWithValue("@Dni", txtDNI.Text);
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    command.Parameters.AddWithValue("@ObraSocial", txtObraSocial.Text);
                    command.Parameters.AddWithValue("@MotivoConsulta", txtMotivo.Text);
                    command.Parameters.AddWithValue("@Fecha", fechaTurno.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Hora", horaTurno.ToString(@"hh\:mm"));

                    try
                    {
                        int result = command.ExecuteNonQuery(); // Ejecutar el comando SQL

                        if (result > 0)
                        {
                            MessageBox.Show("Datos agregados correctamente.");
                            CargarDatos(); // Recargar los datos en el DataGridView
                            LimpiarCampos(); // Limpiar los campos de texto
                        }
                        else
                        {
                            MessageBox.Show("No se pudieron agregar los datos.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error al agregar los datos: {ex.Message}");
                    }
                }
            }
        }


        private void btnModificar_Click(object? sender, EventArgs e)
            {
                // Consulta SQL para modificar los datos
                string query = "UPDATE Turnos SET Nombre=@Nombre, Apellido=@Apellido, DNI=@Dni, Telefono=@Telefono, " +
                               "`Obra Social`=@ObraSocial, `Motivo Consulta`=@MotivoConsulta, Fecha=@Fecha, Hora=@Hora " +
                               "WHERE idPaciente=@idPaciente";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Usar parámetros para evitar inyección de SQL
                        command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                        command.Parameters.AddWithValue("@Dni", txtDNI.Text);
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        command.Parameters.AddWithValue("@ObraSocial", txtObraSocial.Text);
                        command.Parameters.AddWithValue("@MotivoConsulta", txtMotivo.Text);
                        command.Parameters.AddWithValue("@Fecha", txtFecha.Text);
                        command.Parameters.AddWithValue("@Hora", txtHora.Text);
                        command.Parameters.AddWithValue("@idPaciente", idPaciente);

                        try
                        {
                            connection.Open();
                            int result = command.ExecuteNonQuery(); // Ejecutar el comando SQL

                            if (result > 0)
                            {
                                MessageBox.Show("Datos modificados correctamente.");
                                CargarDatos(); // Recargar los datos en el DataGridView
                                LimpiarCampos(); // Limpiar los campos de texto
                            }
                            else
                            {
                                MessageBox.Show("No se pudieron modificar los datos.");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show($"Error al modificar los datos: {ex.Message}");
                        }
                    }
                }
            }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            // Confirmación antes de eliminar
            var confirmResult = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);


            if (confirmResult == DialogResult.Yes)
            {
                // Consulta SQL para eliminar los datos
                string query = "DELETE FROM Turnos WHERE idPaciente=@idPaciente";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Usar el ID del paciente seleccionado
                        command.Parameters.AddWithValue("@idPaciente", idPaciente);

                        try
                        {
                            connection.Open();
                            int result = command.ExecuteNonQuery(); // Ejecutar el comando SQL

                            if (result > 0)
                            {
                                MessageBox.Show("Datos eliminados correctamente.");
                                CargarDatos(); // Recargar los datos en el DataGridView
                                LimpiarCampos(); // Limpiar los campos de texto
                            }
                            else
                            {
                                MessageBox.Show("No se pudieron eliminar los datos.");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show($"Error al eliminar los datos: {ex.Message}");
                        }
                    }
                }
            }
        }




                private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
                {
                    if (isLoading || e.RowIndex < 0 || dataGridView1.SelectedRows.Count == 0)
                        return;

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Asignar los valores a los TextBox
                    txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                    txtApellido.Text = row.Cells["Apellido"].Value?.ToString() ?? "";
                    txtDNI.Text = row.Cells["DNI"].Value?.ToString() ?? "";
                    txtTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? "";
                    txtObraSocial.Text = row.Cells["Obra Social"].Value?.ToString() ?? "";
                    txtMotivo.Text = row.Cells["Motivo Consulta"].Value?.ToString() ?? "";
                    txtFecha.Text = row.Cells["Fecha"].Value?.ToString() ?? "";
                    txtHora.Text = row.Cells["Hora"].Value?.ToString() ?? "";

                    // Asignar el valor de idPaciente
                    idPaciente = int.Parse(row.Cells["idPaciente"].Value?.ToString() ?? "0");
                }


                // Filtrar los datos cuando cambie el texto en el TextBox
                private void txtBuscar_TextChanged_1(object sender, EventArgs e)
                {
                    string filter = txtBuscar.Text.Trim(); // Capturamos el texto del TextBox
                    DataView dv = new DataView(dataTable); // Usamos el dataTable global

                    // Aplicamos el filtro para el DNI
                    dv.RowFilter = string.Format("CONVERT(DNI, System.String) LIKE '%{0}%'", filter);

                    // Asignamos el filtro al DataGridView
                    dataGridView1.DataSource = dv;
                }


            }
        }
    
         

    


