﻿using Quanlibaixe.Custom_Toolbox;
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
    public partial class Form_Master : Form
    {
        //
        private bool Camera_buttonCTChecked = false;
        private bool QuanLi_buttonCTChecked = false;
        private bool XeOto_buttonCTChecked = false;
        private bool TaiXe_buttonCTChecked = false;
        private bool LichXe_buttonCTChecked = false;

        //
        private Thread thread2 = null;
        String id_access = infor.id_access.Trim();
        String ConectionString = infor.ConectionString;

        public Form_Master()
        {
            InitializeComponent();

            //Mặc định ButtonCT2 xuất hiện đầu tiên.
            SidePanel.Height = QuanLi_buttonCT.Height;
            SidePanel.Top = QuanLi_buttonCT.Top;

            //------------------------------------------------------>
            //Custom hover buttonCT1
            Camera_buttonCT.MouseEnter += OnMouseEnterButtonCT1;
            Camera_buttonCT.MouseLeave += OnMouseLeaveButtonCT1;

            //Custom hover buttonCT2
            QuanLi_buttonCT.MouseEnter += OnMouseEnterButtonCT2;
            QuanLi_buttonCT.MouseLeave += OnMouseLeaveButtonCT2;

            //Custom hover buttonCT3
            XeOto_buttonCT.MouseEnter += OnMouseEnterButtonCT3;
            XeOto_buttonCT.MouseLeave += OnMouseLeaveButtonCT3;

            //Custom hover buttonCT4
            TaiXe_buttonCT.MouseEnter += OnMouseEnterButtonCT4;
            TaiXe_buttonCT.MouseLeave += OnMouseLeaveButtonCT4;

            //Custom hover buttonCT5
            LichXe_buttonCT.MouseEnter += OnMouseEnterButtonCT5;
            LichXe_buttonCT.MouseLeave += OnMouseLeaveButtonCT5;           
            //------------------------------------------------------>
        }

        private void Form_Master_Load(object sender, EventArgs e)
        {
            Camera_buttonCT.BackColor = Color.FromArgb(208, 212, 213);
            SidePanel.Location = new Point(6, 146);


            //
            thread2 = new Thread(new ThreadStart(run_check));
            thread2.Start();

            // Tắt menuStrip1 nếu user đăng nhập
            if (id_access == "2")
            {
                menuStrip1.Visible = false;
            }
            else
            {
                return;
            }
        }

        //
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

        //----------------------------------------------------------------------------------------------------------------->
        //Custom hover Camera_buttonCT
        private void OnMouseEnterButtonCT1(object sender, EventArgs e)
        {
            Camera_buttonCT.ForeColor = Color.FromArgb(40, 86, 182);
            Camera_buttonCT.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel2.Visible = true;
            SidePanel2.Height = Camera_buttonCT.Height;
            SidePanel2.Top = Camera_buttonCT.Top;

        }
        private void OnMouseLeaveButtonCT1(object sender, EventArgs e)
        {
            //buttonCT2.BackColor = SystemColors.ButtonFace;
            Camera_buttonCT.ForeColor = Color.Gray;
            SidePanel2.Visible = false;
        }

        //Custom hover QuanLi_buttonCT
        private void OnMouseEnterButtonCT2(object sender, EventArgs e)
        {
            QuanLi_buttonCT.ForeColor = Color.FromArgb(40, 86, 182);
            QuanLi_buttonCT.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel2.Visible = true;
            SidePanel2.Height = QuanLi_buttonCT.Height;
            SidePanel2.Top = QuanLi_buttonCT.Top;

        }
        private void OnMouseLeaveButtonCT2(object sender, EventArgs e)
        {
            //buttonCT2.BackColor = SystemColors.ButtonFace;
            QuanLi_buttonCT.ForeColor = Color.Gray;
            SidePanel2.Visible = false;
        }

        //Custom hover XeOto_buttonCT
        private void OnMouseEnterButtonCT3(object sender, EventArgs e)
        {
            //buttonCT3.BackColor = Color.FromArgb(40, 86, 182);
            XeOto_buttonCT.ForeColor = Color.FromArgb(40, 86, 182);
            XeOto_buttonCT.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel2.Visible = true;
            SidePanel2.Height = XeOto_buttonCT.Height;
            SidePanel2.Top = XeOto_buttonCT.Top;

        }
        private void OnMouseLeaveButtonCT3(object sender, EventArgs e)
        {
            XeOto_buttonCT.ForeColor = Color.Gray;
            SidePanel2.Visible = false;
        }
        //Custom hover TaiXe_buttonCT
        private void OnMouseEnterButtonCT4(object sender, EventArgs e)
        {         
            TaiXe_buttonCT.ForeColor = Color.FromArgb(40, 86, 182);
            TaiXe_buttonCT.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel2.Visible = true;

            SidePanel2.Height = TaiXe_buttonCT.Height;
            SidePanel2.Top = TaiXe_buttonCT.Top;

        }
        private void OnMouseLeaveButtonCT4(object sender, EventArgs e)
        {
            TaiXe_buttonCT.ForeColor = Color.Gray;
            SidePanel2.Visible = false;
        }

        //Custom hover buttonCT5
        private void OnMouseEnterButtonCT5(object sender, EventArgs e)
        {
            LichXe_buttonCT.ForeColor = Color.FromArgb(40, 86, 182);
            LichXe_buttonCT.FlatStyle = FlatStyle.Flat;

            //Tạo hiệu ứng di chuyển thanh sidePanel
            SidePanel2.Visible = true;
            SidePanel2.Height = LichXe_buttonCT.Height;
            SidePanel2.Top = LichXe_buttonCT.Top;

        }
        private void OnMouseLeaveButtonCT5(object sender, EventArgs e)
        {
            LichXe_buttonCT.ForeColor = Color.Gray;
            SidePanel2.Visible = false;
        }            
        //----------------------------------------------------------------------------------------------------------------->
        

        // Button Dashboard
        private void Dashboard_buttonCT_Click(object sender, EventArgs e)
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

        // Button Run Camera
        private void buttonCT8_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        // Button Camera
        private void Camera_buttonCT_Click(object sender, EventArgs e)
        {
           
            // Form_camera
            //Form_camera form_Camera = new Form_camera();
            //form_Camera.StartPosition = FormStartPosition.Manual;
            //form_Camera.Location = new Point(310, 240);
            //form_Camera.ShowDialog();

            // Bật Xe_Control 
            Camera_tableLayoutPanel1.Visible = true;
            
            // Click mouse SidePanel di chuyển theo button
            SidePanel.Height = Camera_buttonCT.Height;
            SidePanel.Top = Camera_buttonCT.Top;

            // Click  mouse đổi màu
            Camera_buttonCTChecked = true;
            if (Camera_buttonCTChecked)
            {              
                QuanLi_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                XeOto_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                TaiXe_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                LichXe_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                //
                Camera_buttonCT.BackColor = Color.FromArgb(208, 212, 213);
            }
            else
            {
                return;
            }
        }

        // Button quanli
        private void QuanLi_buttonCT_Click(object sender, EventArgs e)
        {
            // Tắt Xe_Control 
            Camera_tableLayoutPanel1.Visible = false;
            // Button RunCamera
            button7.Visible = false;

            // Click mouse SidePanel di chuyển theo button
            SidePanel.Height = QuanLi_buttonCT.Height;
            SidePanel.Top = QuanLi_buttonCT.Top;

            // Click  mouse đổi màu
            QuanLi_buttonCTChecked = true;
            if (QuanLi_buttonCTChecked)
            {               
                Camera_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                XeOto_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                TaiXe_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                LichXe_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                //
                QuanLi_buttonCT.BackColor = Color.FromArgb(208, 212, 213);
            }
            else
            {
                return;
            }
        }

        // Button xeOto
        private void XeOto_buttonCT_Click(object sender, EventArgs e)
        {
            // Tắt Xe_Control 
            Camera_tableLayoutPanel1.Visible = false;
            // Button RunCamera
            button7.Visible = false;

            // Click mouse SidePanel di chuyển theo button
            SidePanel.Height = XeOto_buttonCT.Height;
            SidePanel.Top = XeOto_buttonCT.Top;

            // Click  mouse đổi màu       
            XeOto_buttonCTChecked = true;
            if (XeOto_buttonCTChecked)
            {              
                Camera_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                QuanLi_buttonCT.BackColor = Color.FromArgb(235, 239, 241);            
                TaiXe_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                LichXe_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                //
                XeOto_buttonCT.BackColor = Color.FromArgb(208, 212, 213);
            }
            else
            {
                return;
            }
        }

        // Button TaiXe
        private void TaiXe_buttonCT_Click(object sender, EventArgs e)
        {
            // Tắt Xe_Control 
            Camera_tableLayoutPanel1.Visible = false;
            // Button RunCamera
            button7.Visible = false;

            // Click mouse SidePanel di chuyển theo button
            SidePanel.Height = TaiXe_buttonCT.Height;
            SidePanel.Top = TaiXe_buttonCT.Top;

            // Click  mouse đổi màu
            TaiXe_buttonCTChecked = true;
            if (TaiXe_buttonCTChecked)
            {
                XeOto_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                Camera_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                QuanLi_buttonCT.BackColor = Color.FromArgb(235, 239, 241);                
                LichXe_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                //
                TaiXe_buttonCT.BackColor = Color.FromArgb(208, 212, 213);
            }
            else
            {
                return;
            }
        }

        // Button LichXe
        private void LichXe_buttonCT_Click(object sender, EventArgs e)
        {
            // Tắt Xe_Control 
            Camera_tableLayoutPanel1.Visible = false;
            // Button RunCamera
            button7.Visible = false;

            // Click mouse SidePanel di chuyển theo button
            SidePanel.Height = LichXe_buttonCT.Height;
            SidePanel.Top = LichXe_buttonCT.Top;

            // Click  mouse đổi màu
            LichXe_buttonCTChecked = true;
            if (LichXe_buttonCTChecked)
            {
                XeOto_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                Camera_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                QuanLi_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                TaiXe_buttonCT.BackColor = Color.FromArgb(235, 239, 241);
                //
                LichXe_buttonCT.BackColor = Color.FromArgb(208, 212, 213);
            }
            else
            {
                return;
            }
        }

        // Button RunCamera
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

        // ToolStripMenu
        private void quảnLíDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // ToolStripMenu
        private void quảnLíXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // ToolStripMenu
        private void quảnLíTàiXếToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // ToolStripMenu
        private void quảnLíLịchTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}