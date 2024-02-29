using Dominio.MetaData;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Provincia")]
    [MetadataType(typeof(IProvincia))]
    public class Provincia : EntidadBase
    {
        //propiedades
        public string Descripcion { get; set; }


        //propiedades de navegacion 
        public virtual ICollection<Localidad> Localidades { get; set; }

    }
}
