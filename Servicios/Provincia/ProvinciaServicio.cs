using IServicios.Provincia;
using IServicios.Provincia.DTOs;
using System.Collections.Generic;

namespace Servicios.Provincia
{
    //implementacion de IProvinciaServicio
    public class ProvinciaServicio : IProvinciaServicio
    {
        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public ProvinciaDto GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ProvinciaDto> GetByName(string cadenaBuscar)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(ProvinciaDto dto)
        {
            throw new System.NotImplementedException();
        }

        public void Update(ProvinciaDto dto)
        {
            throw new System.NotImplementedException();
        }
    }
}
