
namespace Servicios.Observer
{
	//Esta interfaz es para que los observadores puedan acceder a las propiedades de la clase publicador
	//Esta interfaz es para comunicar el semaforo con el formulario principal
	public interface IAcceso
	{
		string NombreCompleto { get; set; }
		string Dni { get; set; }
		string Mensaje { get; set; }		
		Color Semaforo { get; set; }
	}
}
