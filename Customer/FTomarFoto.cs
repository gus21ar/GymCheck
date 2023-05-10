using AForge.Video;
using AForge.Video.DirectShow;
using GymCheck.Mensajes;
using System.Windows.Forms;

namespace Customer
{
	public partial class FTomarFoto : Form
	{
		private VideoCaptureDevice MiWebCam = null!;
		private FilterInfoCollection MisDispositivos = null!;
		private bool fotoTomada;
		private bool HayCamara;
		public FTomarFoto()
		{
			InitializeComponent();

		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			if (fotoTomada)
			{
				GuardarFoto();
				Salir();
			}
			else
			{
				if (Mensaje.Mostrar("No se ha tomado la foto",
					"Desea continuar", TipoMensaje.Pregunta) == DialogResult.Yes)
				{
					File.Copy(Manager.DefaultFilepath, Manager.RecienteFilepath, true);
					Salir();
				}
			}
		}

		private void GuardarFoto()
		{
			if (pbFoto.Image != null)
			{
				pbFoto.Image.Save(Manager.RecienteFilepath, System.Drawing.Imaging.ImageFormat.Jpeg);
			}

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			CerrarWebCam();
			this.Close();
		}

		private void FTomarFoto_Load(object sender, EventArgs e)
		{
			CargarDispositivos();
		}

		private void btnCapture_Click(object sender, EventArgs e)
		{
			if (MiWebCam != null && MiWebCam.IsRunning)
			{
				Bitmap image = (Bitmap)pbCamara.Image;
				pbFoto.Image = image;
			}
			fotoTomada = true;
		}
		private void Salir()
		{
			CerrarWebCam();
			Manager.Siguiente(Ventanas.DatosEscenciales);
		}


		private void FTomarFoto_Activated(object sender, EventArgs e)
		{
			CargarDispositivos();
		}

		private void btnIniciarCamara_Click(object sender, EventArgs e)
		{
			IniciarWebCam();
		}
		//Código Nuevo
		private void CargarDispositivos()
		{
			MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			if (MisDispositivos.Count > 0)
			{
				HayCamara = true;
				for (int i = 0; i < MisDispositivos.Count; i++)
				{
					cmbCamaras.Items.Add(MisDispositivos[i].Name.ToString());
				}
				cmbCamaras.Text = MisDispositivos[0].Name.ToString();
			}
			else
			{
				HayCamara = false;
			}
		}

		private void IniciarWebCam()
		{
			CerrarWebCam();
			int indice = cmbCamaras.SelectedIndex;
			MiWebCam = new VideoCaptureDevice(MisDispositivos[indice].MonikerString);
			MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
			MiWebCam.Start();
		}

		private void Capturando(object sender, NewFrameEventArgs eventArgs)
		{
			Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
			pbCamara.Image = Imagen;
		}

		private void CerrarWebCam()
		{
			if (MiWebCam != null && MiWebCam.IsRunning)
			{
				MiWebCam.SignalToStop();
				MiWebCam = null;
			}
		}

		private void FTomarFoto_FormClosed(object sender, FormClosedEventArgs e)
		{
			CerrarWebCam();
		}
	}
}
