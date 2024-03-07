using IServicios.Provincia;
using PresentacionBase.Formularios;
using System.Windows.Forms;

namespace Presentacion.Core.Provincia
{
    public partial class FormProvincia : FormConsulta
    {
        private readonly IProvinciaServicio _provinciaServicio;

        public FormProvincia(IProvinciaServicio provinciaServicio)
        {
            InitializeComponent();
            _provinciaServicio = provinciaServicio;
        }

        public override void ActualizarDatos(DataGridView dgv, string cadenaBuscar)
        {
            
        }
    }
}
