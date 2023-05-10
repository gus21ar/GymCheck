using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Servicios.Data;
using System.Configuration;
using GymDBData.Repositorio;

namespace Control
{
	public static class CControlPdf
	{
		public static void CrearPdf(string titulo, string descripcion,List<IPersonaPdf> personaPdfList,string fileName)
		{
			string path = ConfigurationManager.AppSettings["RutaPdf"] + fileName + ".pdf";
			// Create a writer instance
			PdfWriter writer = new PdfWriter(path);

			// Create a pdf document instance
			PdfDocument pdf = new PdfDocument(writer);

			// Create a document instance
			Document document = new Document(pdf);

			// Add a centered title
			Paragraph title = new Paragraph(titulo)
				.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
				.SetFontSize(20);
			document.Add(title);

			// Add a description paragraph
			Paragraph description = new Paragraph(descripcion);
			document.Add(description);

			// Create a table with three columns
			Table table = new Table(3);
			table.AddHeaderCell("Nombre");
			table.AddHeaderCell("Apellido");
			table.AddHeaderCell("Dni");

			// Add data to the table
			foreach (var persona in personaPdfList)
			{
				table.AddCell(persona.Nombre);
				table.AddCell(persona.Apellido);
				table.AddCell(persona.Dni);
			}

			// Add the table to the document
			document.Add(table);

			// Close the document
			document.Close();		
		}
		public static void CrearPdf(string titulo, string descripcion, List<IPagoPdf> pagoPdfList, string fileName)
		{
			string path = ConfigurationManager.AppSettings["RutaPdf"] + fileName + ".pdf";
			//string path = @"F:\Archivos\GymChek\Pdf\2023-05-0421:.pdf";
			// Create a writer instance
			PdfWriter writer = new PdfWriter(path);

			// Create a pdf document instance
			PdfDocument pdf = new PdfDocument(writer);

			// Create a document instance
			Document document = new Document(pdf);

			// Add a centered title
			Paragraph title = new Paragraph(titulo)
				.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
				.SetFontSize(20);
			document.Add(title);

			// Add a description paragraph
			Paragraph description = new Paragraph(descripcion);
			document.Add(description);

			// Create a table with three columns
			Table table = new Table(5);
			table.AddHeaderCell("Nombre");
			table.AddHeaderCell("Dni");
			table.AddHeaderCell("Fecha");
			table.AddHeaderCell("Monto");
			table.AddHeaderCell("Medio");

			// Add data to the table
			foreach (var persona in pagoPdfList)
			{
				table.AddCell(persona.Nombre);				
				table.AddCell(persona.Dni);
				table.AddCell(persona.Fecha);
				table.AddCell(persona.Monto);
				table.AddCell(persona.Medio);
			}

			// Add the table to the document
			document.Add(table);

			// Close the document
			document.Close();
		}
		public static void CrearPdfAutomático()
		{
			List<IPersonaPdf> PersonaPdfList = new List<IPersonaPdf>();
			List<IPagoPdf> PagoPdfList = new List<IPagoPdf>();
			CReporteRepo reporte = new CReporteRepo();
			PersonaPdfList = reporte.AsistenciasHoy();
			PagoPdfList = reporte.PagosHoy();
			string titulo, parrafo, archivo,aux;
			aux = DateTime.Now.ToString("dd-MM-yyyy-HH-mm");			
			archivo = "Asistencias " + aux;
			titulo = "Asistencia";				
			parrafo = "Las asistencias del día de hoy " + DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm");
			CControlPdf.CrearPdf(titulo, parrafo, PersonaPdfList, archivo);			
			archivo = "Pagos " + aux;
			titulo = "Pagos";				
			parrafo = "Los pagos del día de hoy " + DateTime.Today.ToString("dd'/'MM'/'yyyy HH:mm");				
			CControlPdf.CrearPdf(titulo, parrafo, PagoPdfList, archivo);			
		}

	}	
}
