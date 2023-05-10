

using Control;
using GymCheck.Mensajes;
using GymDBData.Repositorio;
using Servicios.Data;
using System.Configuration;

namespace Miselaneas
{
	public partial class FReportes : Form
	{
		CReporteRepo CReporteRepo { get; set; }
		private List<IPersonaPdf> PersonaPdfList { get; set; }
		private List<IPagoPdf> PagoPdfList { get; set; }

		public FReportes()
		{
			InitializeComponent();
			Iniciar();
		}

		#region Eventos
		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void chbHoy_CheckedChanged(object sender, EventArgs e)
		{
			pnlFecha.Enabled = !chbHoy.Checked;
		}

		private void btnGenerar_Click(object sender, EventArgs e)
		{
			if (rbtAsistencias.Checked)
			{
				if (chbHoy.Checked)
				{
					PersonaPdfList = CReporteRepo.AsistenciasHoy();
					CargarAsistencias(PersonaPdfList);
				}
				else
				{
					PersonaPdfList = CReporteRepo.AsistenciasFecha(dtpDesde.Value, dtpHasta.Value);
					CargarAsistencias(PersonaPdfList);
				}
			}
			else
			{
				if (chbHoy.Checked)
				{
					PagoPdfList = CReporteRepo.PagosHoy();
					CargarPagos(PagoPdfList);
				}
				else
				{
					PagoPdfList = CReporteRepo.PagosFecha(dtpDesde.Value, dtpHasta.Value);
					CargarPagos(PagoPdfList);
				}
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			string titulo, parrafo, archivo;
			archivo = DateTime.Today.ToString("dd-MM-yyyy-HH-mm");
			if (rbtAsistencias.Checked)
			{
				archivo = "Asistencias " + archivo;
				titulo = "Asistencia";
				if (chbHoy.Checked)
				{
					parrafo = "Las asistencias del día de hoy " + DateTime.Today.ToString("dd'/'MM'/'yyyy");
				}
				else
				{
					parrafo = "Las asistencias desde el día " + dtpDesde.Value.ToString("dd'/'MM'/'yyyy");
					parrafo += "\n hasta el día " + dtpHasta.Value.ToString("dd'/'MM'/'yyyy") + " son: ";
				}
				CControlPdf.CrearPdf(titulo, parrafo, PersonaPdfList, archivo);
			}
			else
			{
				archivo = "Pagos " + archivo;
				titulo = "Pagos";
				if (chbHoy.Checked)
				{
					parrafo = parrafo = "Los pagos del día de hoy " + DateTime.Today.ToString("dd'/'MM'/'yyyy");
				}
				else
				{
					parrafo = "Los pagos desde el día " + dtpDesde.Value.ToString("dd'/'MM'/'yyyy");
					parrafo += "\n hasta el día " + dtpHasta.Value.ToString("dd'/'MM'/'yyyy") + " son: ";
				}
				CControlPdf.CrearPdf(titulo, parrafo, PagoPdfList, archivo);
			}
			Mensaje.Mostrar("Exito","El archivo se guardó correctamente",TipoMensaje.Informacion);
		}
		#endregion
		#region Metodos
		private void CargarAsistencias(List<IPersonaPdf> asistencias)
		{
			dgvVisor.DataSource = asistencias;
			dgvVisor.Columns["Nombre"].HeaderText = "Nombre";
			dgvVisor.Columns["Apellido"].HeaderText = "Apellido";
			dgvVisor.Columns["Dni"].HeaderText = "Dni";
		}

		private void CargarPagos(List<IPagoPdf> pagos)
		{
			dgvVisor.DataSource = pagos;
			dgvVisor.Columns["Nombre"].HeaderText = "Nombre";
			dgvVisor.Columns["Dni"].HeaderText = "Dni";
			dgvVisor.Columns["Fecha"].HeaderText = "Fecha";
			dgvVisor.Columns["Monto"].HeaderText = "Monto";
			dgvVisor.Columns["Medio"].HeaderText = "Medio de Pago";
		}
		
		private void Iniciar()
		{
			CReporteRepo = new();
			PersonaPdfList = new();
			PagoPdfList = new();
		}
		#endregion
	}
}
