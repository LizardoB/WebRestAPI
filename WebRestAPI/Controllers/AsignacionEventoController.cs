using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebRestAPI.Controllers
{
    public class AsignacionEventoController : ApiController
    {
        ingSoftwareEntitiesBD BD = new ingSoftwareEntitiesBD();

        [HttpGet]
        public IEnumerable<AsignacionEvento> GetAsignacionEventos()
        {
            List<AsignacionEvento> listado = BD.AsignacionEvento.ToList();
            return listado;
        }

        [HttpPost]
        public bool PostAsignacionEventos(AsignacionEvento asignacionEvento)
        {
            BD.AsignacionEvento.Add(asignacionEvento);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool PutAsignacionEventos(AsignacionEvento asignacionEvento)
        {
            AsignacionEvento asignacionEventoActualizado = BD.AsignacionEvento.FirstOrDefault(x => x.idAsignacionEvento == asignacionEvento.idAsignacionEvento);
            asignacionEventoActualizado.idEvento = asignacionEvento.idEvento;
            asignacionEventoActualizado.idAsigacionCatedratico = asignacionEvento.idAsigacionCatedratico;
            asignacionEventoActualizado.Fecha = asignacionEvento.Fecha;
            asignacionEventoActualizado.Finalizado = asignacionEvento.Finalizado;
            return BD.SaveChanges() > 0;
        }

    }
}
