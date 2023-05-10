using System;
using System.Collections.Generic;

namespace GymDBData.Entidades;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Mail { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public DateTime? FechaInscripcion { get; set; }

    public string? RutaFoto { get; set; }

    public string? Comentario { get; set; }

    public virtual ICollection<Asistencia> Asistencia { get; set; } = new List<Asistencia>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual ICollection<UsuarioRedCliente> UsuarioRedClientes { get; set; } = new List<UsuarioRedCliente>();
}
