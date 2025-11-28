using DAL;
using Entity;
using System.Transactions;
using Utils;

namespace BLL
{
    public class TicketBusiness
    {
        private TicketData ticketData = new();
        private EventoBusiness eventoBusiness = new EventoBusiness();
        private UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        public List<TicketEntity> ListarTicketsByUsername(string username)
        {
            try
            {
                return ticketData.GetAllByUsername(username);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al Evento: " + ex.Message);

            }
        }

        public List<TicketEntity> ConvertirEventosATickets (List<EventoEntity> eventos, UsuarioEntity usuario, FacturaEntity factura)
        {
            try
            {
                List<TicketEntity> ListaACargar = new();
                foreach (EventoEntity evento in eventos)
                {
                    var a = new TicketEntity()
                    {
                        Usuario = usuario,
                        Evento = evento,
                        Factura = factura,
                    };
                    ListaACargar.Add(a);
                }
                return ListaACargar;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al Ticket: " + ex.Message);

            }
        }
        
        public void SubirVariosTickets(List<TicketEntity> tickets)
        {
            try
            {
                if (tickets == null || tickets.Count == 0)
                {
                    throw new Exception("No hay tickets para subir.");
                }
                using (var trx = new TransactionScope())
                {
                    foreach (var ticket in tickets)
                    {
                        var eventoDisponible = eventoBusiness.ConseguirPorId(ticket.Evento.Id);

                        if (eventoDisponible.Cantidad < 1) throw new Exception("No hay mas entradas");
                        eventoBusiness.BajarCantidadEn1(eventoDisponible.Id);
                        ticketData.Create(ticket);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al Ticket: " + ex.Message);

            }
        }
        public void EnviarTicket(UsuarioEntity user, int idTicket, string usernameDestino)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (user.Usuario == usernameDestino) throw new Exception("No se puede enviar el ticket al mismo usuario.");

                    var ticket = ticketData.GetById(idTicket);
                    if (ticket == null)
                        throw new Exception("Ticket no encontrado.");
                    if (user.Usuario != ticket.Usuario.Usuario) throw new Exception("El ticket no pertenece al usuario logueado.");

                    var usuarioDestino = usuarioBusiness.GetByUsuario(usernameDestino);
                    if (usuarioDestino == null)
                        throw new Exception("Usuario destino no encontrado.");



                    string usernameActual = SesionManageUtil.UsuarioActual.Usuario;

                    if (ticket.Usuario.Usuario != usernameActual)
                        throw new Exception("El ticket no pertenece al usuario logueado.");


                    ticket.Usuario = usuarioDestino;

                    ticketData.UpdateOne(ticket);

                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al enviar Ticket: " + ex.Message, ex);
            }
        }
    }
}
