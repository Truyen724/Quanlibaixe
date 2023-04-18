using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlibaixe
{
    public partial class Camera_Control : UserControl
    {
        private Thread thread2 = null;       
        String ConectionString = infor.ConectionString;

        public Camera_Control()
        {
            InitializeComponent();
        }

        private void Camera_Control_Load(object sender, EventArgs e)
        {           
            thread2 = new Thread(new ThreadStart(run_check));
            thread2.Start();
        }

        // rund
        public string rund()
        {

            string text = File.ReadAllText("Detect_BienSo/data.txt");
            return text;
        }

        // check
        public string check()
        {
            string text = File.ReadAllText("data_save.txt");
            return text;
        }
        
        // write
        public void write(string a)
        {
            File.WriteAllText("data_save.txt", a);
        }

        //run_check
        public void run_check()
        {
            while (true)
            {
                try
                {
                    String[] t1 = rund().Split('|');
                    string t_check = check();
                    if (t_check != t1[0])
                    {
                        Form_Action f = new Form_Action(id_xe: t1[1], id_action: t1[0]);
                        f.ShowDialog();
                    }

                    write(t1[0]);
                }
                catch
                {

                }

            }
        }
    }
}
