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
    public partial class Form_Master : Form
    {
        public Form_Master()
        {
            InitializeComponent();
        }

        private void buttonCT1_Click(object sender, EventArgs e)
        {
            if (SideBar.Width == 285)
            {
                SideBar.Width = 90;
            }
            else
            {
                SideBar.Width = 285;
            }
        }
    }
}
