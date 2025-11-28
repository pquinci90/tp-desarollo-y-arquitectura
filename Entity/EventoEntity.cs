using Entity.DbModels;

namespace Entity
{
    public class EventoEntity
    {
        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        public int Id { get; set; }

        public double Precio { get; set; }

        public int? Cantidad { get; set; }

        //public List<TicketEntity> Tickets { get; set; } = new();
    }
}
