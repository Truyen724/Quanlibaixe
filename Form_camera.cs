using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlibaixe
{
    public partial class Form_camera : Form
    {
        public Form_camera()
        {
            InitializeComponent();
        }

        private void quảnLíXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXe f = new FormXe();
            f.ShowDialog();
        }

        private void quảnLíTàiXếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Driver f = new Form_Driver();
            f.ShowDialog();
        }

        private void quảnLíDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Main f = new Form_Main();
            f.ShowDialog();
        }
    }
}
