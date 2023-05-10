
namespace Customer
{
	public partial class FFechas : Form
	{
		public FFechas()
		{
			InitializeComponent();
		}

		private void btnAnterior_Click(object sender, EventArgs e)
		{
			Manager.Anterior(Ventanas.Redes);
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Manager.Cancelar();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			CargarDatos();
			Manager.Finalizar();
		}

		private void chbIngreso_CheckedChanged(object sender, EventArgs e)
		{
			dtpIngreso.Enabled = !chbIngreso.Checked;
		}

		public void CargarDatos()
		{
			Manager.ClienteNuevo.FechaNacimiento = dtpNacimiento.Value;
			Manager.ClienteNuevo.FechaInscripcion = chbIngreso.Checked ? DateTime.Now : dtpIngreso.Value;
			if (txtComentario.Text != string.Empty) Manager.ClienteNuevo.Comentario = txtComentario.Text;

		}
	}
}
