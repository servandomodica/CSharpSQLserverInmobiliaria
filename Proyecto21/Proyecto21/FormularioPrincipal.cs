using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto21
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void mantenimientoDeBarriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioBarrios formularioBarrios = new FormularioBarrios();
            formularioBarrios.ShowDialog();                 
        }

        private void mantenimientoDeInmueblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioInmuebles formularioInmuebles = new FormularioInmuebles();
            formularioInmuebles.ShowDialog();
        }

        private void consultaDeInmueblesPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultaPorBarrio f = new FormularioConsultaPorBarrio();
            f.ShowDialog();
        }

        private void consultaDeInmueblesPorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioConsultaPorPrecio f = new FormularioConsultaPorPrecio();
            f.ShowDialog();
        }
    }
}
