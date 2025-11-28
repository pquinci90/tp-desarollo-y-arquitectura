using System;
using System.Collections.Generic;

namespace Entity.DbModels;

public partial class Ticket
{
    public string Usuario { get; set; } = null!;

    public int IdEvento { get; set; }

    public int Id { get; set; }

    public int IdFactura { get; set; }

    public virtual Evento IdEventoNavigation { get; set; } = null!;

    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    public virtual Usuario UsuarioNavigation { get; set; } = null!;
}
