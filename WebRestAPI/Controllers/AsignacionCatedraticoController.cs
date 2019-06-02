using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebRestAPI.Controllers
{
    public class AsignacionCatedraticoController : ApiController
    {
        ingSoftwareEntitiesBD BD = new ingSoftwareEntitiesBD();

        [HttpPost]
        public bool PostAsignacionCatedraticos(AsignacionCatedratico asignacionCatedratico)
        {
            BD.AsignacionCatedratico.Add(asignacionCatedratico);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool PutAsignacionCatedraticos(AsignacionCatedratico asignacionCatedratico)
        {
            AsignacionCatedratico asignacionCatedraticoActualizado = BD.AsignacionCatedratico.FirstOrDefault(x => x.idAsignacionCatedratico == asignacionCatedratico.idAsignacionCatedratico);
            asignacionCatedraticoActualizado.idCurso = asignacionCatedratico.idCurso;
            asignacionCatedraticoActualizado.idCatedratico = asignacionCatedratico.idCatedratico;
            asignacionCatedraticoActualizado.Annio = asignacionCatedratico.Annio;
            asignacionCatedraticoActualizado.personGroupId = asignacionCatedratico.personGroupId;

            return BD.SaveChanges() > 0;
        }
    }
}
