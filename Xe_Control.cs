using Quanlibaixe.Custom_Toolbox;
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

            //Custom hover buttonCT1
            buttonCT1.MouseEnter += OnMouseEnterButtonCT1;
            buttonCT1.MouseLeave += OnMouseLeaveButtonCT1;

            //Custom hover buttonCT2
            buttonCT2.MouseEnter += OnMouseEnterButtonCT2;
            buttonCT2.MouseLeave += OnMouseLeaveButtonCT2;

            //Custom hover buttonCT3
            buttonCT3.MouseEnter += OnMouseEnterButtonCT3;
            buttonCT3.MouseLeave += OnMouseLeaveButtonCT3;
        }

        //Custom hover buttonCT1
        private void OnMouseEnterButtonCT1(object sender, EventArgs e)
        {
            buttonCT1.ForeColor = Color.White;
        }
        private void OnMouseLeaveButtonCT1(object sender, EventArgs e)
        {

        }

        //Custom hover buttonCT2
        private void OnMouseEnterButtonCT2(object sender, EventArgs e)
        {
            buttonCT1.ForeColor = Color.White;
        }
        private void OnMouseLeaveButtonCT2(object sender, EventArgs e)
        {

        }

        //Custom hover buttonCT3
        private void OnMouseEnterButtonCT3(object sender, EventArgs e)
        {
            buttonCT1.ForeColor = Color.White;
        }
        private void OnMouseLeaveButtonCT3(object sender, EventArgs e)
        {

        }
        private void buttonCT1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCT2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCT3_Click(object sender, EventArgs e)
        {

        }
    }
}
