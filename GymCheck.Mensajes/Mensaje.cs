namespace GymCheck.Mensajes
{
	public static class Mensaje
	{
		public static DialogResult Mostrar(string titulo, string mensaje, TipoMensaje tipoMensaje)
		{
			FMensaje fMensaje = new FMensaje(titulo, mensaje, tipoMensaje);
			return fMensaje.ShowDialog();
		}
	}
	public enum TipoMensaje
	{
		Informacion,
		Pregunta,
		Advertencia,
		Error
	}
}