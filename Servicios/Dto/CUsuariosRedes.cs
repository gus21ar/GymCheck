
using Servicios.Data;

namespace Servicios.Dto
{
	public class CUsuariosRedes : IUsuariosRedes
	{
		private string usuario = string.Empty;
		private string red = string.Empty;
		
		public string Usuario 
		{
			get
			{
				return usuario;
			}
			set
			{
				usuario = value;
			}
		}
		public string Red
		{
			get
			{
				return red;
			}
			set
			{
				red = value;
			}
		}
		public string Completo 
		{
			get 
			{
				return usuario + " " + red;
			}
			set { }			
		}
		public CUsuariosRedes()
		{
		}
		public CUsuariosRedes(string user, string net)
		{
			Usuario = user;
			Red = net;
		}


	}
}
