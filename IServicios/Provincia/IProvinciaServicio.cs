using IServicios.Provincia.DTOs;
using System.Collections.Generic;

namespace IServicios.Provincia
{
    public interface IProvinciaServicio
    {
        void Insert(ProvinciaDto dto);
        void Delete(long id);
        void Update(ProvinciaDto dto);
        IEnumerable<ProvinciaDto> Get(string cadenaBuscar);
        ProvinciaDto Get(long id);
    }
}
