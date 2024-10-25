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

    /**
 * Clase Form2 que hereda de Form.
 * Esta clase es responsable de manejar la interfaz de usuario
 * para la gestión de turnos en el consultorio.
 * 
 * Variables:
 * - connectionString: Cadena de conexión para la base de datos.
 * - idPaciente: Variable entera que almacena el ID del paciente
 *   seleccionado para operaciones de modificación y eliminación.
 * - isLoading: Bandera booleana que indica si los datos están siendo 
 *   cargados en el DataGridView para prevenir eventos no deseados
 *   durante la carga.
 */
    public partial class Form2 : Form
    {
        private string connectionString = "Server=127.0.0.1; Port=3306;Database=Pacientes;User Id=root;Password=ContraseñaBaseDeDatos;";

        // Declarar la variable idPaciente de tipo int
        private int idPaciente;

        private bool isLoading = true; // Bandera para controlar la carga

        /**
 * Constructor de la clase Form2. 
 * Inicializa los componentes del formulario, 
 * establece la conexión a la base de datos, 
 * limpia los campos de entrada y carga los datos 
 * en el DataGridView sin activar el evento RowEnter. 
 * Además, vincula los eventos de clic de los botones 
 * para agregar, modificar y eliminar turnos.
 */
        public Form2()
        {
            InitializeComponent();
            ConnectToDatabase();
            LimpiarCampos();
            CargarDatos(); // Cargar los datos sin activar el evento RowEnter

            // Asegurarse de que los botones estén vinculados a sus eventos
            btnAgregar.Click += btnAgregar_Click;
            btnModificar.Click += btnModificar_Click;
            btnEliminar.Click += btnEliminar_Click;

            isLoading = false; // Establecer a false después de cargar datos
        }

        /**
  * Establece una conexión con la base de datos MySQL utilizando 
  * la cadena de conexión especificada. Si la conexión es exitosa, 
  * se muestra un mensaje indicando que la conexión fue exitosa. 
  * En caso de error, se captura la excepción y se muestra 
  * un mensaje con el error.
  */
        public void ConnectToDatabase()
        {
            string connectionString = "Server=127.0.0.1; Port=3306;Database=Pacientes;User Id=root;Password=ContraseñaBaseDeDatos;";

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

        /**
 * Declarar una variable de clase para almacenar los datos 
 * de los turnos en un DataTable. Este DataTable se utilizará 
 * para llenar el DataGridView y gestionar los registros 
 * de la base de datos.
 */
        private DataTable dataTable = new DataTable();

        /**
  * Método que carga los datos de la tabla 'Turnos' en el DataGridView.
  * Este método realiza una consulta SQL para obtener todos los turnos,
  * ordenándolos por fecha y hora. Luego, asigna los datos a un DataTable 
  * y lo establece como fuente de datos para el DataGridView.
  */
        private void CargarDatos()
        {
            // Consulta SQL para obtener los datos de la tabla
            // Modifica la consulta para ordenar por Fecha y Hora
            string query = "SELECT * FROM Turnos ORDER BY STR_TO_DATE(CONCAT(Fecha, ' ', Hora), '%Y-%m-%d %H:%i')";

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

                    // Ocultar la columna idPaciente
                    dataGridView1.Columns["idPaciente"].Visible = false;

                    // Esperar hasta que los datos estén completamente cargados
                    Application.DoEvents(); // Procesar cualquier evento pendiente

                    // Desactivar selección automática
                    dataGridView1.ClearSelection();

                    isLoading = false; // Terminar el estado de carga
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                }
            }
        }

        /** 
 * Método que limpia los campos de texto en el formulario.
 * Este método se utiliza para restablecer los valores de los 
 * TextBox después de agregar, modificar o eliminar un turno.
 */
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

        /** 
  * Método que se ejecuta al hacer doble clic en una celda del DataGridView.
  * Asigna los valores de la fila seleccionada a los TextBox correspondientes.
  * 
  * @param sender El objeto que envía el evento.
  * @param e Los argumentos del evento que contienen información sobre la celda.
  */
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que no sea el encabezado
            {
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
        
                // Asignar el valor de idPaciente con manejo de excepciones
                try
                {
                    idPaciente = int.Parse(row.Cells["idPaciente"].Value?.ToString() ?? "0");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("El formato del ID del paciente no es válido. " + ex.Message);
                    idPaciente = 0; // Establecer un valor predeterminado o tomar otra acción
                }
            }
        }

        /** 
 * Método que se ejecuta al hacer clic en el botón Agregar.
 * Valida los datos ingresados y los inserta en la base de datos.
 * 
 * @param sender El objeto que envía el evento.
 * @param e Los argumentos del evento.
 */
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

             //Validar que el DNI tenga 8 digitos, y el telefono 10, ademas que sean numericos 
             if (txtDNI.Text.Length != 8 || !int.TryParse(txtDNI.Text, out _) || txtTelefono.Text.Length != 10 || !int.TryParse(txtTelefono.Text, out _))
             {
                 MessageBox.Show("El DNI debe tener exactamente 8 dígitos y el Teléfono debe tener exactamente 10 dígitos, ambos numéricos.");
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

        /** 
 * Método que se ejecuta al hacer clic en el botón Modificar.
 * Valida los datos ingresados, verifica si ya existe un turno
 * con la misma fecha y hora, y actualiza los datos en la base de datos.
 * 
 * @param sender El objeto que envía el evento.
 * @param e Los argumentos del evento.
 */
        private void btnModificar_Click(object? sender, EventArgs e)
        {
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

            //Validar que el DNI tenga 8 digitos, y el telefono 10, ademas que sean numericos 
            if (txtDNI.Text.Length != 8 || !int.TryParse(txtDNI.Text, out _) || txtTelefono.Text.Length != 10 || !int.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos y el Teléfono debe tener exactamente 10 dígitos, ambos numéricos.");
                return;
             }

            // Verificar si ya existe un turno con la misma fecha y hora
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string queryCheck = "SELECT COUNT(*) FROM Turnos WHERE Fecha = @Fecha AND Hora = @Hora AND idPaciente != @idPaciente";
                using (MySqlCommand commandCheck = new MySqlCommand(queryCheck, connection))
                {
                    commandCheck.Parameters.AddWithValue("@Fecha", fechaTurno.ToString("yyyy-MM-dd"));
                    commandCheck.Parameters.AddWithValue("@Hora", horaTurno.ToString(@"hh\:mm"));
                    commandCheck.Parameters.AddWithValue("@idPaciente", idPaciente);

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
            }

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
                    command.Parameters.AddWithValue("@Fecha", fechaTurno.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Hora", horaTurno.ToString(@"hh\:mm"));
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

        /** 
  * Método que se ejecuta al hacer clic en el botón Eliminar.
  * Verifica si se ha seleccionado un turno y lo elimina de la base de datos.
  * 
  * @param sender El objeto que envía el evento.
  * @param e Los argumentos del evento.
  */
        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un turno
            if (idPaciente <= 0)
            {
                MessageBox.Show("Por favor, seleccione un turno para eliminar.");
                return;
            }

            // Confirmar la eliminación
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este turno?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
            {
                return; // Salir si el usuario cancela
            }

            // Consulta SQL para eliminar el turno
            string query = "DELETE FROM Turnos WHERE idPaciente=@idPaciente";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPaciente", idPaciente);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery(); // Ejecutar el comando SQL

                        if (result > 0)
                        {
                            MessageBox.Show("Turno eliminado correctamente.");
                            CargarDatos(); // Recargar los datos en el DataGridView
                            LimpiarCampos(); // Limpiar los campos de texto
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el turno.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error al eliminar el turno: {ex.Message}");
                    }
                }
            }
        }
        /**
 * @brief Evento que se activa al hacer clic en una celda del DataGridView.
 * 
 * Este método asigna los valores de la fila seleccionada a los TextBox correspondientes
 * y almacena el idPaciente para operaciones posteriores.
 * 
 * @param sender El objeto que genera el evento.
 * @param e Contiene los datos del evento.
 */
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que se hace clic en una celda válida
            if (e.RowIndex >= 0) // Verifica que no sea el encabezado
            {
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
        }

        /**
         * @brief Filtra los datos del DataGridView al cambiar el texto en el TextBox de búsqueda.
         * 
         * Este método aplica un filtro basado en el texto ingresado en el TextBox,
         * permitiendo una búsqueda rápida por DNI.
         * 
         * @param sender El objeto que genera el evento.
         * @param e Contiene los datos del evento.
         */
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            string filter = txtBuscar.Text.Trim(); // Capturamos el texto del TextBox
            DataView dv = new DataView(dataTable); // Usamos el dataTable global

            // Aplicamos el filtro para el DNI
            dv.RowFilter = string.Format("CONVERT(DNI, System.String) LIKE '%{0}%'", filter);

            // Asignamos el filtro al DataGridView
            dataGridView1.DataSource = dv;
        }

        /**
         * @brief Evento que se activa al hacer doble clic en el formulario.
         * 
         * Este método muestra un cuadro de diálogo de confirmación para limpiar los campos.
         * Si el usuario confirma, se limpian los campos y se deselecciona cualquier fila
         * en el DataGridView.
         * 
         * @param sender El objeto que genera el evento.
         * @param e Contiene los datos del evento.
         */
        private void Form2_DoubleClick(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro que desea limpiar los campos?", "Confirmar limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario hace clic en "Sí", limpiar los campos
            if (result == DialogResult.Yes)
            {
                LimpiarCampos();
                dataGridView1.ClearSelection(); // Deseleccionar cualquier fila
            }
        }
    }
}







