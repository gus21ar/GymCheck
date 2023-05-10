
using GymCheck.Mensajes;
using GymDBData.Repositorio;

namespace Miselaneas
{
	public partial class FRedesAdd : Form
	{

		CRedesRepo redesRepo = new CRedesRepo();
		public FRedesAdd()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (txtNombre.Text == "")
			{
				Mensaje.Mostrar("Faltan datos","El campo nombre debe estar completo",TipoMensaje.Advertencia);
				return;
			}
			try
			{
				if (txtNombre.Text == "") throw new Exception("Ingresar el Nombre");
				if (redesRepo.AgregarRedes(txtNombre.Text))
				{
					Mensaje.Mostrar("Red agregada", "Se ha agregado correctamente la red", TipoMensaje.Informacion);
					this.Close();
				}
				else
				{
					Mensaje.Mostrar("Error al agregar", "No se pudo agregar la red consulte al administrador", TipoMensaje.Error);
				}
			}
			catch (Exception ex)
			{
				Mensaje.Mostrar("Ups",ex.Message,TipoMensaje.Error);
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
