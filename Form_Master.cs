using Guna.UI2.WinForms;
using Quanlibaixe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Compilation;
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

        //
        String id_access = infor.id_access.Trim();
        String ConectionString = infor.ConectionString;

        //
        private Thread thread2 = null;

        public Form_Master()
        {
            InitializeComponent();

            //Mặc định ButtonCT2 xuất hiện SidePanel đầu tiên.
            SidePanel.Height = buttonCT2.Height;
            SidePanel.Top = buttonCT2.Top;

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

            //Custom hover buttonCT7
            //buttonCT7.MouseEnter += OnMouseEnterButtonCT7;
            //buttonCT7.MouseLeave += OnMouseLeaveButtonCT7;
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
            buttonCT6.ForeColor = Color.Gray;
            SidePanel2.Visible = false;
        }

        //Custom hover buttonCT7
        //private void OnMouseEnterButtonCT7(object sender, EventArgs e)
        //{
        //    buttonCT7.ForeColor = Color.White;
        //    buttonCT7.FlatStyle = FlatStyle.Flat;

        //    // Gán một hình ảnh cho nút.
        //    buttonCT7.Image = Image.FromFile("C:\\Users\\thqnhngqn\\Desktop\\Quanlibaixe\\UI-UX\\ios_shutdown_48px.ico");
        //    //// Căn chỉnh hình ảnh và văn bản trên nút.
        //    //buttonCT7.ImageAlign = ContentAlignment.MiddleRight;
        //    //buttonCT7.TextAlign = ContentAlignment.MiddleLeft;
        //    //// Cung cấp cho nút một giao diện phẳng.
        //    //buttonCT7.FlatStyle = FlatStyle.Flat;

        //    //Tạo hiệu ứng di chuyển thanh sidePanel
        //    SidePanel2.Visible = true;
        //    SidePanel2.Height = buttonCT7.Height;
        //    SidePanel2.Top = buttonCT7.Top;
        //    SidePanel2.BackColor = Color.FromArgb(192, 27, 55);

        //}
        //private void OnMouseLeaveButtonCT7(object sender, EventArgs e)
        //{
        //    //buttonCT2.BackColor = SystemColors.ButtonFace;
        //    buttonCT7.ForeColor = Color.Gray;
        //    SidePanel2.Visible = false;
        //    SidePanel2.BackColor = Color.FromArgb(40, 86, 182);
        //    buttonCT7.Image = Image.FromFile("C:\\Users\\thqnhngqn\\Desktop\\Quanlibaixe\\UI-UX\\ios_shutdown_48px_gray_48.png");
        //}
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

            //
            Form_Camera_tableLayoutPanel.Visible = true;

            //
            if (id_access == "2")
            {
                menuStrip1.Visible = false;

             }
        }

        //// Rund
        //public string rund()
        //{

        //    string text = File.ReadAllText("Detect_BienSo/data.txt");

        //    return text;
        //}

        //// Write
        //public void write(string a)
        //{
        //    File.WriteAllText("data_save.txt", a);
        //}

        //// Check
        //public string check()
        //{
        //    string text = File.ReadAllText("data_save.txt");
        //    return text;
        //}

        //// Run_Check
        //public void run_check()
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            String[] t1 = rund().Split('|');
        //            string t_check = check();
        //            if (t_check != t1[0])
        //            {
        //                Form_Action f = new Form_Action(id_xe: t1[1], id_action: t1[0]);
        //                f.ShowDialog();
        //            }

        //            write(t1[0]);
        //        }
        //        catch
        //        {

        //        }

        //    }
        //}

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

            //
            Form_Camera_tableLayoutPanel.Visible = true;

            // Transition
            //guna2Transition2.HideSync(UserControl);
            //guna2Transition1.ShowSync(UserControl);

            button1.Visible = true;
            //CustomControll.BringToFront();         

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

            Form_Camera_tableLayoutPanel.Visible = false;
            button1.Visible = false;
            //CustomControll.BringToFront();         

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

            Form_Camera_tableLayoutPanel.Visible = false;
            button1.Visible = false;
            //CustomControll.BringToFront();         

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

            Form_Camera_tableLayoutPanel.Visible = false;
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

            Form_Camera_tableLayoutPanel.Visible = false;
            button1.Visible = false;
            //CustomControll.BringToFront();         

        }

        private void buttonCT7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }

        // LICENSE PLATE DETECTION button
        private void button1_Click_1(object sender, EventArgs e)
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
