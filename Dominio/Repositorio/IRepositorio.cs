using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Dominio.Repositorio
{
    //TEntidad es cualquier entidad que herede de entidadBase
    public interface IRepositorio<TEntidad> where TEntidad : EntidadBase
    {
        //persistencia de datos
        long Insert(TEntidad entidad);

        void Delete(long entidadId);

        void Update(TEntidad entidad);

        //Lectura de datos
        TEntidad Get(long id, string propiedadesNavegacion  = "");
        IEnumerable<TEntidad> Get(Expression<Func<TEntidad, bool>> predicado, string propiedadesNavegacion = "");
    }
}
