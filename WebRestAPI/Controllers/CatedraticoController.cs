using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebRestAPI.Controllers
{
    public class CatedraticoController : ApiController
    {
        ingSoftwareEntitiesBD BD = new ingSoftwareEntitiesBD();

        [HttpGet]
        public IEnumerable<Catedratico> GetCatedraticos()
        {
            List<Catedratico> listado = BD.Catedratico.ToList();
            return listado;
        }

        [HttpPost]
        public bool PostCatedraticos(Catedratico catedratico)
        {
            BD.Catedratico.Add(catedratico);
            return BD.SaveChanges() > 0;
        }

        [HttpPut]
        public bool PutCatedraticos(Catedratico catedratico)
        {
            Catedratico catedraticoActualizado = BD.Catedratico.FirstOrDefault(x => x.idCatedratico == catedratico.idCatedratico);
            catedraticoActualizado.Nombres = catedratico.Nombres;
            catedraticoActualizado.Apellidos = catedratico.Apellidos;
            catedraticoActualizado.Email = catedratico.Email;
            catedraticoActualizado.Usuario = catedratico.Usuario;
            catedraticoActualizado.Password = catedratico.Password;

            return BD.SaveChanges() > 0 ;
        }

        [HttpDelete]
        public bool DeleteCatedraticos(int idCatedratico)
        {
            Catedratico catedraticoEliminado = BD.Catedratico.FirstOrDefault(x => x.idCatedratico == idCatedratico);
            BD.Catedratico.Remove(catedraticoEliminado);
            return BD.SaveChanges() > 0;
        }
    }
}
