using Dominio.MetaData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Provincia")]
    [MetadataType(typeof(IProvincia))]
    public class Provincia : EntidadBase
    {
        public string Descripcion { get; set; }

    }
}
