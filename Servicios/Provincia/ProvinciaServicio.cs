using Dominio.UnidadDeTrabajo;
using IServicios.Provincia;
using IServicios.Provincia.DTOs;
using System.Collections.Generic;

namespace Servicios.Provincia
{
    //implementacion de IProvinciaServicio
    public class ProvinciaServicio : IProvinciaServicio
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public ProvinciaServicio(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public ProvinciaDto Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ProvinciaDto> Get(string cadenaBuscar)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(ProvinciaDto dto)
        {
            var entidad = new Dominio.Entidades.Provincia
            {
                Descripcion = dto.Descripcion,
                EstaEliminado = false
            };

            _unidadDeTrabajo.ProvinciaRepositorio.Insert(entidad);
        }

        public void Update(ProvinciaDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}
