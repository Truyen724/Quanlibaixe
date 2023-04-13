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
    public partial class Xe_Control : UserControl
    {
        private bool buttonCT1Checked = false;
        private bool buttonCT2Checked = false;

        public Xe_Control()
        {
            InitializeComponent();
        }

        private void buttonCT1_Click(object sender, EventArgs e)
        {
            buttonCT1.BackgroundColor = Color.FromArgb(40, 86, 182);
            buttonCT1Checked = true;
            if (buttonCT2Checked)
            {
                buttonCT1.BackgroundColor = Color.Gray;
            }
        }

        private void buttonCT2_Click(object sender, EventArgs e)
        {
            buttonCT2.BackgroundColor = Color.FromArgb(40, 86, 182);
            buttonCT2Checked = true;
            if(buttonCT1Checked)
            {
                buttonCT2.BackgroundColor = Color.Gray;
            }
        }
    }
}
