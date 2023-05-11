using Quanlibaixe.Custom_Toolbox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanlibaixe
{
    public partial class Form_Xe : Form
    {
        String ConectionString = infor.ConectionString;
        SqlConnection conn = new SqlConnection();

        // Khai bao lien ket giua form master va form Xe li du lieu
        public Form_Master CallerForm { get; set; }
        public Form_Xe(Form_Master callerForm) : this()
        {
            this.CallerForm = callerForm;
        }

        public Form_Xe()
        {
            InitializeComponent();
            ketnoi();
            load_driver();
        }

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
            String tatcacacxe = "select Id_car, Driver_Name, Driver.Id_driver, Car.State, Car.Desciption from Car left join Driver on Car.Id_driver = Driver.ID_driver";
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
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            using (DbDataReader reader = com.ExecuteReader())
            {

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        TaiXe_combobox.Items.Add(reader.GetValue(1).ToString());
                        IDtaixe_combobox.Items.Add(reader.GetValue(0).ToString());
                        NgaySinh_combobox.Items.Add(reader.GetValue(2).ToString().Substring(0, 10));
                    }
                    reader.Dispose();
                }
            }
            conn.Close();
        }


        // reload page
        private void ReloadPage()
        {
            // Clear all combobox items
            IDtaixe_combobox.Items.Clear();
            TaiXe_combobox.Items.Clear();
            NgaySinh_combobox.Items.Clear();

            // Re-load data from database
            string query = "SELECT [Id_car], [Id_driver], [State], [Desciption] FROM [Detect_bienso].[dbo].[Car]";
            using (SqlCommand com = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("Id_car")) && reader.GetDataTypeName(0) == "nvarchar")
                        {
                            //IDtaixe_combobox.Items.Add(reader.GetInt32(reader.GetOrdinal("Id_car")));
                            IDtaixe_combobox.Items.Add(reader.GetString(reader.GetOrdinal("Id_car")));
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("Id_driver")) && reader.GetDataTypeName(1) == "int")
                        {
                            TaiXe_combobox.Items.Add(reader.GetInt32(reader.GetOrdinal("Id_driver")));
                            //TaiXe_combobox.Items.Add(reader.GetString(reader.GetOrdinal("Id_driver")));
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("State")) && reader.GetDataTypeName(2) == "char")
                        {
                            TaiXe_combobox.Items.Add(reader.GetString(reader.GetOrdinal("State")));
                        }

                        if (!reader.IsDBNull(reader.GetOrdinal("Desciption")) && reader.GetDataTypeName(3) == "nvarchar(MAX)")
                        {
                            TaiXe_combobox.Items.Add(reader.GetString(reader.GetOrdinal("Desciption")));
                        }

                        //if (!reader.IsDBNull(reader.GetOrdinal("Dateofbirth")) && reader.GetDataTypeName(2) == "date")
                        //{
                        //    NgaySinh_combobox.Items.Add(reader.GetDateTime(reader.GetOrdinal("Dateofbirth")).ToString("yyyy-MM-dd"));
                        //}
                    }
                }
                conn.Close();
            }

            // Refresh the form to display updated data
            this.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            BienSo_textbox.Text = row.Cells[0].Value.ToString();
            TaiXe_combobox.SelectedIndex = IDtaixe_combobox.FindStringExact(row.Cells[2].Value.ToString());
            TrangThai_combobox.Text = row.Cells[3].Value.ToString();
            MoTa_textbox.Text = row.Cells[4].Value.ToString();
        }



        private void TaiXe_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDtaixe_combobox.SelectedIndex = TaiXe_combobox.SelectedIndex;
            NgaySinh_combobox.SelectedIndex = TaiXe_combobox.SelectedIndex;
        }

        // Button Them
        private void Them_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BienSo_textbox.Text) && !string.IsNullOrEmpty(IDtaixe_combobox.Text))
            {
                try
                {
                    string query = "Insert into Car (Id_car, Id_driver, State, Desciption) values (@idCar, @idDriver, @state, @description)";
                    using (SqlCommand com = new SqlCommand(query, conn))
                    {
                        com.Parameters.AddWithValue("@idCar", BienSo_textbox.Text);
                        com.Parameters.AddWithValue("@idDriver", IDtaixe_combobox.Text);
                        com.Parameters.AddWithValue("@state", TrangThai_combobox.Text);
                        com.Parameters.AddWithValue("@description", MoTa_textbox.Text);

                        conn.Open();
                        com.ExecuteNonQuery();
                        MessageBox.Show("Thêm Thành Công");
                        load_driver();// tải lại danh sách và hiển thị lên DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // Button Sua
        private void Sua_button_Click(object sender, EventArgs e)
        {
            //Điều này sẽ giúp đảm bảo tính an toàn của ứng dụng và ngăn ngừa các cuộc tấn công SQL Injection.
            String query = "Update Car Set Id_driver=@idDriver, State=@state, Desciption=@description where id_car=@carId";
            using (SqlCommand com = new SqlCommand(query, conn))
            {
                com.Parameters.AddWithValue("@idDriver", IDtaixe_combobox.Text);
                com.Parameters.AddWithValue("@state", TrangThai_combobox.Text);
                com.Parameters.AddWithValue("@description", MoTa_textbox.Text);
                com.Parameters.AddWithValue("@carId", BienSo_textbox.Text);

                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
            }
            ketnoi();
            MessageBox.Show("Chỉnh thành công");
        }

        // Button Xoa
        private void Xoa_button_Click(object sender, EventArgs e)
        {
            try
            {
                String query = String.Format("Delete from Car where Id_Car = '{0}'", TaiXe_combobox.Text);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công");
                ketnoi();
                load_driver();
                //TrangThai_combobox.Text = "";
                TaiXe_combobox.Text = "";
            }
            catch
            {
                MessageBox.Show("Không Thể Xóa Được");
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ReloadPage();
        }
    }
}
