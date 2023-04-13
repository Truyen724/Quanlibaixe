using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlibaixe;
namespace Quanlibaixe
{
    public partial class Form_Action : Form
    {
        public string id_xe;
        public Form_Action()
        {
            InitializeComponent();
        }
        public Form_Action(string id_xe)
        {
            InitializeComponent();
            this.id_xe = id_xe;
        }
        String ConectionString = infor.ConectionString;
        private void Form_Action_Load(object sender, EventArgs e)
        {
            MessageBox.Show(ConectionString);
            String tatcacacxe = String.Format("select id_schedule, ngay, time , id_car,description, id_action from schedule where id_car='{0}' order by id_schedule DESC ", id_xe);
        }
    }
}
