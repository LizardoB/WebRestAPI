using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebRestAPI.Controllers
{
    public class CursoController : ApiController
    {
        ingSoftwareEntitiesBD BD = new ingSoftwareEntitiesBD();

        [HttpGet]
        public IEnumerable<Curso> GetCurso()
        {
            IEnumerable<Curso> listado = BD.Curso.ToList();
            return listado;
        }

        [HttpPost]
        public bool PostCurso(Curso curso)
        {
            BD.Curso.Add(curso);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool PutCurso(Curso curso)
        {
            Curso cursoAtualizado = BD.Curso.FirstOrDefault(x => x.idCurso == curso.idCurso);
            cursoAtualizado.Nombre = curso.Nombre;
            cursoAtualizado.Ciclo = curso.Ciclo;
            return BD.SaveChanges() > 0;
        }

        [HttpDelete]
        public bool DeleteCurso(int idCurso)
        {
            Curso cursoEliminado = BD.Curso.FirstOrDefault(x => x.idCurso == idCurso);
            BD.Curso.Remove(cursoEliminado);
            return BD.SaveChanges() > 0;
        }
    }
}
