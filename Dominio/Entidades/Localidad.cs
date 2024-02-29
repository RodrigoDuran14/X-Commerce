using Dominio.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Localidad")]
    [MetadataType(typeof(ILocalidad))]
    public class Localidad : EntidadBase
    {
        //propiedades

        public long ProvinciaId { get; set; }
        public string Descripcion { get; set; }

        //Propiedades de navegacion -> es para hacer la relacion

        public virtual Provincia Provincia { get; set; }
    }
}
