using Dominio.UnidadDeTrabajo;
using IServicios.Provincia;
using IServicios.Provincia.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

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
            _unidadDeTrabajo.ProvinciaRepositorio.Delete(id);
            _unidadDeTrabajo.Commit();
        }

        public ProvinciaDto Get(long id)
        {
            var entidad = _unidadDeTrabajo.ProvinciaRepositorio.Get(id);

            if (entidad == null) throw new Exception("Ocurrio un error al obtener la entidad");

            return new ProvinciaDto
            {
                Id = entidad.Id,
                Descripcion = entidad.Descripcion,
                Eliminado = entidad.EstaEliminado
            };
        }

        public IEnumerable<ProvinciaDto> Get(string cadenaBuscar)
        {
            return _unidadDeTrabajo.ProvinciaRepositorio
                .Get(x=>x.Descripcion.Contains(cadenaBuscar))
                .Select(x=> new ProvinciaDto 
                { 
                    Id= x.Id,
                    Descripcion = x.Descripcion,
                    Eliminado = x.EstaEliminado
                }).ToList();
        }

        public void Insert(ProvinciaDto dto)
        {
            var entidad = new Dominio.Entidades.Provincia
            {
                Descripcion = dto.Descripcion,
                EstaEliminado = false
            };

            _unidadDeTrabajo.ProvinciaRepositorio.Insert(entidad); 

            _unidadDeTrabajo.Commit();
        }

        public void Update(ProvinciaDto dto)
        {
            var entidad = new Dominio.Entidades.Provincia
            {
                Id = dto.Id,
                Descripcion = dto.Descripcion
            }; 

            _unidadDeTrabajo.ProvinciaRepositorio.Update(entidad);
            _unidadDeTrabajo.Commit();
        }
    }
}
