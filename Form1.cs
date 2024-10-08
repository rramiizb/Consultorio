namespace Consultorio
{
    public partial class Form1 : Form
    {
        // Contraseña predefinida
        private const string password = "miconsultorio"; // Cambia esto a la contraseña que desees

        public Form1()
        {
            InitializeComponent();
        }

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
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
