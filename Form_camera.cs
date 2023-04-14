using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace Quanlibaixe
{
    public partial class Form_camera : Form
    {
        private Thread thread2 = null;
        public Form_camera()
        {
            InitializeComponent();
        }
        String id_access = infor.id_access.Trim();
        String ConectionString = infor.ConectionString;
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

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WorkingDirectory = Application.StartupPath + @"\Detect_BienSo";
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C conda activate base && python main.py";
            process.StartInfo = startInfo;
            process.Start();
            MessageBox.Show("Đang khởi động");
            button7.Enabled = false;
        }

        private void quảnLíLịchTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLíLịchTrìnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_lichxe x = new Form_lichxe();
            x.Show();
        }

        private void thêmLịchTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlilichtrinh f = new quanlilichtrinh();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_camera_Load(object sender, EventArgs e)
        {
            
            if(id_access=="2")
            {
                menuStrip1.Visible = false;
                MessageBox.Show(id_access);
            }    
            thread2 = new Thread(new ThreadStart(run_check));
            thread2.Start();
        }
        public string rund()
        {
            string text = File.ReadAllText("Detect_BienSo/data.txt");
            return text;
        }
        public string check()
        {
            string text = File.ReadAllText("data_save.txt");
            return text;
        }
        public void write(string a)
        {
            File.WriteAllText("data_save.txt", a);
        }
        public void run_check()
        {
            while(true)
            {
                String[] t1 = rund().Split('|');
                string t_check = check();
                if(t_check!= t1[0])
                {
                    Form_Action f = new Form_Action(id_xe: t1[1], id_action: t1[0]);
                    f.ShowDialog();
                }
                
                write(t1[0]);
            }
        }
    }
}
