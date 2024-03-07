using System;
using System.Windows.Forms;

namespace PresentacionBase.Formularios
{
    public partial class FormConsulta : Form
    {
        private long? entidadId;
        protected object EntidadSeleccionada;

        public FormConsulta()
        {
            InitializeComponent();

            entidadId = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            ActualizarDatos(dgvGrilla, string.Empty);
        }

        public virtual void ActualizarDatos( DataGridView dgv, string cadenaBuscar)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(dgvGrilla, txtBuscar.Text);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnActualizar.PerformClick();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(dgvGrilla, string.Empty);
        }
        public virtual bool EjecutarComando(TipoOperacion tipoOperacion, long? id = null)
        {
            return false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (EjecutarComando(TipoOperacion.Nuevo))
            {
                ActualizarDatos(dgvGrilla, string.Empty);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                if (entidadId.HasValue)
                {
                    if(EjecutarComando(TipoOperacion.Modificar, entidadId))
                    {
                        ActualizarDatos(dgvGrilla, string.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
            else
            {
                MessageBox.Show("No hay registros cargados"); 
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.RowCount > 0)
            {
                if (entidadId.HasValue)
                {
                    if (EjecutarComando(TipoOperacion.Eliminar, entidadId))
                    {
                        ActualizarDatos(dgvGrilla, string.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
            else
            {
                MessageBox.Show("No hay registros cargados");
            }
        }

        public virtual void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrilla.RowCount <= 0) return;

            entidadId = (long)dgvGrilla["Id", e.RowIndex].Value;

            //Obtener el objeto completo seleccionado
            EntidadSeleccionada = dgvGrilla.Rows[e.RowIndex].DataBoundItem;
        }
    }
}
