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
    public partial class Wait_Form : Form
    {
        public Wait_Form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            //cai dat panel.Topmost = true moi chay
        }

        //
        public Wait_Form(Form parent)
        {
            InitializeComponent();
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X + parent.Width / 2 - this.Width / 2,
                    parent.Location.Y + (parent.Height / 2)+72 - (this.Height / 2)+72);
            }
            else
                this.StartPosition = FormStartPosition.CenterParent;
        }

        public void CloseWaitForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (label1.Image != null)
            {
                label1.Image.Dispose();
            }
        }
    }
}
