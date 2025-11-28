using DAL.Models;
using Entity;
using Entity.DbModels;
using Mapper;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class TicketData
    {
        public void Create(TicketEntity ticket)
        {
            try
            {
                using var ctx = new AppDbContext();

                // Mapear de entidad de negocio a modelo de BD
                Ticket ticketDb = TicketMapper.ToDbModel(ticket);

                ctx.Tickets.Add(ticketDb);
                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Create(List<TicketEntity> tickets)
        {
            try
            {
                using var ctx = new AppDbContext();

                foreach (var ticket in tickets)
                {
                    var ticketDb = TicketMapper.ToDbModel(ticket);
                    ctx.Tickets.Add(ticketDb);
                }

                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<TicketEntity> GetAllByUsername(string username)
        {
            try
            {
                using var ctx = new AppDbContext();

                var ticketsDb = ctx.Tickets
                    .Include(t => t.UsuarioNavigation)
                    .Include(t => t.IdEventoNavigation)
                    .Include(t => t.IdFacturaNavigation)
                        .ThenInclude(f => f.UsuarioNavigation)   // <--- añadir esto
                    .Where(t => t.Usuario == username)
                    .ToList();

                return ticketsDb
                    .Select(TicketMapper.ToEntity)
                    .ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public TicketEntity GetById(int id)
        {
            try
            {
                using var ctx = new AppDbContext();

                var ticketDb = ctx.Tickets
                    .Include(t => t.UsuarioNavigation)
                    .Include(t => t.IdEventoNavigation)
                    .Include(t => t.IdFacturaNavigation)
                        .ThenInclude(f => f.UsuarioNavigation)
                    .FirstOrDefault(t => t.Id == id);

                if (ticketDb == null) throw new Exception("Ticket no encontrado");

                return TicketMapper.ToEntity(ticketDb);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateOne(TicketEntity ticket)
        {
            try
            {
                using var ctx = new AppDbContext();

                var ticketDb = ctx.Tickets
                    .Include(t => t.UsuarioNavigation)
                    .Include(t => t.IdEventoNavigation)
                    .Include(t => t.IdFacturaNavigation)
                    .ThenInclude(f => f.UsuarioNavigation)
                    .FirstOrDefault(t => t.Id == ticket.Id);

                if (ticketDb == null)
                    throw new Exception("Ticket no encontrado");

                ticketDb.Usuario = ticket.Usuario.Usuario; 
                ticketDb.IdEvento = ticket.Evento.Id;
                ticketDb.IdFactura = ticket.Factura.Id;

                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
