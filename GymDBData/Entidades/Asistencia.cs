using System;
using System.Collections.Generic;

namespace GymDBData.Entidades;

public partial class Asistencia
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public DateTime Fecha { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
