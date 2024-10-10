namespace Consultorio
{
    public partial class Form1 : Form
    {
        // Contrase�a predefinida
        private const string password = "miconsultorio"; // Cambia esto a la contrase�a que desees

        public Form1()
        {
            InitializeComponent();
        }

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
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
