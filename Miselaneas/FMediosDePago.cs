using GymCheck.Mensajes;
using GymDBData.Repositorio;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miselaneas
{
	public partial class FMediosDePago : Form
	{
		CMediosRepo repo = new CMediosRepo();
		public FMediosDePago()
		{
			InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (txtNombre.Text.IsNullOrEmpty())
			{
				Mensaje.Mostrar("¡Alto!","Debe ingresar un nombre",TipoMensaje.Advertencia);
				return;
			}
			try
			{
				repo.Agregar(txtNombre.Text);
				Mensaje.Mostrar("Exito","Medio de pago agregado correctamente", TipoMensaje.Informacion);
				this.Close();
			}
			catch (Exception ex)
			{
				Mensaje.Mostrar("¡Ups!", ex.Message,TipoMensaje.Error);
			}

		}
	}
}
