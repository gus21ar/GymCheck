

namespace Customer
{
	public partial class FContacto : Form
	{
		public FContacto()
		{
			InitializeComponent();
		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			CargarDatos();
			Manager.Siguiente(Ventanas.Redes);
		}

		private void btnAnterior_Click(object sender, EventArgs e)
		{
			CargarDatos();
			Manager.Anterior(Ventanas.DatosEscenciales);
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Manager.Cancelar();
		}
		private void CargarDatos()
		{
			if (txtTelefono.Text != string.Empty) Manager.ClienteNuevo.Telefono = txtTelefono.Text;
			if (txtDireccion.Text != string.Empty) Manager.ClienteNuevo.Direccion = txtDireccion.Text;
			if (txtMail.Text != string.Empty) Manager.ClienteNuevo.Mail = txtMail.Text;
		}
	}
}
