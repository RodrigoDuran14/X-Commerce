using Dominio.Entidades;
using Dominio.Repositorio;

namespace Dominio.UnidadDeTrabajo
{
    public interface IUnidadDeTrabajo
    {
        void Commit(); //Efectuar cambios de forma fisica en el motor

        void Disposed(); //Destruye el objeto

        //Declaraciones de los repositorios
        IRepositorio<Provincia> ProvinciaRepositorio {  get; }
        IRepositorio<Localidad> LocalidadRepositorio { get; }
    }
}
