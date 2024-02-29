using Dominio.Entidades;
using Dominio.Repositorio;
using Dominio.UnidadDeTrabajo;
using Infraestructura.Repositorio;

namespace Infraestructura.UnidadDeTrabajo
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        private readonly DataContext _context;

        public UnidadDeTrabajo(DataContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Disposed()
        {
            _context.Dispose();
        }

        //===================================================================================//

        private IRepositorio<Provincia> _provinciaRepositorio;
        public IRepositorio<Provincia> ProvinciaRepositorio => _provinciaRepositorio ?? (_provinciaRepositorio = new Repositorio<Provincia>(_context));

        //===================================================================================//

        private IRepositorio<Localidad> _localidadRepositorio;
        public IRepositorio<Localidad> LocalidadRepositorio => _localidadRepositorio ?? (_localidadRepositorio = new Repositorio<Localidad>(_context));

        //===================================================================================//


    }
}
