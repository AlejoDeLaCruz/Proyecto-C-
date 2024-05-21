namespace Windows_Froms_Proyecto_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void verUsuarioYContrase�a_Click(object sender, EventArgs e)
        {
            string nombreUsuario = usuarioTextBox.Text;
            string contrasena = contrase�aTextBox.Text;

            // Mostrar el nombre de usuario y la contrase�a en los labels correspondientes
            label5.Text = "Tu usuario: " + nombreUsuario;
            label6.Text = "Tu contrase�a: " + contrasena;
        }

        private void GuardarUsuarioYContrase�a_Click(object sender, EventArgs e)
        {
            string nombreUsuario = usuarioTextBox.Text;
            string contrasena = contrase�aTextBox.Text;

            // Crear un nuevo usuario con los datos ingresados
            Usuario nuevoUsuario = new Usuario(0, "asd", "asd", nombreUsuario, contrasena, "asd");

            // Guardar el usuario en la base de datos
            UsuarioDataAccess dataAccess = new UsuarioDataAccess();
            dataAccess.InsertarUsuario(nuevoUsuario);

            MessageBox.Show("Usuario y contrase�a guardados con �xito");
        }
    }
}