using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroLibro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void librosBibliaToolStripMenuItem_Click(object sender, EventArgs e)
         {
            UI.Registros.rLibros rl = new UI.Registros.rLibros();
            rl.Show();
         }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
    

