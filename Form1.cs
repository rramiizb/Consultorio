namespace Consultorio
{
    /// <summary>
    /// Clase principal del formulario de acceso.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Contrase�a predefinida.
        /// Cambia esto a la contrase�a que desees.
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
        /// Maneja el evento clic del bot�n de acceso.
        /// Verifica si la contrase�a ingresada es correcta.
        /// Si es correcta, muestra el segundo formulario (Form2).
        /// Si es incorrecta, muestra un mensaje de error.
        /// </summary>
        /// <param name="sender">El objeto que env�a el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Verificar si la contrase�a es correcta
            if (txtContrase�a.Text == password)
            {
                // Crear una instancia del segundo formulario
                Form2 form2 = new Form2();
                form2.Show(); // Mostrar el segundo formulario

                this.Hide(); // Opcional: ocultar el primer formulario
            }
            else
            {
                MessageBox.Show("Contrase�a incorrecta. Int�ntalo de nuevo.");
            }
        }
    }
}
