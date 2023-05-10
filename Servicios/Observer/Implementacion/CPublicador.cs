
namespace Servicios.Observer.Implementacion
{
	public class CPublicador : IPublicador
	{
		public IAcceso OAcceso { get; set; }
		private static List<IObservador> _observadores;
		private static CPublicador _instance;
		private CPublicador() 
		{
			_observadores = new List<IObservador>(); 
			OAcceso = new CAcceso();
		}
		public static CPublicador Instancia 
		{
			get
			{
				if(_instance == null)
				{
					_instance = new CPublicador();
				}
				return _instance;
			}
		}

		public void Desuscribir(IObservador observador)
		{
			try
			{
				_observadores.Remove(observador);
			}
			catch 
			{
				
			}
		}

		public void Notificar(IAcceso acceso)
		{
			OAcceso = acceso;
			
			if(_observadores.Count > 0)
			{
				foreach (var observador in _observadores)
				{
					observador.Actualizar();
				}
			}
		}

		public void Suscribir(IObservador observador)
		{
			_observadores.Add(observador);
		}
	}
}
