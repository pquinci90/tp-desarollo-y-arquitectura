using DAL.Models;
using Entity;
using Entity.DbModels;
using Mapper;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class FacturaData
    {

        public FacturaEntity CreateAndGet(FacturaEntity factura)
        {
            try
            {
                using var ctx = new AppDbContext();

                var facturaDb = FacturaMapper.ToDbModel(factura);

                ctx.Facturas.Add(facturaDb);
                ctx.SaveChanges(); // genera el Id

                var facturaDbReloaded = ctx.Facturas
                    .Include(f => f.UsuarioNavigation)
                    .FirstOrDefault(f => f.Id == facturaDb.Id);

                if (facturaDbReloaded == null)
                    throw new Exception("No se pudo recuperar la factura recién creada.");

                return FacturaMapper.ToEntity(facturaDbReloaded);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public FacturaEntity UpdateOne(FacturaEntity factura)
        {
            try
            {
                using var ctx = new AppDbContext();

                var facturaDb = ctx.Facturas
                    .Include(f => f.UsuarioNavigation)
                    .FirstOrDefault(f => f.Id == factura.Id);

                if (facturaDb == null)
                    throw new Exception("Factura no encontrada.");

                facturaDb.Fecha = factura.Fecha;
                facturaDb.Monto = factura.Monto;
                facturaDb.Metodo = factura.Metodo;
                facturaDb.Aprobado = factura.Aprobado;

                ctx.SaveChanges();

                return FacturaMapper.ToEntity(facturaDb);
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
        public List<FacturaEntity> GetAllByUsername(string username)
        {
            try
            {
                using var ctx = new AppDbContext();
                var facturasDb = ctx.Facturas
                    .Include(f => f.UsuarioNavigation)
                    .Where(f => f.Usuario == username)
                    .ToList();



                return facturasDb.Select(FacturaMapper.ToEntity).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
