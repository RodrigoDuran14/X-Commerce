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
            base.ActualizarDatos(dgv, cadenaBuscar);


            dgv.DataSource = _provinciaServicio.Get(cadenaBuscar);
        }

        public override void FormatearGrilla(DataGridView dgv)
        {
            base.FormatearGrilla(dgv);

            dgv.Columns["Descripcion"].Visible = true;
            dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Descripcion"].HeaderText = @"Descripción";
            dgv.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
    }
}
