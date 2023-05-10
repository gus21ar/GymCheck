

namespace GymCheck.Mensajes
{
	public partial class FMensaje : Form
	{
		private FMensaje()
		{
			InitializeComponent();
		}
		public FMensaje(string titulo, string mensaje, TipoMensaje tipo)
		{
			InitializeComponent();
			lblTitulo.Text = titulo;
			lblMensaje.Text = mensaje;
			Colorear(tipo);
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnSI_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Yes;
			this.Close();
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.No;
			this.Close();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Colorear(TipoMensaje tipoMensaje)
		{
			switch (tipoMensaje)
			{
				case TipoMensaje.Informacion:
					string directorio = Application.StartupPath;
					Icon MiIcono = new Icon(directorio + @"Recursos\Informacion.ico");
					Image MiImagen = MiIcono.ToBitmap();
					pbIcono.Image = MiImagen;
					this.BackColor = Color.CornflowerBlue;					
					btnAceptar.Visible = true;
					break;
				case TipoMensaje.Error:
					directorio = Application.StartupPath;
					MiIcono = new Icon(directorio + @"Recursos\Error.ico");
					MiImagen = MiIcono.ToBitmap();
					pbIcono.Image = MiImagen;
					this.BackColor = Color.Firebrick;					
					btnAceptar.Visible = true;
					break;
				case TipoMensaje.Advertencia:
					directorio = Application.StartupPath;
					MiIcono = new Icon(directorio + @"Recursos\Advertencia.ico");
					MiImagen = MiIcono.ToBitmap();
					pbIcono.Image = MiImagen;
					this.BackColor = Color.Goldenrod;
					lblTitulo.ForeColor = Color.Black;
					lblMensaje.ForeColor = Color.Black;
					btnAceptar.Visible = true;
					break;
				case TipoMensaje.Pregunta:
					directorio = Application.StartupPath;
					MiIcono = new Icon(directorio + @"Recursos\Pregunta.ico");
					MiImagen = MiIcono.ToBitmap();
					pbIcono.Image = MiImagen;
					this.BackColor = Color.CornflowerBlue;					
					btnSI.Visible = true;
					btnNo.Visible = true;
					btnAceptar.Visible = false;
					break;

			}
		}
	}
}
