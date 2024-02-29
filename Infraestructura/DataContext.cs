using Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using static Aplicacion.CadenaConexion.CadenaConexion;

namespace Infraestructura
{
    public class DataContext : DbContext
    {
        public DataContext() 
        : base(ObtenerCadenaSql)
        { 

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Evita el borrado en cascada de datos en SQL
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Evita que el ORM pluralice las tablas al crearlas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


        //Propiedades del Mapeo
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
    }
}
