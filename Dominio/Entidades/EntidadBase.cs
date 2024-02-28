using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class EntidadBase
    {
        [Key] //AutoIncremental Tabla
        public long Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = @"Esta Eliminado")] // cambia el nombre del campo
        [DefaultValue(false)]
        public bool EstaEliminado { get; set; } //Borrado Logico

    }
}
