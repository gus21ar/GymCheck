using GymDBData.Repositorio;
using Servicios.Data;
using Servicios.Dto;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Customer
{
	public enum Ventanas
	{
		TomarFoto,
		DatosEscenciales,
		Contacto,
		Redes,
		Confirmacion
	}
	public static class Manager 
	{
		private static Dictionary<Ventanas, Form> VentanasActuales { get; set; } = null!; 
		public static ICliente ClienteNuevo { get; set; } = null!;
		public static List<IUsuariosRedes> UsuariosRedesList { get; set; } = null!;

		public static string DefaultDirectory { get; set; } = null!;
		public static string BuckUpDirectory { get; set; } = null!;
		public static string DefaultFilepath { get; set; } = null!;
		public static string RecienteFilepath { get; set; } = null!;

		private static Form padre = new Form();
		
		public static void Iniciar(Form Padre)
		{
			DefaultDirectory = ConfigurationManager.AppSettings["RutaFotos"]??string.Empty;
			BuckUpDirectory = ConfigurationManager.AppSettings["RutaBuckUp"]??string.Empty;
			DefaultFilepath = DefaultDirectory + "Default.jpg";
			RecienteFilepath = DefaultDirectory + "Reciente.jpg";
			ClienteNuevo = new CClienteDto();
			padre = Padre;
			var ventana = new FTomarFoto();
			VentanasActuales = new Dictionary<Ventanas, Form>();
			VentanasActuales.Add(Ventanas.TomarFoto, ventana);
			ventana.ShowDialog();
		}
		public static void ReIniciar()
		{
			var cliente = new CClienteDto();
			ClienteNuevo = cliente;
			var ventana = new FTomarFoto();
			VentanasActuales.Clear();
			VentanasActuales.Add(Ventanas.TomarFoto, ventana);
			ventana.ShowDialog();
		}
		public static void Siguiente(Ventanas win)
		{
			if (VentanasActuales.ContainsKey(win))
			{				
				VentanasActuales[win].Activate(); 
			}
			else
			{
				switch (win)
				{
					case Ventanas.TomarFoto:
						var ventana = new FTomarFoto();
						VentanasActuales.Add(Ventanas.TomarFoto, ventana);
						ventana.Show();
						break;
					case Ventanas.DatosEscenciales:
						var ventana2 = new FDatosEscenciales();
						VentanasActuales.Add(Ventanas.DatosEscenciales, ventana2);
						ventana2.Show();
						break;
					case Ventanas.Contacto:
						var ventana3 = new FContacto();
						VentanasActuales.Add(Ventanas.Contacto, ventana3);
						ventana3.Show();
						break;
					case Ventanas.Redes:
						var ventana4 = new FAddRedes();
						VentanasActuales.Add(Ventanas.Redes, ventana4);
						ventana4.Show();
						break;
					case Ventanas.Confirmacion:
						var ventana5 = new FFechas();
						VentanasActuales.Add(Ventanas.Confirmacion, ventana5);
						ventana5.Show();
						break;
				}
			}
		}
		public static void Anterior(Ventanas win)
		{
			
			if (VentanasActuales.ContainsKey(win))
			{				
				VentanasActuales[win].Activate();
			}
			else
			{
				Cancelar();
			}
		}
		public static void Finalizar()
		{
			try
			{
				ClienteNuevo.RutaFoto = DefaultDirectory + ClienteNuevo.Dni + ".jpg";
				CClienteRepo repo = new CClienteRepo();
				repo.Agregar(ClienteNuevo);				
				GuardarFotos(ClienteNuevo.Dni??string.Empty);
				if(UsuariosRedesList != null && UsuariosRedesList.Count >0)
				{
					var aux = Convert.ToInt32(ClienteNuevo.Dni);
					repo.AgregarRedes(aux, UsuariosRedesList);
				}
				MessageBox.Show("Cliente agregado correctamente");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Cancelar();
			}
		}
		public static void Cancelar()
		{
			foreach (var item in VentanasActuales)
			{
				item.Value.Close();
			}
			VentanasActuales.Clear();
			padre.Activate();
		}
		public static void GuardarFotos(string dni)
		{			
			string ruta = DefaultDirectory+dni+".jpg";
			string buckup = BuckUpDirectory + dni + ".jpg";
			File.Copy(RecienteFilepath, ruta, true);
			File.Copy(RecienteFilepath, buckup, true);
		}
	}
}
