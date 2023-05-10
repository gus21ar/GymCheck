
using GymDBData.Repositorio;
using Servicios.Dto;
using Servicios.Observer.Attendance.Implementacion;
using Servicios.Observer.Attendance.Interfaces;
using Servicios.Observer.Implementacion;

namespace Miselaneas
{
	public partial class FSemaforo : Form, IObservar
	{
		private static FSemaforo fSemaforo;
		public static FSemaforo Instacia
		{
			get
			{
				return fSemaforo ?? (fSemaforo = new FSemaforo());
			}
		}
		CPagoRepo repoPago;
		CAsistenciasRepo asistenciasRepo;
		CClienteRepo oClienteRepo;
		bool flagPanelColor;

		private FSemaforo()
		{

			InitializeComponent();
			repoPago = new CPagoRepo();
			asistenciasRepo = new CAsistenciasRepo();
			oClienteRepo = new CClienteRepo();
			CPublicar.Instancia.Suscribir(this);
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			flagPanelColor = true;
			var dni = Convert.ToInt32(txtDni.Text);
			if (repoPago.HayPago(dni))
			{
				var dias = repoPago.DiasRestantes(dni);
				if (dias > 5)
				{
					// Si hay pago y dias restantes es mayor a 0, el semaforo es verde
					ColorPanels(1);
					lblVerde.Text = "Disfrute su estadía en el gimnasio";
					lblVerde.ForeColor = Color.White;
					GuardarAsistencia();
					CAcceso acceso = new CAcceso();
					acceso.NombreCompleto = oClienteRepo.ObtenerNombreCompleto(oClienteRepo.ObtenerIdCliente(Convert.ToInt32(txtDni.Text)));
					acceso.Dni = txtDni.Text;
					acceso.Mensaje = "Cliente Habilitado para el ingreso";
					acceso.Semaforo = Color.Green;
					CPublicador.Instancia.Notificar(acceso);

				}
				else if (dias > 0)
				{
					// Si hay pago y dias restantes es menor o igual a 0, el semaforo es amarillo
					ColorPanels(2);
					lblAmarillo.Text = "Su pago vence en " + dias + " días";
					GuardarAsistencia();
					CAcceso acceso = new CAcceso();
					acceso.NombreCompleto = oClienteRepo.ObtenerNombreCompleto(oClienteRepo.ObtenerIdCliente(Convert.ToInt32(txtDni.Text)));
					acceso.Dni = txtDni.Text;
					acceso.Mensaje = "Cliente Habilitado para el ingreso \n " + dias + " días " +
						"para el vencimiento";
					acceso.Semaforo = Color.Yellow;
					CPublicador.Instancia.Notificar(acceso);
				}
				else if (dias == 0)
				{
					// Si hay pago y dias restantes es menor o igual a 0, el semaforo es amarillo
					ColorPanels(2);
					lblAmarillo.Text = "Su pago vence hoy";
					GuardarAsistencia();
					CAcceso acceso = new CAcceso();
					acceso.NombreCompleto = oClienteRepo.ObtenerNombreCompleto(oClienteRepo.ObtenerIdCliente(Convert.ToInt32(txtDni.Text)));
					acceso.Dni = txtDni.Text;
					acceso.Mensaje = "Cliente Habilitado para el ingreso \n Hoy vence la cuota";
					acceso.Semaforo = Color.Yellow;
					CPublicador.Instancia.Notificar(acceso);
				}
				else
				{
					// Si hay pago y dias restantes es menor o igual a 0, el semaforo es rojo
					ColorPanels(3);
					lblRojo.Text = "Su pago está vencido ";
					CAcceso acceso = new CAcceso();
					acceso.NombreCompleto = oClienteRepo.ObtenerNombreCompleto(oClienteRepo.ObtenerIdCliente(Convert.ToInt32(txtDni.Text)));
					acceso.Dni = txtDni.Text;
					acceso.Mensaje = "Cliente no habilitado para el ingreso";
					acceso.Semaforo = Color.Red;
					CPublicador.Instancia.Notificar(acceso);
				}
			}
			else
			{
				// Si no hay pago, el semaforo es rojo
				ColorPanels(3);
				lblRojo.Text = "No hay pagos registrados";
				CAcceso acceso = new CAcceso();
				acceso.NombreCompleto = "Cliente no registrado";
				acceso.Dni = "0";
				acceso.Mensaje = "Registrar Cliente por Favor";
				acceso.Semaforo = Color.Red;
				CPublicador.Instancia.Notificar(acceso);
			}
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

		private void txtDni_TextChanged(object sender, EventArgs e)
		{
			btnIngresar.Enabled = txtDni.Text.Length > 6;
			if (flagPanelColor)
			{
				ColorPanels(10);
				flagPanelColor = false;
			}
		}

		private void ColorPanels(int indice)
		{
			switch (indice)
			{
				case 1:
					pnlVerde.BackColor = Color.Green;
					lblVerde.Visible = true;
					break;
				case 2:
					pnlAmarillo.BackColor = Color.Yellow;
					lblAmarillo.Visible = true;
					break;
				case 3:
					pnlRojo.BackColor = Color.Red;
					lblRojo.Visible = true;
					break;
				default:
					pnlVerde.BackColor = pnlAmarillo.BackColor = pnlRojo.BackColor = this.BackColor;
					lblVerde.Visible = lblAmarillo.Visible = lblRojo.Visible = false;
					break;
			}
		}

		private void txtDni_Enter(object sender, EventArgs e)
		{
			txtDni.Text = string.Empty;
		}

		private void GuardarAsistencia()
		{
			var asistencia = new CAsistenciaDto();
			asistencia.IdCliente = oClienteRepo.ObtenerIdCliente(Convert.ToInt32(txtDni.Text));
			asistencia.Fecha = DateTime.Now;
			asistenciasRepo.Agregar(asistencia);
		}

		public void Actualizar()
		{
			ColorPanels(10);
			txtDni.Focus();
		}

		private void FSemaforo_FormClosed(object sender, FormClosedEventArgs e)
		{
			fSemaforo = null;
		}
	}
}
