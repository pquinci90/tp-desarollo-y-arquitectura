using System;
using System.Collections.Generic;

namespace Entity.DbModels;

public partial class Usuario
{
    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Dni { get; set; }

    public string Contraseña { get; set; } = null!;

    public string Usuario1 { get; set; } = null!;

    public bool Admin { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}

