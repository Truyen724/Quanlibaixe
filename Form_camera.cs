using Quanlibaixe.Custom_Toolbox;
using Quanlibaixe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Quanlibaixe
{
    public partial class Form_camera : Form
    {
        public Form_camera()
        {
            InitializeComponent();

            //Mặc định ButtonCT2 xuất hiện đầu tiên.
            SidePanel.Height = buttonCT2.Height;
            SidePanel.Top = buttonCT2.Top;
            //CustomControll.BringToFront();

        //------------------------------------------------------>
            //Custom hover buttonCT2
            buttonCT2.MouseEnter += OnMouseEnterButtonCT2;
            buttonCT2.MouseLeave += OnMouseLeaveButtonCT2;

            //Custom hover buttonCT3
            buttonCT3.MouseEnter += OnMouseEnterButtonCT3;
            buttonCT3.MouseLeave += OnMouseLeaveButtonCT3;

            //Custom hover buttonCT4
            buttonCT4.MouseEnter += OnMouseEnterButtonCT4;
            buttonCT4.MouseLeave += OnMouseLeaveButtonCT4;

            //Custom hover buttonCT5
            buttonCT5.MouseEnter += OnMouseEnterButtonCT5;
            buttonCT5.MouseLeave += OnMouseLeaveButtonCT5;

            //Custom hover buttonCT6
            //buttonCT6.MouseEnter += OnMouseEnterButtonCT6;
            //buttonCT6.MouseLeave += OnMouseLeaveButtonCT6;
            //------------------------------------------------------>

        }

        //----------------------------------------------------------------------------------------------------------------->
        //Custom hovwe buttonCT2
        private void OnMouseEnterButtonCT2(object sender, EventArgs e)
        {
            //buttonCT2.BackColor = SystemColors.ButtonHighlight; // Màu đỏ hoặc bất cứ thứ gì bạn muốn
            //buttonCT2.FlatAppearance.MouseOverBackColor = Color.Red;
            //buttonCT2.BackColor = Color.FromArgb(40, 86, 182);
            buttonCT2.ForeColor = Color.FromArgb(40, 86, 182);
            buttonCT2.FlatStyle = FlatStyle.Flat;


            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel.Height = buttonCT2.Height;
            SidePanel.Top = buttonCT2.Top;

        }
        private void OnMouseLeaveButtonCT2(object sender, EventArgs e)
        {
            buttonCT2.BackColor = SystemColors.ButtonFace;
            buttonCT2.ForeColor = Color.Gray;
            buttonCT2.BackColor = Color.FromArgb(235, 239, 241);

        }

        //Custom hovwe buttonCT3
        private void OnMouseEnterButtonCT3(object sender, EventArgs e)
        {
            //buttonCT3.BackColor = Color.FromArgb(40, 86, 182);
            buttonCT3.ForeColor = Color.FromArgb(40, 86, 182);
            buttonCT3.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel.Height = buttonCT3.Height;
            SidePanel.Top = buttonCT3.Top;

        }
        private void OnMouseLeaveButtonCT3(object sender, EventArgs e)
        {
            buttonCT3.BackColor = SystemColors.ButtonFace;
            buttonCT3.ForeColor = Color.Gray;
            buttonCT3.BackColor = Color.FromArgb(235, 239, 241);

        }
        //Custom hovwe buttonCT4
        private void OnMouseEnterButtonCT4(object sender, EventArgs e)
        {
            //buttonCT4.BackColor = Color.FromArgb(40, 86, 182);
            buttonCT4.ForeColor = Color.FromArgb(40, 86, 182);
            buttonCT4.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel.Height = buttonCT4.Height;
            SidePanel.Top = buttonCT4.Top;

        }
        private void OnMouseLeaveButtonCT4(object sender, EventArgs e)
        {
            buttonCT4.BackColor = SystemColors.ButtonFace;
            buttonCT4.ForeColor = Color.Gray;
            buttonCT4.BackColor = Color.FromArgb(235, 239, 241);
        }

        //Custom hovwe buttonCT5
        private void OnMouseEnterButtonCT5(object sender, EventArgs e)
        {
            //buttonCT5.BackColor = Color.FromArgb(40, 86, 182);
            buttonCT5.ForeColor = Color.FromArgb(40, 86, 182);
            buttonCT5.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel.Height = buttonCT5.Height;
            SidePanel.Top = buttonCT5.Top;

        }
        private void OnMouseLeaveButtonCT5(object sender, EventArgs e)
        {
            buttonCT5.BackColor = SystemColors.ButtonFace;
            buttonCT5.ForeColor = Color.Gray;
            buttonCT5.BackColor = Color.FromArgb(235, 239, 241);


        }

        //Custom hovwe buttonCT6
        //private void OnMouseEnterButtonCT6(object sender, EventArgs e)
        //{
        //    //buttonCT6.BackColor = Color.FromArgb(40, 86, 182);
        //    buttonCT6.ForeColor = Color.FromArgb(40, 86, 182);
        //    buttonCT6.FlatStyle = FlatStyle.Flat;

        //    //Tạo hiệu ứng di chuyển thanh sidePanel
        //    SidePanel.Height = buttonCT6.Height;
        //    SidePanel.Top = buttonCT6.Top;

        //}
        //private void OnMouseLeaveButtonCT6(object sender, EventArgs e)
        //{
        //    buttonCT6.BackColor = SystemColors.ButtonFace;
        //    buttonCT6.ForeColor = Color.Gray;
        //    buttonCT6.BackColor = Color.FromArgb(235, 239, 241);
        //}
        //----------------------------------------------------------------------------------------------------------------->

        public static string conect_string = "server = DESKTOP-O41267U; database = Detect_bienso; integrated security = true";
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

        private void Form_camera_Load(object sender, EventArgs e)
        {
            
        }

    //----------------------------------------------------------------------------------------------------------------->
        private void buttonCT2_Click(object sender, EventArgs e)
        {
            if(e != null)
            {
                SidePanel.Height = buttonCT2.Height;
                SidePanel.Top = buttonCT2.Top;
                
            }
            else 
            {
                return;
            }
            //CustomControll.BringToFront();
        }

        private void buttonCT3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonCT3.Height;
            SidePanel.Top = buttonCT3.Top;
            //CustomControll.BringToFront();
        }

        private void buttonCT4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonCT4.Height;
            SidePanel.Top = buttonCT4.Top;
            //CustomControll.BringToFront();
        }

        private void buttonCT5_Click(object sender, EventArgs e)
        {
            //SidePanel.Height = buttonCT5.Height;
            //SidePanel.Top = buttonCT5.Top;

            if (e != null)
            {
                SidePanel.Height = buttonCT5.Height;
                SidePanel.Top = buttonCT5.Top;
            }
            else
            {
                SidePanel.Height = 0;
            }
            //CustomControll.BringToFront();
        }

        //private void buttonCT6_Click(object sender, EventArgs e)
        //{
        //    SidePanel.Height = buttonCT6.Height;
        //    SidePanel.Top = buttonCT6.Top;
        //    //CustomControll.BringToFront();
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
         
        private void buttonCT1_Click(object sender, EventArgs e)
        {
            if(SideBar.Width==285)
            {
                SideBar.Width = 90;
            }
            else
            {
                SideBar.Width = 285;
            }
        }

        private void buttonCT2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------------------------->
    }
}
