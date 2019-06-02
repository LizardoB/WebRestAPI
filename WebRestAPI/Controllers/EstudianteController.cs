using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebRestAPI.Controllers
{
    public class EstudianteController : ApiController
    {
        ingSoftwareEntitiesBD BD = new ingSoftwareEntitiesBD();

        [HttpGet]
        public IEnumerable<Estudiante> GetEstudiantes()
        {
            List<Estudiante> listado = BD.Estudiante.ToList();
            return listado;
        }

        [HttpPost]
        public bool PostEstudiantes(Estudiante estudiante)
        {
            BD.Estudiante.Add(estudiante);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool PutEstudiantes(Estudiante estudiante)
        {
            Estudiante estudianteAtualizado = BD.Estudiante.FirstOrDefault(x => x.idEstudiante == estudiante.idEstudiante);
            estudianteAtualizado.Nombres = estudiante.Nombres;
            estudianteAtualizado.Apellidos = estudiante.Apellidos;
            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool DeleteEstudiantes(int idEstudiante)
        {
            Estudiante estudianteEliminado = BD.Estudiante.FirstOrDefault(x => x.idEstudiante == idEstudiante);
            BD.Estudiante.Remove(estudianteEliminado);
            return BD.SaveChanges() > 0;
        }

    }
}
