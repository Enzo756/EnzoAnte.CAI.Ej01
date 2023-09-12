namespace EnzoAnte.CAI.Ej01
{
    public partial class FormPrincipal : Form
    {
        Ejercicio01Model modelo;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            modelo = new Ejercicio01Model();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            modelo.DocumentoIngresado = this.txtDocumento.Text;
            modelo.NombreIngresado = this.txtNombre.Text;
            modelo.ApellidoIngresado = this.txtApellido.Text;
            modelo.FechaNacimientoIngresado = this.txtFechaNacimiento.Text;

            string mensaje = modelo.Validar();
            MessageBox.Show(mensaje);
        }
    }
}