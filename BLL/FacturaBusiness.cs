using DAL;
using Entity;
using System.Transactions;
using Utils;

namespace BLL
{
    public class FacturaBusiness
    {
        private FacturaData facturaData = new FacturaData();
        private TicketBusiness ticketBusiness = new TicketBusiness();
        private FacturaEntity CrearFacturaTemporal(UsuarioEntity usuario, string metodo)
        {
            try
            {
                using (var trx = new TransactionScope())
                 { 
                        var facturaNoConfirmada = new FacturaEntity
                    {
                        Usuario = usuario,
                        Fecha = DateTime.Now,
                        Aprobado = false,
                        Monto = 0,
                        Metodo = metodo
                    };
                    var facturaCreadaDb = facturaData.CreateAndGet(facturaNoConfirmada);
                    trx.Complete();
                    return facturaCreadaDb;
                 }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al Factura: " + ex.Message);
            }

        }
        public bool CrearFactura(List<EventoEntity> carrito, UsuarioEntity usuario, string metodo)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    FacturaEntity temporal = CrearFacturaTemporal(usuario, metodo);
                    List<TicketEntity> ticketsPreparados = ticketBusiness.ConvertirEventosATickets(carrito, usuario, temporal);
                    ticketBusiness.SubirVariosTickets(ticketsPreparados);

                    temporal.Monto = CalcularTotal(carrito);
                    temporal.Aprobado = true;
                    temporal.Fecha = DateTime.Now;
                    facturaData.UpdateOne(temporal);
                    trx.Complete();
                    return true;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al Factura: " + ex.Message);
            }

        }
        public double CalcularTotal(List<EventoEntity> eventos)
        {
            return eventos.Sum(e => e.Precio);
        }
        public List<FacturaEntity> ListarFacturasByUsername(string username)
        {
            try
            {
                return facturaData.GetAllByUsername(username);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al Factura: " + ex.Message);
            }
        }
    }
}
