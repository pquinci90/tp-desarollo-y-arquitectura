using System;
using System.Collections.Generic;

namespace Entity.DbModels;

public partial class Evento
{
    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Id { get; set; }

    public double Precio { get; set; }

    public int? Cantidad { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
