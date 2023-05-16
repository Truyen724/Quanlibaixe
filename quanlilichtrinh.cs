using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using Guna.UI2.WinForms;

namespace Quanlibaixe
{
    public partial class quanlilichtrinh : Form
    {
        public quanlilichtrinh()
        {
            InitializeComponent();
            ketnoi();
            comboBox1.Text = "0";
            comboBox2.Text = "0";
        }
        String ConectionString = infor.ConectionString;
        SqlConnection conn = new SqlConnection();
        public void ketnoi()
        {
            try
            {
                conn.ConnectionString = ConectionString;
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại");
            }
            String query = "select Id_car, Driver_Name, Desciption from Car inner join Driver on Car.ID_driver =  Driver.ID_driver ";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            using (DbDataReader reader = com.ExecuteReader())
            {

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        comboBox4.Items.Add(reader.GetValue(0).ToString());
                        comboBox3.Items.Add(reader.GetValue(1).ToString());
                        comboBox5.Items.Add(reader.GetValue(2).ToString());
                    }
                    reader.Dispose();
                }
            }
            conn.Close();
        }

        private void quanlilichtrinh_Load(object sender, EventArgs e)
        {

        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string time = comboBox1.Text + ":" + comboBox2.Text;
            string id_car = comboBox4.Text;
            string description = txt_ND.Text;

            if (!string.IsNullOrEmpty(time) && !string.IsNullOrEmpty(id_car) && !string.IsNullOrEmpty(description))
            {
                try {
                    DateTime iDate = dateTimePicker1.Value;
                    string strDate = iDate.ToString("yyyyMMdd");
                    string id_schedule = GetTimestamp(DateTime.Now);
                    string id_action = "";
                    String query = String.Format("Insert into schedule (id_schedule, ngay, time, id_car, description, id_action) values ('{0}', '{1}', '{2}', '{3}', N'{4}', '{5}')", id_schedule, strDate, time, id_car, description, id_action);
                    conn.Open();
                    SqlCommand com = new SqlCommand(query, conn);
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn một ngày sinh hợp lệ.");
            }
        }

        // Button Thêm
        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có muốn thêm dữ liệu ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string time = comboBox1.Text + ":" + comboBox2.Text;
                string id_car = comboBox4.Text;
                string description = txt_ND.Text;

                if (!string.IsNullOrEmpty(time) && !string.IsNullOrEmpty(id_car) && !string.IsNullOrEmpty(description))
                {
                    try
                    {
                        DateTime iDate = dateTimePicker1.Value;
                        string strDate = iDate.ToString("yyyyMMdd");
                        string id_schedule = GetTimestamp(DateTime.Now);
                        string id_action = "";
                        String query = String.Format("Insert into schedule (id_schedule, ngay, time, id_car, description, id_action) values ('{0}', '{1}', '{2}', '{3}', N'{4}', '{5}')", id_schedule, strDate, time, id_car, description, id_action);
                        conn.Open();
                        SqlCommand com = new SqlCommand(query, conn);
                        com.CommandType = CommandType.Text;
                        com.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Thêm thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi không thể xóa" + ex.Message, "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn một thời gian hợp lệ.");
                }
            }
            else
            {
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = comboBox3.SelectedIndex;
            comboBox5.SelectedIndex = comboBox3.SelectedIndex;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = comboBox4.SelectedIndex;
            comboBox5.SelectedIndex = comboBox4.SelectedIndex;
        }

        private void lichXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // Khai bao lien ket giua form master va form lich 
        public Form_Master CallerForm { get; set; }
        public quanlilichtrinh(Form_Master callerForm) : this()
        {
            this.CallerForm = callerForm;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
            comboBox3.Text = "";
            comboBox5.Text = "";
            txt_ND.Text = "";
            //ketnoi();
            this.Refresh();
        }

        private void btn_Refresh_MouseHover(object sender, EventArgs e)
        {
            // Transiton HorizSlide cho label3.Visible = false thi animation moi chay
            guna2Transition1.ShowSync(label13);
        }

        private void btn_Refresh_MouseLeave(object sender, EventArgs e)
        {
            label13.Visible = false;
        }
    }
}
