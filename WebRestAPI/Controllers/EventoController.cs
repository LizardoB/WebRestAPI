using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebRestAPI.Controllers
{
    public class EventoController : ApiController
    {
        ingSoftwareEntitiesBD BD = new ingSoftwareEntitiesBD();

        [HttpGet]
        public IEnumerable<Evento> GetEventos()
        {
            List<Evento> listado = BD.Evento.ToList();
            return listado;
        }

        [HttpPost]
        public bool PostEventos(Evento evento)
        {
            BD.Evento.Add(evento);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool PutEventos(Evento evento)
        {
            Evento eventoActualizado = BD.Evento.FirstOrDefault(x => x.idEvento == evento.idEvento);
            eventoActualizado.Nombre = evento.Nombre;
            eventoActualizado.Año = evento.Año;

            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool DeleteEventos(int idEvento)
        {
            Evento eventoEliminado = BD.Evento.FirstOrDefault(x => x.idEvento == idEvento);
            BD.Evento.Remove(eventoEliminado);
            return BD.SaveChanges() > 0;
        }
    }
}
