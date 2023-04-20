using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using Quanlibaixe.Custom_Toolbox;
using System.Reflection.Emit;

namespace Quanlibaixe
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }
        String ConectionString = infor.ConectionString;
        SqlConnection conn = new SqlConnection();

        private void login_Load(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = ConectionString;
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }

        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("");
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Email_TextBox.Text != "" && Password_TextBox.Text != "")
            {
                string query = String.Format("select Id_admin, Access_id from Ad_min where Name = '{0}' COLLATE SQL_Latin1_General_CP1_CS_AS and Password ='{1}' COLLATE SQL_Latin1_General_CP1_CS_AS", Email_TextBox.Text, Password_TextBox.Text);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                using (DbDataReader reader = com.ExecuteReader())
                {

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            reader.GetValue(0).ToString();
                            infor.id_access = reader.GetValue(1).ToString();
                            Form_camera f = new Form_camera();
                            this.Hide();
                            f.ShowDialog();
                            Application.Exit();
                        }
                        reader.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    }
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản mật khẩu");
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }

        private void PasswordTextBox_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("");
        }

        private void Email_TextBox_MouseHover(object sender, EventArgs e)
        {
            label1.Location = new Point(29, 215);
        }

        private void Email_TextBox_MouseLeave(object sender, EventArgs e)
        {
            if(Email_TextBox.Text != "")
            {
                label1.Location = new Point(29, 215);
            }
            else
            {
                label1.Location = new Point(29, 250);
            }

        }

        private void Password_TextBox_MouseHover(object sender, EventArgs e)
        {
            label2.Location = new Point(29, 295);
        }

        private void Password_TextBox_MouseLeave(object sender, EventArgs e)
        {
            
            if (Password_TextBox.Text != "")
            {
                label2.Location = new Point(29, 295);
            }
            else
            {
                label2.Location = new Point(29, 330);
            }
        }
    }
}
