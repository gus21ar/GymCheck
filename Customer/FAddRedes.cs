using GymDBData.Repositorio;
using Servicios.Data;
using Servicios.Dto;

namespace Customer
{
	public partial class FAddRedes : Form
	{
		List<IUsuariosRedes> listaredes;
		CRedesRepo redesRepo; 
		public FAddRedes()
		{
			InitializeComponent();
			listaredes = new List<IUsuariosRedes>();
			redesRepo = new CRedesRepo();
			cmbRedes.DataSource = redesRepo.ObtenerNombresRedes();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Manager.Cancelar();
		}

		private void btnAnterior_Click(object sender, EventArgs e)
		{
			Manager.Anterior(Ventanas.Contacto);
		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			CargarDatos();
			Manager.Siguiente(Ventanas.Confirmacion);
		}

		private void CargarDatos()
		{
			if (listaredes.Count > 0)
			{
				Manager.UsuariosRedesList = listaredes;
			}
		}

		private void txtUsuario_TextChanged(object sender, EventArgs e)
		{
			btnAgregar.Enabled = txtUsuario.TextLength > 0;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			AgregarRed();
		}
		private void AgregarRed()
		{
			var red = new CUsuariosRedes();
			red.Usuario = txtUsuario.Text;
			red.Red = cmbRedes.Text;
			listaredes.Add(red);
			txtUsuario.Text = string.Empty;
			ActualizarLista();
			txtUsuario.Focus();
		}
		private void ActualizarLista()
		{
			lsbRedesUser.Items.Clear();
			lsbRedesUser.DataSource = listaredes;
			lsbRedesUser.DisplayMember = "Completo";
		}
		private void QuitarRed()
		{
			if (lsbRedesUser.SelectedIndex >= 0)
			{
				listaredes.RemoveAt(lsbRedesUser.SelectedIndex);
				ActualizarLista();
			}
		}

		private void btnQuitar_Click(object sender, EventArgs e)
		{
			QuitarRed();
		}
	}
}
