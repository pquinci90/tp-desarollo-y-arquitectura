using Entity.DbModels;

namespace Entity
{
    public class TicketEntity
    {
        public UsuarioEntity Usuario { get; set; }

        public int Id { get; set; }

        public FacturaEntity Factura { get; set; }

        public EventoEntity Evento { get; set; }

    }
}
