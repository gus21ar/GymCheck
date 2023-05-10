using System;
using System.Collections.Generic;

namespace GymDBData.Entidades;

public partial class UsuarioRedCliente
{
    public int IdCliente { get; set; }

    public int IdRed { get; set; }

    public string? Usuario { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual RedesSociale IdRedNavigation { get; set; } = null!;
}
