using Dominio.Entidades;
using System.Data.Entity;
using static Aplicacion.CadenaConexion.CadenaConexion;

namespace Infraestructura
{
    public class DataContext : DbContext
    {
        public DataContext() 
        : base(ObtenerCadenaSql)
        { 

        }

        public DbSet<Provincia> Provincias { get; set; }
    }
}
