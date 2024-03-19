using PresentacionBase.Formularios;

namespace Presentacion.Core.Localidad
{
    public partial class AbmLocalidad : FormAbm
    {
        public AbmLocalidad(TipoOperacion tipoOperacion, long? entidadId = null)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();
        }
    }
}
