namespace Consultorio
{
    /// <summary>
    /// Clase principal del formulario de acceso.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Contraseña predefinida.
        /// Cambia esto a la contraseña que desees.
        /// </summary>
        private const string password = "miconsultorio";

        /// <summary>
        /// Constructor del formulario Form1.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento clic del botón de acceso.
        /// Verifica si la contraseña ingresada es correcta.
        /// Si es correcta, muestra el segundo formulario (Form2).
        /// Si es incorrecta, muestra un mensaje de error.
        /// </summary>
        /// <param name="sender">El objeto que envía el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Verificar si la contraseña es correcta
            if (txtContraseña.Text == password)
            {
                // Crear una instancia del segundo formulario
                Form2 form2 = new Form2();
                form2.Show(); // Mostrar el segundo formulario

                this.Hide(); // Opcional: ocultar el primer formulario
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Inténtalo de nuevo.");
            }
        }
    }
}
