using Presentacion.Core.Provincia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommerceApp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fprov = new FormProvincia();

            fprov.ShowDialog();
        }
    }
}
