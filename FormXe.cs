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
namespace Quanlibaixe
{
    public partial class FormXe : Form
    {
        // đoạn mã được đặt form_Xe Nhằm lien ket giua form master va form Xe li du lieu
        public Form_Master CallerForm { get; set; }
        public FormXe(Form_Master callerForm) : this()
        {
            this.CallerForm = callerForm;
        }

        public FormXe()
        {
            InitializeComponent();
            ketnoi();
            load_Car();
            load_driver();
        }

        private void load_Car()
        {           
            {
                // Mở kết nối
                conn.Open();

                // Câu truy vấn SELECT để lấy dữ liệu từ bảng Car
                string query = "SELECT [Id_car], [Id_driver], [State], [Desciption] FROM [Detect_bienso].[dbo].[Car]";

                // Tạo đối tượng SqlCommand để thực hiện câu truy vấn SELECT
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Thực hiện câu truy vấn SELECT và trả về một đối tượng SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Xóa toàn bộ dữ liệu trong DataGridView
                        //dataGridView1.Rows.Clear();

                        // Duyệt qua các bản ghi trả về từ câu truy vấn SELECT và thêm vào DataGridView
                        while (reader.Read())
                        {
                            // Lấy giá trị các cột trong bản ghi hiện tại
                            string id_car = reader.GetString(0);
                            int id_driver = reader.GetInt32(1);
                            string state = reader.GetString(2);
                            string description = reader.GetString(3);

                            // Thêm bản ghi vào DataGridView
                            //dataGridView1.Rows.Add(id_car, id_driver, state, description);
                        }
                        reader.Dispose();
                    }
                }
            }
        }

        // Tạo kết nối tới database
        String ConectionString = infor.ConectionString;
        SqlConnection conn = new SqlConnection();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_IDcar.Text = row.Cells[0].Value.ToString();
                cb_TaiXe.SelectedIndex = cb_IDtaixe.FindStringExact(row.Cells[2].Value.ToString());
                cb_TrangThai.Text = row.Cells[3].Value.ToString();
                txt_MoTa.Text = row.Cells[4].Value.ToString();
            }
        }

        //

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
            String tatcacacxe = "select Id_car, Driver.Id_driver, Driver.Driver_Name, Car.State, Car.Desciption from Car left join Driver on Car.Id_driver = Driver.ID_driver";
            conn.Open();
            SqlCommand com = new SqlCommand(tatcacacxe, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        public void load_driver()
        {
            String query = "select * from Driver";
            //conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            using (DbDataReader reader = com.ExecuteReader())
            {

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        cb_TaiXe.Items.Add(reader.GetValue(1).ToString());
                        cb_IDtaixe.Items.Add(reader.GetValue(0).ToString());
                        cb_NgaySinh.Items.Add(reader.GetValue(2).ToString().Substring(0, 10));
                        
             
                    }
                    reader.Dispose();
                }
            }
            conn.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_IDcar.Text != "" && cb_IDtaixe.Text != "")
            {
                try
                {
                    // sử dụng cơ chế tham số hóa "parameterization mechanism"
                    String query = "Insert into Car (Id_car,Id_driver,State,Desciption) values (@Id_car,@Id_driver,@State,@Desciption)";
                    SqlCommand com = new SqlCommand(query, conn);
                    com.Parameters.AddWithValue("@Id_car", txt_IDcar.Text);
                    com.Parameters.AddWithValue("@Id_driver", cb_IDtaixe.Text);
                    com.Parameters.AddWithValue("@State", cb_TrangThai.Text);
                    com.Parameters.AddWithValue("@Desciption", txt_MoTa.Text);

                    conn.Open();
                    com.CommandType = CommandType.Text;

                    // Thực hiện câu truy vấn và đóng kết nối sau khi hoàn thành
                    com.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm Thành Công");

                    // Gọi phương thức ketnoi() để cập nhật dữ liệu trên giao diện
                    ketnoi();
                }
                catch
                {
                    MessageBox.Show("Lỗi ");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chọn một ngày sinh hợp lệ.");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_IDtaixe.SelectedIndex = cb_TaiXe.SelectedIndex;
            //comboBox7.SelectedIndex = comboBox4.SelectedIndex;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            String query = String.Format("Update Car Set Id_driver = {0}, State = '{1}', Desciption = N'{2}' where id_car = '{3}' ", cb_IDtaixe.Text, cb_TrangThai.Text, txt_MoTa.Text, txt_IDcar.Text);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
            ketnoi();
            MessageBox.Show("Chỉnh thành công");
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_IDcar.Text = row.Cells[0].Value.ToString();
                cb_TaiXe.SelectedIndex = cb_IDtaixe.FindStringExact(row.Cells[2].Value.ToString());
                cb_TrangThai.Text = row.Cells[3].Value.ToString();
                txt_MoTa.Text = row.Cells[4].Value.ToString();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_IDcar.Text = row.Cells[0].Value.ToString();
                cb_TaiXe.SelectedIndex = cb_IDtaixe.FindStringExact(row.Cells[2].Value.ToString());
                cb_TrangThai.Text = row.Cells[3].Value.ToString();
                txt_MoTa.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra trạng thái kết nối trước khi mở kết nối
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                // Tạo đối tượng SqlCommand và sử dụng tham số để tránh lỗ hổng bảo mật
                string query = "DELETE FROM Car WHERE Id_Car = @id_car";
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@id_car", txt_IDcar.Text);

                // Thực hiện câu truy vấn và đóng kết nối sau khi hoàn thành
                com.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Xóa thành công");

                // Gọi phương thức ketnoi() để cập nhật dữ liệu trên giao diện
                ketnoi();

                // Xóa giá trị của các combobox
                cb_TrangThai.SelectedIndex = -1;
                cb_TaiXe.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa được: " + ex.Message);
            }
        }

        private void FormXe_Load(object sender, EventArgs e)
        {

        }

        private void cb_IDtaixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_IDtaixe.SelectedIndex = cb_TaiXe.SelectedIndex;
            cb_NgaySinh.SelectedIndex = cb_TaiXe.SelectedIndex;
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.White;
            style.BackColor = Color.FromArgb(26, 34, 65);
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle = style;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.Gray;
            style.BackColor = Color.White;
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle = style;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            // Làm mới DataGridView
            //dataGridView1.Refresh();

            // Lưu nguồn dữ liệu hiện tại
            var dataSource = dataGridView1.DataSource;
            // Đặt giá trị cho DataSource thành null
            dataGridView1.DataSource = null;

            // Thiết lập lại nguồn dữ liệu đã lưu
            dataGridView1.DataSource = dataSource;

            txt_IDcar.Text = "";
            cb_IDtaixe.Text = "";
            cb_TaiXe.Text = "";
            cb_TrangThai.Text = "";
            txt_MoTa.Text = "";
            cb_NgaySinh.Text = "";
            //ketnoi();
            load_driver();
            this.Refresh();
        }

        private void btn_Refresh_MouseHover(object sender, EventArgs e)
        {
            // Transiton HorizSlide cho label3.Visible = false thi animation moi chay
            guna2Transition1.ShowSync(label3);
        }

        private void btn_Refresh_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

    }
}
