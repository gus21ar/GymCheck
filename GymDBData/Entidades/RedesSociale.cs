using System;
using System.Collections.Generic;

namespace GymDBData.Entidades;

public partial class RedesSociale
{
    public int Id { get; set; }

    public string NombreRed { get; set; } = null!;

    public virtual ICollection<UsuarioRedCliente> UsuarioRedClientes { get; set; } = new List<UsuarioRedCliente>();
}
