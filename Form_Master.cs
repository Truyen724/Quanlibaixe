using Guna.UI2.WinForms;
using Quanlibaixe.Custom_Toolbox;
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
using System.Web.UI;
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
       
        String id_access = infor.id_access.Trim();

        public Form_Master()
        {
            InitializeComponent();
            //Camera_ExamSchedulerMethod();
            Xe_tableLayoutPanel2.Visible = false;

            //Mặc định Camera_buttonCT xuất hiện đầu tiên.
            SidePanel.Height = Camera_buttonCT.Height;
            SidePanel.Top = Camera_buttonCT.Top;

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
            camera_Control1.BringToFront();          

            //

            //thread2 = new Thread(new ThreadStart(run_check));
            //thread2.Start();
            // Tắt menuStrip1 nếu user đăng nhập
            if (id_access == "2")
            {
                menuStrip1.Visible = false;
                SideBar_panel.Visible = false;
                SideBar_panel.Width = 90;
                Dashboard_buttonCT.Visible = false;

            }
            else
            {
                return;
            }

            // notifyIcon1 biểu tượng trên khay hệ thống (system tray) ở góc phải dưới của màn hình.
            notifyIcon1.Text = "This is a NotifyIcon example.";
            notifyIcon1.Visible = true;
        }

        //Custom hover Camera_buttonCT
        //----------------------------------------------------------------------------------------------------------------->
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

            //
            //guna2Transition1.ShowSync(SideBar);

            if (SideBar_panel.Width == 285)
            {
                SideBar_panel.Visible = false;
                SideBar_panel.Width = 90;
                // Transiton HorizSlide cho SideBar_panel.Visible = false thi animation moi chay
                guna2Transition1.ShowSync(SideBar_panel);


            }
            else
            {
                SideBar_panel.Visible = false;
                SideBar_panel.Width = 285;
                // su dung Transiton cho SideBar_panel.Visible = false thi animation moi chay
                guna2Transition1.ShowSync(SideBar_panel);
            }

            //            
            if (SideBar_panel.Width == 90)
            {
                label3.Text = Camera_buttonCT.Text;
            }
            else
            {
                label3.Text = "Dashboard";
            }
        }

        
        // Button Camera
        private void Camera_buttonCT_Click(object sender, EventArgs e)
        {
            //
            if (SideBar_panel.Width == 285)
            {
                label3.Text = " Dashboard";
            }
            else
            {
                label3.Text = Camera_buttonCT.Text;
            }

            // Form_camera
            //Camera_ExamSchedulerMethod();

            // Bật Camera_Control 
            Camera_tableLayoutPanel1.Visible = true;
            camera_Control1.BringToFront();

            // Tắt FormXe
            Xe_tableLayoutPanel2.Visible = false;

            // Button RunCamera
            btn_RunCamera.Visible = true;

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
            //
            if (SideBar_panel.Width == 285)
            {
                label3.Text = " Dashboard";
            }
            else
            {
                label3.Text = QuanLi_buttonCT.Text;
            }

            // Tắt Control 
            Camera_tableLayoutPanel1.Visible = false;

            // Mở form_Xe
            Xe_tableLayoutPanel2.Visible = true;

            // Nếu FormXe đang hiển thị, ẩn đi trước khi hiển thị Form_QuanLi
            if (driverForm != null && driverForm.Visible) driverForm.Hide();
            // Nếu Form_Main đang hiển thị, ẩn đi trước khi hiển thị Form_QuanLi
            if (xeForm != null && xeForm.Visible) xeForm.Hide();
            // Nếu Form_LichXe đang hiển thị, ẩn đi trước khi hiển thị Form_QuanLi
            if (lichxeForm != null && lichxeForm.Visible) lichxeForm.Hide();
            Main_ExamSchedulerMethod();

            // Button RunCamera
            btn_RunCamera.Visible = false;

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
            //
            if (SideBar_panel.Width == 285)
            {
                label3.Text = " Dashboard";
            }
            else
            {
                label3.Text = XeOto_buttonCT.Text;
            }

            // Tắt Control 
            Camera_tableLayoutPanel1.Visible = false;
            // Mở form_Xe
            Xe_tableLayoutPanel2.Visible = true;

            // Nếu FormXe đang hiển thị, ẩn đi trước khi hiển thị FormXe
            if (driverForm != null && driverForm.Visible) driverForm.Hide();
            // Nếu Form_Main đang hiển thị, ẩn đi trước khi hiển thị FormXe
            if (mainForm != null && mainForm.Visible) mainForm.Hide();
            // Nếu Form_LichXe đang hiển thị, ẩn đi trước khi hiển thị FormXe
            if (lichxeForm != null && lichxeForm.Visible) lichxeForm.Hide();
            Xe_ExamSchedulerMethod();

            // Button RunCamera
            btn_RunCamera.Visible = false;

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

            //
            if (SideBar_panel.Width == 285)
            {
                label3.Text = " Dashboard";               
            }
            else
            {
                label3.Text = TaiXe_buttonCT.Text;
            }

            // Tắt Control 
            Camera_tableLayoutPanel1.Visible = false;
            // Mở form_Xe
            Xe_tableLayoutPanel2.Visible = true;

            // Nếu FormXe đang hiển thị, ẩn đi trước khi hiển thị Form_Driver
            if (xeForm != null && xeForm.Visible) xeForm.Hide();
            // Nếu Form_Main đang hiển thị, ẩn đi trước khi hiển thị Form_Driver
            if (mainForm != null && mainForm.Visible) mainForm.Hide();
            // Nếu Form_Main đang hiển thị, ẩn đi trước khi hiển thị Form_Driver
            if (lichxeForm != null && lichxeForm.Visible) lichxeForm.Hide();
            Driver_ExamSchedulerMethod();

            // Button RunCamera
            btn_RunCamera.Visible = false;

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

            //
            if (SideBar_panel.Width == 285)
            {
                label3.Text = " Dashboard";
            }
            else
            {
                label3.Text = LichXe_buttonCT.Text;
            }

            // Tắt Control 
            Camera_tableLayoutPanel1.Visible = false;

            // Mở form_Xe
            Xe_tableLayoutPanel2.Visible = true;

            // Nếu FormXe đang hiển thị, ẩn đi trước khi hiển thị Form_LichXe
            if (xeForm != null && xeForm.Visible) xeForm.Hide();
            // Nếu Form_Main đang hiển thị, ẩn đi trước khi hiển thị Form_LichXe
            if (mainForm != null && mainForm.Visible) mainForm.Hide();
            // Nếu Form_Driver đang hiển thị, ẩn đi trước khi hiển thị Form_LichXe
            if (driverForm != null && driverForm.Visible) driverForm.Hide();
            LichXe_ExamSchedulerMethod();

            // Button RunCamera
            btn_RunCamera.Visible = false;

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
        private void btn_RunCamera_Click(object sender, EventArgs e)
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
            btn_RunCamera.Enabled = false;
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


        // Loading form_Camera lên panel trong form_master
        //public void Camera_ExamSchedulerMethod()
        //{
        //    Form_Xe form_Xe = new Form_Xe();
        //    form_Xe.TopLevel = false;
        //    form_Xe.Dock = DockStyle.Fill;
        //    Xe_tableLayoutPanel2.Controls.Add(form_Xe);
        //    form_Xe.Show();
        //}

        // Loading formXe lên panel trong form_master
        //private static FormXe xeForm = null; // tạo một instance duy nhất của Form_Xe
        private static FormXe xeForm = null; // tạo một instance duy nhất của Form_Xe
        public void Xe_ExamSchedulerMethod()
        {
            if (xeForm == null)
            {
                //xeForm = new Form_Xe();
                xeForm = new FormXe();
                xeForm.TopLevel = false;
                xeForm.Dock = DockStyle.Fill;

                // Thêm form_Xe vào control con cuối cùng trong Xe_tableLayoutPanel2
                Xe_tableLayoutPanel2.Controls.Add(xeForm, Xe_tableLayoutPanel2.Controls.Count - 1, 0);

                // Đăng ký sự kiện Closed để set xeForm về null
                xeForm.Closed += (s, args) => { xeForm.Dispose(); xeForm = null; };
            }

            // Hiển thị form_Xe
            xeForm.Show();
        }

        // Loading form_Main lên panel trong form_master
        //private static Form_Main mainForm = null; // tạo một instance duy nhất của Form_Xe
        private static Form_Main mainForm = null; // tạo một instance duy nhất của Form_Xe
        public void Main_ExamSchedulerMethod()
        {
            if (mainForm == null)
            {
                //xeForm = new Form_Xe();
                mainForm = new Form_Main();
                mainForm.TopLevel = false;
                mainForm.Dock = DockStyle.Fill;

                // Thêm form_Xe vào control con cuối cùng trong Xe_tableLayoutPanel2
                Xe_tableLayoutPanel2.Controls.Add(mainForm, Xe_tableLayoutPanel2.Controls.Count - 1, 0);

                // Đăng ký sự kiện Closed để set xeForm về null
                mainForm.Closed += (s, args) => { mainForm.Dispose(); mainForm = null; };
            }

            // Hiển thị form_Xe
            mainForm.Show();
        }

        // Loading form_Driver lên panel trong form_master
        //private static Form_Driver driverForm = null; // tạo một instance duy nhất của Form_Xe
        private static Form_Driver driverForm = null; // tạo một instance duy nhất của Form_Xe
        public void Driver_ExamSchedulerMethod()
        {
            if (driverForm == null)
            {
                //xeForm = new Form_Xe();
                driverForm = new Form_Driver();
                driverForm.TopLevel = false;
                driverForm.Dock = DockStyle.Fill;
                // Thêm form_Xe vào control con cuối cùng trong Xe_tableLayoutPanel2
                Xe_tableLayoutPanel2.Controls.Add(driverForm, Xe_tableLayoutPanel2.Controls.Count - 1, 0);

                // Đăng ký sự kiện Closed để set xeForm về null
                driverForm.Closed += (s, args) => { driverForm.Dispose(); driverForm = null; };
            }

            // Hiển thị form_Xe
            driverForm.Show();
        }

        // Loading lichxeForm lên panel trong form_master
        //private static Form_lichxe lichxeForm = null; // tạo một instance duy nhất của Form_Xe
        private static Form_lichxe lichxeForm = null; // tạo một instance duy nhất của Form_Xe
        public void LichXe_ExamSchedulerMethod()
        {
            if (lichxeForm == null)
            {
                //xeForm = new Form_Xe();
                lichxeForm = new Form_lichxe();
                lichxeForm.TopLevel = false;
                lichxeForm.Dock = DockStyle.Fill;
                // Thêm form_Xe vào control con cuối cùng trong Xe_tableLayoutPanel2
                Xe_tableLayoutPanel2.Controls.Add(lichxeForm, Xe_tableLayoutPanel2.Controls.Count - 1, 0);

                // Đăng ký sự kiện Closed để set xeForm về null
                lichxeForm.Closed += (s, args) => { lichxeForm.Dispose(); lichxeForm = null; };
            }

            // Hiển thị form_Xe
            lichxeForm.Show();
        }

        // Button đăng xuất
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // close 
            if(MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                return;
            }
            Form_login form_Login = new Form_login();
            form_Login.ShowDialog();
        }

        private void guna2CircleButton2_MouseHover(object sender, EventArgs e)
        {
            Guna2CircleButton button = (Guna2CircleButton)sender;
            settings_label.Visible = true;
            guna2CircleButton2.Size = new Size(45, 45);
            button.BringToFront();
        }

        private void guna2CircleButton2_MouseLeave(object sender, EventArgs e)
        {
            Guna2CircleButton button = (Guna2CircleButton)sender;
            guna2CircleButton2.Size = new Size(40, 40);
            settings_label.Visible = false;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have clicked on the NotifyIcon.");
        }

        private void quảnLíDữLiệuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Tắt Control 
            Camera_tableLayoutPanel1.Visible = false;

            // Mở form_Xe
            Xe_tableLayoutPanel2.Visible = true;

            // Nếu FormXe đang hiển thị, ẩn đi trước khi hiển thị Form_QuanLi
            if (driverForm != null && driverForm.Visible) driverForm.Hide();
            // Nếu Form_Main đang hiển thị, ẩn đi trước khi hiển thị Form_QuanLi
            if (xeForm != null && xeForm.Visible) xeForm.Hide();
            // Nếu Form_LichXe đang hiển thị, ẩn đi trước khi hiển thị Form_QuanLi
            if (lichxeForm != null && lichxeForm.Visible) lichxeForm.Hide();
            Main_ExamSchedulerMethod();
        }

        private void quảnLíXeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Tắt Control 
            Camera_tableLayoutPanel1.Visible = false;
            // Mở form_Xe
            Xe_tableLayoutPanel2.Visible = true;

            // Nếu FormXe đang hiển thị, ẩn đi trước khi hiển thị FormXe
            if (driverForm != null && driverForm.Visible) driverForm.Hide();
            // Nếu Form_Main đang hiển thị, ẩn đi trước khi hiển thị FormXe
            if (mainForm != null && mainForm.Visible) mainForm.Hide();
            // Nếu Form_LichXe đang hiển thị, ẩn đi trước khi hiển thị FormXe
            if (lichxeForm != null && lichxeForm.Visible) lichxeForm.Hide();
            Xe_ExamSchedulerMethod();
        }

        private void quảnLíTàiXếToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Tắt Control 
            Camera_tableLayoutPanel1.Visible = false;
            // Mở form_Xe
            Xe_tableLayoutPanel2.Visible = true;

            // Nếu FormXe đang hiển thị, ẩn đi trước khi hiển thị Form_Driver
            if (xeForm != null && xeForm.Visible) xeForm.Hide();
            // Nếu Form_Main đang hiển thị, ẩn đi trước khi hiển thị Form_Driver
            if (mainForm != null && mainForm.Visible) mainForm.Hide();
            // Nếu Form_Main đang hiển thị, ẩn đi trước khi hiển thị Form_Driver
            if (lichxeForm != null && lichxeForm.Visible) lichxeForm.Hide();
            Driver_ExamSchedulerMethod();
        }

        private void quảnLíLịchTrìnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Tắt Control 
            Camera_tableLayoutPanel1.Visible = false;
            // Mở form_Xe
            Xe_tableLayoutPanel2.Visible = true;

            // Nếu FormXe đang hiển thị, ẩn đi trước khi hiển thị Form_LichXe
            if (xeForm != null && xeForm.Visible) xeForm.Hide();
            // Nếu Form_Main đang hiển thị, ẩn đi trước khi hiển thị Form_LichXe
            if (mainForm != null && mainForm.Visible) mainForm.Hide();
            // Nếu Form_Driver đang hiển thị, ẩn đi trước khi hiển thị Form_LichXe
            if (driverForm != null && driverForm.Visible) driverForm.Hide();
            LichXe_ExamSchedulerMethod();
        }

        private void thêmLịchTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlilichtrinh quanlilichtrinh = new quanlilichtrinh();
            quanlilichtrinh.ShowDialog();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timeToolStripMenuItem.Text = DateTime.Now.ToShortTimeString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dateToolStripMenuItem.Text = DateTime.Now.ToLongDateString();

        }

        private void timeToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            timeToolStripMenuItem.ForeColor = Color.Black;
        }

        private void dateToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            //timeToolStripMenuItem.BackColor = Color.FromArgb(208, 212, 213);
            //timeToolStripMenuItem.ForeColor = Color.FromArgb(0, 13, 66);
        }

        private void timeToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            timeToolStripMenuItem.ForeColor = Color.Black;
        }
    }
}
