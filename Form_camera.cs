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
        private bool buttonCT2Checked = false;
        private bool buttonCT3Checked = false;
        private bool buttonCT4Checked = false;
        private bool buttonCT5Checked = false;
        private bool buttonCT6Checked = false;

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
            buttonCT6.MouseEnter += OnMouseEnterButtonCT6;
            buttonCT6.MouseLeave += OnMouseLeaveButtonCT6;
            //------------------------------------------------------>

        }

        //----------------------------------------------------------------------------------------------------------------->


        //Custom hovwe buttonCT2
        private void OnMouseEnterButtonCT2(object sender, EventArgs e)
        {
            buttonCT2.ForeColor = Color.FromArgb(40, 86, 182);
            buttonCT2.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel2.Visible = true;
            SidePanel2.Height = buttonCT2.Height;
            SidePanel2.Top = buttonCT2.Top;

        }
        private void OnMouseLeaveButtonCT2(object sender, EventArgs e)
        {
            //buttonCT2.BackColor = SystemColors.ButtonFace;
            buttonCT2.ForeColor = Color.Gray;
            SidePanel2.Visible = false;
        }

        //Custom hovwe buttonCT3
        private void OnMouseEnterButtonCT3(object sender, EventArgs e)
        {
            //buttonCT3.BackColor = Color.FromArgb(40, 86, 182);
            buttonCT3.ForeColor = Color.FromArgb(40, 86, 182);
            buttonCT3.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel2.Visible = true;
            SidePanel2.Height = buttonCT3.Height;
            SidePanel2.Top = buttonCT3.Top;

        }
        private void OnMouseLeaveButtonCT3(object sender, EventArgs e)
        {
            //buttonCT3.BackColor = SystemColors.ButtonFace;
            buttonCT3.ForeColor = Color.Gray;
            SidePanel2.Visible = false;
        }
        //Custom hovwe buttonCT4
        private void OnMouseEnterButtonCT4(object sender, EventArgs e)
        {
            //buttonCT4.BackColor = Color.FromArgb(40, 86, 182);
            buttonCT4.ForeColor = Color.FromArgb(40, 86, 182);
            buttonCT4.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel2.Visible = true;

            SidePanel2.Height = buttonCT4.Height;
            SidePanel2.Top = buttonCT4.Top;

        }
        private void OnMouseLeaveButtonCT4(object sender, EventArgs e)
        {
            buttonCT4.ForeColor = Color.Gray;
            SidePanel2.Visible = false;
        }

        //Custom hovwe buttonCT5
        private void OnMouseEnterButtonCT5(object sender, EventArgs e)
        {
            //buttonCT5.BackColor = Color.FromArgb(40, 86, 182);
            buttonCT5.ForeColor = Color.FromArgb(40, 86, 182);
            buttonCT5.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel2.Visible = true;
            SidePanel2.Height = buttonCT5.Height;
            SidePanel2.Top = buttonCT5.Top;

        }
        private void OnMouseLeaveButtonCT5(object sender, EventArgs e)
        {
            buttonCT5.ForeColor = Color.Gray;
            SidePanel2.Visible = false;
        }

        private void OnMouseEnterButtonCT6(object sender, EventArgs e)
        {
            buttonCT6.ForeColor = Color.FromArgb(40, 86, 182);
            buttonCT6.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel2.Visible = true;
            SidePanel2.Height = buttonCT6.Height;
            SidePanel2.Top = buttonCT6.Top;

        }
        private void OnMouseLeaveButtonCT6(object sender, EventArgs e)
        {
            //buttonCT2.BackColor = SystemColors.ButtonFace;
            buttonCT2.ForeColor = Color.Gray;
            SidePanel2.Visible = false;
        }
        //Custom hovwe buttonCT6
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
            Form_lichxe x = new Form_lichxe();
            x.Show();
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
            buttonCT6.BackColor = Color.FromArgb(208, 212, 213);
            SidePanel.Location = new Point(6, 146);
        }

        //----------------------------------------------------------------------------------------------------------------->
        private void buttonCT6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonCT6.Height;
            SidePanel.Top = buttonCT6.Top;

            buttonCT6Checked = true;
            if (buttonCT6Checked)
            {
                buttonCT6.BackColor = Color.FromArgb(208, 212, 213);
                buttonCT2.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT3.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT4.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT5.BackColor = Color.FromArgb(235, 239, 241);
            }
            else
            {
                return;
            }

            //visible user control
            tableLayoutPanel1.Visible = true;
            form_xe_tableLayoutPanel2.Visible = false;
            form_quanli_tableLayoutPanel2.Visible = false;
            Form_Lich_tableLayoutPanel2.Visible = false;

            button7.Visible = true;
        }
        private void buttonCT2_Click(object sender, EventArgs e)
        {

            SidePanel.Height = buttonCT2.Height;
            SidePanel.Top = buttonCT2.Top;

            buttonCT2Checked = true;
            if (buttonCT2Checked)
            {
                buttonCT2.BackColor = Color.FromArgb(208, 212, 213);
                buttonCT3.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT4.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT5.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT6.BackColor = Color.FromArgb(235, 239, 241);
            }
            else
            {
                return;
            }

            tableLayoutPanel1.Visible = false;
            form_xe_tableLayoutPanel2.Visible = false;
            form_quanli_tableLayoutPanel2.Visible = true;
            Form_Lich_tableLayoutPanel2.Visible = false;

            button7.Visible = false;
            quanLi_Control11.BringToFront();
        }

        private void buttonCT3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonCT3.Height;
            SidePanel.Top = buttonCT3.Top;

            buttonCT3Checked = true;
            if (buttonCT3Checked)
            {
                buttonCT3.BackColor = Color.FromArgb(208, 212, 213);
                buttonCT2.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT4.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT5.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT6.BackColor = Color.FromArgb(235, 239, 241);
            }
            else
            {
                return;
            }

            tableLayoutPanel1.Visible = false;
            form_xe_tableLayoutPanel2.Visible = true;
            form_quanli_tableLayoutPanel2.Visible = false;
            Form_Lich_tableLayoutPanel2.Visible = false;

            //visible user control
            xe_Control1.BringToFront();
            xe_Control1.Visible = true;
            button7.Visible = false;

        }

        private void buttonCT4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonCT4.Height;
            SidePanel.Top = buttonCT4.Top;

            buttonCT4Checked = true;
            if (buttonCT4Checked)
            {
                buttonCT4.BackColor = Color.FromArgb(208, 212, 213);
                buttonCT2.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT3.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT5.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT6.BackColor = Color.FromArgb(235, 239, 241);
            }
            else
            {
                return;
            }
            tableLayoutPanel1.Visible = false;
            form_xe_tableLayoutPanel2.Visible = false;
            form_quanli_tableLayoutPanel2.Visible = false;
            Form_Lich_tableLayoutPanel2.Visible = false;
            button7.Visible = false;
            //CustomControll.BringToFront();
        }

        private void buttonCT5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonCT5.Height;
            SidePanel.Top = buttonCT5.Top;

            buttonCT5Checked = true;
            if (buttonCT5Checked)
            {
                buttonCT5.BackColor = Color.FromArgb(208, 212, 213);
                buttonCT2.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT3.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT4.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT6.BackColor = Color.FromArgb(235, 239, 241);
            }
            else
            {
                return;
            }
            tableLayoutPanel1.Visible = false;
            form_xe_tableLayoutPanel2.Visible = false;
            form_quanli_tableLayoutPanel2.Visible = false;
            Form_Lich_tableLayoutPanel2.Visible = true;

            button7.Visible = false;
            lich_Control1.BringToFront();
        }



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

        //----------------------------------------------------------------------------------------------------------------->
    }
}
