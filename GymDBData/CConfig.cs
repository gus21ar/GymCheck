
using System.Configuration;

namespace GymDBData
{
	public static class CConfig
	{
		public static string ConnectionString 
		{
			get
			{
			 	return CrearCadena();
			}
		}

		private static string CrearCadena() 
		{
			//"Server=SAIKANO\\SQLEXPRESS; Database=GymDB; User=sa; Password=2016; TrustServerCertificate=True"
			string cadena = "Server=";
			cadena += ConfigurationManager.AppSettings["Servidor"];
			cadena += "; ";
			cadena += "Database=";
			cadena += ConfigurationManager.AppSettings["Database"];
			cadena += "; ";
			cadena += "User=";
			cadena += ConfigurationManager.AppSettings["User"];
			cadena += "; ";
			cadena += "Password=";
			cadena += ConfigurationManager.AppSettings["Password"];
			cadena += "; TrustServerCertificate=True";

			return cadena;
		}
	}
}
