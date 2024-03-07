using System.Windows.Forms;

namespace PresentacionBase.Formularios
{
    public partial class FormAbm : Form
    {
        protected long? EntidadId;
        protected TipoOperacion TipoOperacion;
        public FormAbm(TipoOperacion tipoOperacion, long? entidadId = null)
        {
            InitializeComponent();

            TipoOperacion = tipoOperacion;
            EntidadId = entidadId;
        }
    }
}
