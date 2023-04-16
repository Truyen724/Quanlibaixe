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

namespace Quanlibaixe
{
    public partial class Form_Xe_Control : UserControl
    {
        String ConectionString = infor.ConectionString;
        SqlConnection conn = new SqlConnection();

        public Form_Xe_Control()
        {
            InitializeComponent();
            //ketnoi();
            //load_driver();
        }

        // ketnoi
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

        //load_driver
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
                        TaiXe_ComboBox1.Items.Add(reader.GetValue(1).ToString());
                        IDtaixe_ComboBox1.Items.Add(reader.GetValue(0).ToString());
                        NgaySinh_ComboBox1.Items.Add(reader.GetValue(2).ToString().Substring(0, 10));

                        TaiXe_ComboBox2.Items.Add(reader.GetValue(1).ToString());
                        IDtaixe_ComboBox2.Items.Add(reader.GetValue(0).ToString());
                        NgaySinh_ComboBox2.Items.Add(reader.GetValue(2).ToString().Substring(0, 10));


                    }
                    reader.Dispose();
                }
            }
            conn.Close();
        }

        // Button thêm 
        private void buttonCT1_Click(object sender, EventArgs e)
        {
            if (BienSo_textBox1.Text != "" & TaiXe_ComboBox1.Text != "")
            {
                try
                {
                    String query = String.Format("Insert into Car (Id_car,Id_driver,State,Desciption) values ('{0}',{1},'{2}',N'{3}')", BienSo_textBox1.Text, IDtaixe_ComboBox1.Text, TrangThai_ComboBox1.Text, MoTa_textBoxCT1.Text);
                    conn.Open();

                    SqlCommand com = new SqlCommand(query, conn);
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm Thành Công");
                    ketnoi();
                    load_driver();
                }
                catch
                {
                    MessageBox.Show("Lỗi ");
                }

            }
        }

        // CellContentClick
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                BienSo_textBoxCT2.Text = row.Cells[0].Value.ToString();
                TaiXe_ComboBox2.SelectedIndex = IDtaixe_ComboBox2.FindStringExact(row.Cells[2].Value.ToString());
                TrangThai_ComboBox2.Text = row.Cells[3].Value.ToString();
                MoTa_textBoxCT2.Text = row.Cells[4].Value.ToString();
            }
        }

        // CellClick
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                BienSo_textBoxCT2.Text = row.Cells[0].Value.ToString();
                TaiXe_ComboBox2.SelectedIndex = IDtaixe_ComboBox2.FindStringExact(row.Cells[2].Value.ToString());
                TrangThai_ComboBox2.Text = row.Cells[3].Value.ToString();
                MoTa_textBoxCT2.Text = row.Cells[4].Value.ToString();
            }
        }

        // CellContentDoubleClick
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                BienSo_textBoxCT2.Text = row.Cells[0].Value.ToString();
                TaiXe_ComboBox2.SelectedIndex = IDtaixe_ComboBox2.FindStringExact(row.Cells[2].Value.ToString());
                TrangThai_ComboBox2.Text = row.Cells[3].Value.ToString();
                MoTa_textBoxCT2.Text = row.Cells[4].Value.ToString();
            }
        }

        // Button Xóa
        private void Delete_buttonCT_Click(object sender, EventArgs e)
        {
            try
            {
                String query = String.Format("Delete from Car where Id_Car = '{0}'", BienSo_textBoxCT2.Text);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công");
                ketnoi();
                load_driver();
                TrangThai_ComboBox2.Text = "";
                TaiXe_ComboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Không Thể Xóa Được");
            }
        }

        // Button Sữa
        private void Update_buttonCT_Click(object sender, EventArgs e)
        {
            String query = String.Format("Update Car Set Id_driver = {0}, State = '{1}', Desciption = N'{2}' where id_car = '{3}' ", IDtaixe_ComboBox2.Text, TrangThai_ComboBox2.Text, MoTa_textBoxCT2.Text, BienSo_textBoxCT2.Text);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
            ketnoi();
            MessageBox.Show("Chỉnh thành công");
        }

        //ComboBox TaiXe 2 SelectedIndexChanged
        private void TaiXe_ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDtaixe_ComboBox2.SelectedIndex = TaiXe_ComboBox2.SelectedIndex;
            NgaySinh_ComboBox2.SelectedIndex = TaiXe_ComboBox2.SelectedIndex;
        }

        //ComboBox TaiXe 1 SelectedIndexChanged
        private void TaiXe_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDtaixe_ComboBox1.SelectedIndex = TaiXe_ComboBox2.SelectedIndex;
            NgaySinh_ComboBox1.SelectedIndex = TaiXe_ComboBox2.SelectedIndex;
        }
    }
}
