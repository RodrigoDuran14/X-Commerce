using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.MetaData
{
    public class ILocalidad
    {
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [Display(Name ="Provincia")]
        [Index("Index_ProvinciaId_Descripcion_Localidad", IsUnique = true, Order = 1)]
        long ProvinciaId { get; set; }

        [Display(Name =@"Descripción")]
        [MaxLength(50, ErrorMessage ="El campo {0} debe ser menor a {1} caracteres")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [Index("Index_ProvinciaId_Descripcion_Localidad", IsUnique = true, Order = 2)]
        string Descripcion { get; set; }
    }
}
