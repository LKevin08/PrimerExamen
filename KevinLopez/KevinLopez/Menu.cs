using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinLopez
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void tercerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tercForm = new TercerFormulario();
            tercForm.Show();

        }

        public void segundoFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form segForm = new SegundoFormulario();
            segForm.Show();
        }
    }
}
