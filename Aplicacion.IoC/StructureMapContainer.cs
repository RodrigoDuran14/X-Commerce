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
                x.Scan(scan =>
                { 
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.ConnectImplementationsToTypesClosing(typeof(IRepositorio<>));
                    scan.Assembly(GetType().Assembly);
                });

                x.For(typeof(IRepositorio<>)).Use(typeof(Repositorio<>));
                x.ForSingletonOf<DbContext>().HybridHttpOrThreadLocalScoped();
                x.For<IUnidadDeTrabajo>().Use<UnidadDeTrabajo>();

                //============================================================================//

                x.For<IProvinciaServicio>().Use<ProvinciaServicio>();
            });
        }
    }
}
