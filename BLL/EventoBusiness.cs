using DAL;
using Entity;
using Entity.DbModels;
using System.Transactions;
using Utils;

namespace BLL
{
    public class EventoBusiness
    {
        private EventoData eventoData = new();
        public List<EventoEntity> ListarEventos()
        {
            try
            {
                return eventoData.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al Evento ListarEventos: " + ex.Message);

            }
        }
        public EventoEntity ConseguirPorId(int id) {
            try
            {
                return eventoData.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al Evento: ConseguirPorId" + ex.Message);

            }
        }
        public void BajarCantidadEn1(int id)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    var selected = eventoData.GetById(id);

                    if (selected.Cantidad <= 0)
                        throw new InvalidOperationException("No se puede bajar la cantidad por debajo de 0.");

                    selected.Cantidad--;
                    eventoData.UpdateOne(selected);
                    trx.Complete();

                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error en el negocio al Evento BajarCantidadEn1: " + ex.Message);

            }
        }
        public bool CrearEvento(EventoEntity evento)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    ValidateEvento(evento);
                    eventoData.CreateOne(evento);
                    trx.Complete();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error en el negocio al Evento Crear Evento: " + ex.Message);
            }
        }

        public bool ActualizarEvento(EventoEntity evento)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    ValidateEvento(evento);
                    EventoEntity encontrado = ConseguirPorId(evento.Id);
                    if (encontrado == null) throw new Exception("Evento no encontrado para actualizar");
                    eventoData.UpdateOne(evento);
                    trx.Complete();
                    return true;

                }

            }
            catch (Exception ex)
            {

                throw new Exception("Error en el negocio al Evento Actualizar Evento: " + ex.Message);
            }
        }

        //public bool DeleteById(int id)
        //{
        //    try
        //    {
               
        //        EventoEntity encontrado = ConseguirPorId(id);
        //        if (encontrado == null) throw new Exception("Evento no encontrado para Borrar");
        //        eventoData.DeleteOneById(id);
        //        return true;

        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception("Error en el negocio al Evento Actualizar Evento: " + ex.Message);
        //    }
        //}

        private void ValidateEvento(EventoEntity evento)
        {
            if (evento == null)
                throw new ArgumentNullException(nameof(evento), "El evento no puede ser nulo.");

            // Nombre
            if (string.IsNullOrWhiteSpace(evento.Nombre) || evento.Nombre.Trim().Length <= 4)
                throw new ArgumentException("El nombre debe tener más de 4 caracteres.", nameof(evento.Nombre));

            // Descripción
            if (string.IsNullOrWhiteSpace(evento.Descripcion) || evento.Descripcion.Trim().Length <= 4)
                throw new ArgumentException("La descripción debe tener más de 4 caracteres.", nameof(evento.Descripcion));

            // Precio: puede ser 0, pero no menor a 0
            if (evento.Precio < 0)
                throw new ArgumentException("El precio no puede ser menor que 0.", nameof(evento.Precio));

            // Cantidad: puede ser null o >= 0, pero no menor a 0
            if (evento.Cantidad.HasValue && evento.Cantidad.Value < 0)
                throw new ArgumentException("La cantidad no puede ser menor que 0.", nameof(evento.Cantidad));

            // Id no se valida (según lo que comentaste)
        }
    }
}
