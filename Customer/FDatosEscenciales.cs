
namespace Customer
{
	public partial class FDatosEscenciales : Form
	{
		public FDatosEscenciales()
		{
			InitializeComponent();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Manager.Cancelar();
		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			CargarDatos();
			Manager.Siguiente(Ventanas.Contacto);
		}

		private void btnAnterior_Click(object sender, EventArgs e)
		{
			Manager.Anterior(Ventanas.TomarFoto);
		}
		private void CargarDatos()
		{
			Manager.ClienteNuevo.Nombre = txtNombre.Text;
			if (txtApellido.Text != string.Empty) Manager.ClienteNuevo.Apellido = txtApellido.Text;
			if (txtDni.Text != string.Empty) Manager.ClienteNuevo.Dni = txtDni.Text;
		}

		private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
		{
			//GPT
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtNombre_TextChanged(object sender, EventArgs e)
		{
			ValidarSiguiente();
		}
		private void ValidarSiguiente()
		{
			btnSiguiente.Enabled =
					(txtNombre.Text != string.Empty)
				&& (txtApellido.Text != string.Empty)
				&& (txtDni.Text != string.Empty)
				&& (txtDni.TextLength > 6);
		}
	}
}
