using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.MetaData
{
    public interface IProvincia
    {
        [Display(Name =@"Descripción")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser menor a {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Index("Index_Descripcion_Provincia", IsUnique = true)] //
        string Descripcion { get; set; }
    }
}
