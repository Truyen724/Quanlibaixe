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
        }
        List<string> dates = new List<string>();
        public void load_driver()
        {
            String query = "select * from Driver";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            using (DbDataReader reader = com.ExecuteReader())
            {
                comboBox1.Items.Clear();
                comboBox3.Items.Clear();
                dates.Clear();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetValue(0).ToString());
                        comboBox3.Items.Add(reader.GetValue(1).ToString());
                        dates.Add(reader.GetValue(2).ToString().Substring(0, 10));
                    }
                    reader.Dispose();
                }
            }
            conn.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = comboBox3.SelectedIndex;
            string[] x = dates[comboBox3.SelectedIndex].Split('/');
            int day = 0, month = 0, year = 0;
            if (int.TryParse(x[0], out day) && int.TryParse(x[1], out month) && int.TryParse(x[2], out year))
            {
                try
                {
                    // Use TryParseExact method to convert string x to a DateTime object
                    if (DateTime.TryParseExact(x[0] + "/" + x[1] + "/" + x[2], "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime date))
                    {
                        dateTimePicker2.Value = date;

                        // Add code to retrieve ID_driver and Driver_Name from the database based on the selected birthdate
                        string connectionString = "PUT YOUR CONNECTION STRING HERE";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand("SELECT [ID_driver], [Driver_Name] FROM [Detect_bienso].[dbo].[Driver] WHERE [Dateofbirth] = @birthdate", connection);
                            command.Parameters.AddWithValue("@birthdate", date);
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                int id = (int)reader["ID_driver"];
                                string name = (string)reader["Driver_Name"];
                                // Do something with id and name
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("1.Định dạng ngày sinh không hợp lệ.");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("2.Định dạng ngày sinh không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("3.Định dạng ngày sinh không hợp lệ.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = String.Format("update Driver Set Driver_Name = N'{0}', Dateofbirth ='{1}' where ID_driver = {2} ", comboBox3.Text, dateTimePicker2.Value.ToString("yyyyMMdd"), comboBox1.Text);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công");
            load_driver();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String query = String.Format("Delete from driver where Id_driver = {0}", comboBox1.Text);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công");
                load_driver();
                comboBox3.Text = "";
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Không Thể Xóa Được");
            }

        }

        private void button2_Click(object sender, EventArgs e)
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
                com.Parameters.AddWithValue("@DateOfBirth", NgaySinh_dateTimePicker.Value);
                int result = com.ExecuteNonQuery();
                conn.Close();

                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    load_driver();
                    //ketnoi();
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
    }
}
