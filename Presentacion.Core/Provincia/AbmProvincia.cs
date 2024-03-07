using PresentacionBase.Formularios;

namespace Presentacion.Core.Provincia
{
    public partial class AbmProvincia : FormAbm
    {
        public AbmProvincia(TipoOperacion tipoOperacion, long? entidadId = null)
            : base( tipoOperacion, entidadId)
        {
            InitializeComponent();
        }
    }
}
