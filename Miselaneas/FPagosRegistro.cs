using GymCheck.Mensajes;
using GymDBData.Repositorio;
using Servicios.Dto;

namespace Miselaneas
{
	public partial class FPagosRegistro : Form
	{
		CClienteRepo repoCliente = new CClienteRepo();
		CPagoRepo repoPago = new CPagoRepo();
		List<string> medios = new List<string>();
		public FPagosRegistro()
		{
			InitializeComponent();
			medios = repoPago.Medios();
			cmbMedios.DataSource = medios;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				var cli = Convert.ToInt32(txtDni.Text);
				if (repoCliente.HayClientes(cli))
				{
					Habilitar(cli);
				}
			}
			catch { Reset(); }

		}

		private void txtDni_TextChanged(object sender, EventArgs e)
		{
			btnBuscar.Enabled = txtDni.Text.Length > 0;
		}

		private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
		{
			//GPT
			// Verificar si la tecla presionada es un número o una tecla de control
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				// Si la tecla presionada no es un número o una tecla de control, cancelar la acción
				e.Handled = true;
			}
		}

		private void Reset()
		{
			btnBuscar.Enabled = panGeneral.Enabled = false;
			txtDni.Text = string.Empty;
		}

		private void Habilitar(int dniCliente)
		{
			lblCliente.Text = repoPago.LeyendaClienteDias(dniCliente);

			btnBuscar.Enabled = panGeneral.Enabled = true;
		}

		private void txtMonto_TextChanged(object sender, EventArgs e)
		{
			btnPagar.Enabled = txtMonto.Text.Length > 0;
		}

		private void btnPagar_Click(object sender, EventArgs e)
		{
			CPagoDto pago = new CPagoDto();
			pago.Fecha = DateTime.Now;
			var dnicliente = Convert.ToInt32(txtDni.Text);
			var aux = repoCliente.ObtenerIdCliente(dnicliente);		
			pago.IdCliente = aux;
			pago.MedioDePago = cmbMedios.SelectedItem.ToString();
			pago.Monto = Convert.ToDouble(txtMonto.Text);
			repoPago.Pagar(pago);
			var nc = repoCliente.ObtenerNombreCompleto(aux);
			Mensaje.Mostrar("Registro exitoso","Se ha registrado el pago de " + nc + " por $" + pago.Monto + " con " + pago.MedioDePago,TipoMensaje.Informacion);
			this.Close();
		}
	}
}
