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
        private bool buttonCT2Checked = false;
        private bool buttonCT3Checked = false;
        private bool buttonCT4Checked = false;
        private bool buttonCT5Checked = false;
        private bool buttonCT6Checked = false;

        public Form_Master()
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

        //Custom hover buttonCT5
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

        //Custom hover buttonCT6
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
        //----------------------------------------------------------------------------------------------------------------->

        // button dashboard 
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

        // Sự kiện Load khởi động  khởi màn hình thực thi hành động
        private void Form_Master_Load(object sender, EventArgs e)
        {
            buttonCT2.BackColor = Color.FromArgb(208, 212, 213);
            SidePanel.Location = new Point(6, 146);
        }

        // button camera
        private void buttonCT2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonCT2.Height;
            SidePanel.Top = buttonCT2.Top;

            buttonCT2Checked = true;
            if (buttonCT2Checked)
            {
                buttonCT2.BackColor = Color.FromArgb(208, 212, 213);
                buttonCT6.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT3.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT4.BackColor = Color.FromArgb(235, 239, 241);
                buttonCT5.BackColor = Color.FromArgb(235, 239, 241);
            }
            else
            {
                return;
            }
        }

        // button quan li du liêu
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
            button1.Visible = false;
        }

        // button xe oto
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
            button1.Visible = false;
        }

        // button tai xê
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
            button1.Visible = false;
        }

        // button lich xe
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
            button1.Visible = false;
        }

        // LICENSE PLATE DETECTION 
        private void button1_Click(object sender, EventArgs e)
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
            button1.Enabled = false;
        }
    }
}
