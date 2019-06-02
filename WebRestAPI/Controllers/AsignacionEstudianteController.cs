using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebRestAPI.Controllers
{
    public class AsignacionEstudianteController : ApiController
    {
        ingSoftwareEntitiesBD BD = new ingSoftwareEntitiesBD();

        [HttpGet]
        public IEnumerable<AsignacionEstudiante> GetAsignacionEstudiantes()
        {
            List<AsignacionEstudiante> listado = BD.AsignacionEstudiante.ToList();
            return listado;
        }

        [HttpPost]
        public bool PostAsignacionEstudiantes(AsignacionEstudiante asignacionEstudiante)
        {
            BD.AsignacionEstudiante.Add(asignacionEstudiante);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool PutAsignacionEstudiantes(AsignacionEstudiante asignacionEstudiante)
        {
            AsignacionEstudiante asignacionEstudianteActualizado = BD.AsignacionEstudiante.FirstOrDefault(x => x.idAsignacionEstudiante == asignacionEstudiante.idAsignacionEstudiante);
            asignacionEstudianteActualizado.idAsignacionCatedratico = asignacionEstudiante.idAsignacionCatedratico;
            asignacionEstudianteActualizado.idAsignacionEstudiante = asignacionEstudiante.idAsignacionEstudiante;

            return BD.SaveChanges() > 0;
        }
    }
}
