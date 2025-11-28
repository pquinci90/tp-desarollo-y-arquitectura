using Entity.DbModels;

namespace Entity
{
    public class UsuarioEntity
    {
        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public int Dni { get; set; }

        public string Contraseña { get; set; } = null!;

        public string Usuario { get; set; } = null!;

        public bool Admin { get; set; }

        //public List<FacturaEntity> Facturas { get; set; } = new();
        //public List<TicketEntity> Tickets { get; set; } = new();

    }
}
