using DAL.Models;
using Entity;
using Entity.DbModels;
using Mapper;
using System.Net.Sockets;

namespace DAL
{
    public class EventoData
    {
        public List<EventoEntity>  GetAll()
        {
            try
            {
                using var ctx = new AppDbContext();

                return ctx.Eventos.Select(e => EventoMapper.ToEntity(e)).ToList();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public EventoEntity GetById(int id)
        {
            try
            {
                using var ctx = new AppDbContext();

                var eventoDb = ctx.Eventos
                                  .FirstOrDefault(e => e.Id == id);

                if (eventoDb == null) throw new Exception("Evento no encontrado");

                return EventoMapper.ToEntity(eventoDb);
            }
            catch (Exception ex)
            {
                // aquí podrías loguear ex
                throw;
            }
        }
        public void UpdateOne(EventoEntity evento)
        {
            try
            {
                using var ctx = new AppDbContext();

                var eventoDb = ctx.Eventos
                                  .FirstOrDefault(e => e.Id == evento.Id);

                if (eventoDb == null) throw new Exception("Evento no encontrado");

                eventoDb.Nombre = evento.Nombre;
                eventoDb.Descripcion = evento.Descripcion;
                eventoDb.Precio = evento.Precio;
                eventoDb.Cantidad = evento.Cantidad;


                ctx.SaveChanges();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void CreateOne(EventoEntity evento)
        {
            try
            {
                using var ctx = new AppDbContext();
                Evento eventoDb = EventoMapper.ToDbModel(evento);

                ctx.Eventos.Add(eventoDb);
                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //public void DeleteOneById(int id)
        //{
        //    using var ctx = new AppDbContext();

        //    var eventoDb = ctx.Eventos.Find(id);   // busca por clave primaria

        //    if (eventoDb == null)
        //        throw new Exception($"No se encontró un evento con Id {id}.");

        //    ctx.Eventos.Remove(eventoDb);
        //    ctx.SaveChanges();
        //}
    }
}
