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
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Quanlibaixe
{
    public partial class Form_Driver : Form
    {
        public Form_Driver()
        {
            InitializeComponent();
            ketnoi();
            load_driver();
        }
        String ConectionString = infor.ConectionString;
        SqlConnection conn = new SqlConnection();
        //
        public void ketnoi()
        {
            try
            {
                conn.ConnectionString = ConectionString;
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại !");
            }

            String query = "select [ID_driver], [Driver_Name], [Dateofbirth], [Phone_Number], [Dia_Chi] FROM [Detect_bienso].[dbo].[Driver]";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        List<string> dates = new List<string>();
        public void load_driver()
        {
            String query = "select * from Driver";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            using (DbDataReader reader = com.ExecuteReader())
            {
                cb_IDtaixe.Items.Clear();
                dates.Clear();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        cb_IDtaixe.Items.Add(reader.GetValue(0).ToString());
                        dates.Add(reader.GetValue(2).ToString().Substring(0, 10));
                    }
                    reader.Dispose();
                }
            }
            conn.Close();
        }

        // Button Edit
        private void button1_Click(object sender, EventArgs e)
        {
            String query = String.Format("update Driver Set Driver_Name = N'{0}', Dateofbirth ='{1}' where ID_driver = {2} ", txt_TenTaiXe.Text, NgaySinh_dateTimePicker.Value.ToString("yyyy/MM/dd"), txt_PhoneNumber.Text, txt_DiaChi.Text, cb_IDtaixe.Text);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công");
            load_driver();

        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            String query = String.Format("update Driver Set Driver_Name = N'{0}', Dateofbirth ='{1}' where ID_driver = {2} ", txt_TenTaiXe.Text, NgaySinh_dateTimePicker.Value.ToString("yyyy/MM/dd"), txt_PhoneNumber.Text, txt_DiaChi.Text, cb_IDtaixe.Text);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công");
            //load_driver();
            ketnoi();
        }

        // Button Delete
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                String query = String.Format("Delete from driver where Id_driver = {0}", cb_IDtaixe.Text);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công");
                cb_IDtaixe.Text = "";
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Không Thể Xóa Được");
            }
        }

        // Button Add
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Lỗi này khả năng cao do việc bảng Driver của bạn đã được tạo trước
            if (txt_TenTaiXe.Text != "" && NgaySinh_dateTimePicker.Value <= DateTime.Now)
            {
                String query = "INSERT INTO Driver (ID_driver, Driver_Name, Dateofbirth) VALUES (@IDDriver, @DriverName, @DateOfBirth)";
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                // Sử dụng SELECT MAX(ID_driver) + 1 để tạo giá trị ID mới cho bản ghi
                com.Parameters.AddWithValue("@IDDriver", Convert.ToInt32(new SqlCommand("SELECT MAX(ID_driver) + 1 FROM Driver", conn).ExecuteScalar()));
                com.Parameters.AddWithValue("@DriverName", txt_TenTaiXe.Text);
                com.Parameters.AddWithValue("@DateOfBirth", NgaySinh_dateTimePicker.Value.ToString("yyyy/MM/dd"));
                com.Parameters.AddWithValue("@Phone_Number", txt_PhoneNumber.Text);
                com.Parameters.AddWithValue("@Dia_Chi", txt_DiaChi.Text);
                int result = com.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    ketnoi();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn một ngày sinh hợp lệ.");
            }
        }

        private void Form_Driver_Load(object sender, EventArgs e)
        {

        }

        // Khai bao lien ket giua form master va form Quan li du lieu
        public Form_Master CallerForm { get; set; }
        public Form_Driver(Form_Master callerForm) : this()
        {
            this.CallerForm = callerForm;
        }

        //private void cb_TenTaiXe2_SelectedIndexChanged(object sender, EventArgs e)
        //{
            //cb_IDtaixe.SelectedIndex = cb_TenTaiXe2.SelectedIndex;
            //string[] x = dates[cb_TenTaiXe2.SelectedIndex].Split('/');
            //int day = 0, month = 0, year = 0;
            //if (int.TryParse(x[0], out day) && int.TryParse(x[1], out month) && int.TryParse(x[2], out year))
            //{
            //    try
            //    {
            //        // Use TryParseExact method to convert string x to a DateTime object
            //        if (DateTime.TryParseExact(x[0] + "/" + x[1] + "/" + x[2], "yyyy/MM/dd", null, DateTimeStyles.None, out DateTime date))
            //        {
            //            NgaySinh_dateTimePicker.Value = date;

            //            // Add code to retrieve ID_driver and Driver_Name from the database based on the selected birthdate
            //            string connectionString = "PUT YOUR CONNECTION STRING HERE";
            //            using (SqlConnection connection = new SqlConnection(connectionString))
            //            {
            //                SqlCommand command = new SqlCommand("SELECT [ID_driver], [Driver_Name] FROM [Detect_bienso].[dbo].[Driver] WHERE [Dateofbirth] = @birthdate", connection);
            //                command.Parameters.AddWithValue("@birthdate", date);
            //                connection.Open();
            //                SqlDataReader reader = command.ExecuteReader();
            //                while (reader.Read())
            //                {
            //                    int id = (int)reader["ID_driver"];
            //                    string name = (string)reader["Driver_Name"];
            //                    // Do something with id and name
            //                }
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("1.Định dạng ngày sinh không hợp lệ.");
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        MessageBox.Show("2.Định dạng ngày sinh không hợp lệ.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("3.Định dạng ngày sinh không hợp lệ.");
            //}
        //}


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                cb_IDtaixe.SelectedIndex = cb_IDtaixe.FindStringExact(row.Cells["ID_driver"].Value.ToString());
                //txt_TenTaiXe.Text = row.Cells["Driver_Name"].Value.ToString();
                txt_TenTaiXe.Text = row.Cells["Driver_Name"].Value.ToString();
                NgaySinh_dateTimePicker.Text = row.Cells["Dateofbirth"].Value.ToString();
                txt_PhoneNumber.Text = row.Cells["Phone_Number"].Value.ToString();
                txt_DiaChi.Text = row.Cells["Dia_Chi"].Value.ToString();

            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            var dataSource = dataGridView1.DataSource;
            // Đặt giá trị cho DataSource thành null
            dataGridView1.DataSource = null;

            // Thiết lập lại nguồn dữ liệu đã lưu
            dataGridView1.DataSource = dataSource;

            cb_IDtaixe.Text = "";
            txt_TenTaiXe.Text = "";
            NgaySinh_dateTimePicker.Text = "";
            txt_PhoneNumber.Text = "";
            txt_DiaChi.Text = "";
            ketnoi();
            this.Refresh();
        }

        private void btn_Refresh_MouseHover(object sender, EventArgs e)
        {
            // Transiton HorizSlide cho label3.Visible = false thi animation moi chay
            guna2Transition1.ShowSync(label5);
        }

        private void btn_Refresh_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }


    }
}
