using Dominio.Repositorio;
using Dominio.UnidadDeTrabajo;
using Infraestructura.Repositorio;
using Infraestructura.UnidadDeTrabajo;
using IServicios.Provincia;
using Servicios.Provincia;
using StructureMap;
using System.Data.Entity;

namespace Aplicacion.IoC
{
    public class StructureMapContainer
    {
        public void Configure()
        {
            ObjectFactory.Configure(x =>
            { 
                x.For(typeof(IRepositorio<>)).Use(typeof(Repositorio<>));
                x.ForSingletonOf<DbContext>();
                x.For<IUnidadDeTrabajo>().Use<UnidadDeTrabajo>();

                //=======================================================================//

                x.For<IProvinciaServicio>().Use<ProvinciaServicio>();
            });
        }
    }
}
