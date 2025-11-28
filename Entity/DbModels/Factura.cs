using System;
using System.Collections.Generic;

namespace Entity.DbModels;

public partial class Factura
{
    public int Id { get; set; }

    public string Usuario { get; set; } = null!;

    public string Metodo { get; set; } = null!;

    public double Monto { get; set; }

    public DateTime Fecha { get; set; }

    public bool Aprobado { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual Usuario UsuarioNavigation { get; set; } = null!;
}
