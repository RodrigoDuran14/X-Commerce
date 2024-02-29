using Dominio.Entidades;
using Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace Infraestructura.Repositorio
{
    public class Repositorio<TEntidad> : IRepositorio<TEntidad> where TEntidad : EntidadBase
    {
        private DataContext _context;

        public Repositorio(DataContext context)
        {
            _context = context;
        }

        //Metodos de persistencia
        public long Insert(TEntidad entidad)
        {
            if (entidad == null) throw new Exception("La entidad no puede ser null");

            _context.Set<TEntidad>().Add(entidad);

            return entidad.Id;
        }

        public void Update(TEntidad entidad)
        {
            if (entidad == null) throw new Exception("La entidad a modificar no puede ser null");

            _context.Set<TEntidad>().Attach(entidad);
            _context.Entry(entidad).State = EntityState.Modified;
        }

        public void Delete(long entidadId)
        {
            var entidadEliminar = _context.Set<TEntidad>().FirstOrDefault(x => x.Id == entidadId);

            if (entidadEliminar == null) throw new Exception("Ocurrio un error al obtener la entidad");

            entidadEliminar.EstaEliminado = !entidadEliminar.EstaEliminado;
        }


        //Metodos de consultas
        public TEntidad Get(long id, string propiedadesNavegacion = "")
        {
            var resultado = propiedadesNavegacion.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).Aggregate<string, IQueryable<TEntidad>>(_context.Set<TEntidad>(), (current, include) => current.Include(include));

            return resultado.FirstOrDefault(x=>x.Id==id);
        }

        public IEnumerable<TEntidad> Get(Expression<Func<TEntidad, bool>> predicado = null, string propiedadesNavegacion = "")
        {
            var context = ((IObjectContextAdapter)_context).ObjectContext;

            var resultadoCliente = context.CreateObjectSet<TEntidad>();

            var resultado = propiedadesNavegacion.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Aggregate<string, IQueryable<TEntidad>>(resultadoCliente, (current, include) => current.Include(include));

            if(predicado != null)
            {
                resultado = resultado.Where(predicado);
            }

            return resultado.ToList();
        }
    }
}
