using System;
using System.Collections.Generic;

namespace GymDBData.Entidades;

public partial class Pago
{
    public int Id { get; set; }

    public double? Monto { get; set; }

    public int? IdMedioDePago { get; set; }

    public int? IdCliente { get; set; }

    public DateTime Fecha { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual MediosDePago? IdMedioDePagoNavigation { get; set; }
}
