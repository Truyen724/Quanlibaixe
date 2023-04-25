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
            //ketnoi();
            //load_driver();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                MoTa_textbox.Text = row.Cells[0].Value.ToString();
                TaiXe_combobox.SelectedIndex = IDtaixe_combobox.FindStringExact(row.Cells[2].Value.ToString());
                TrangThai_combobox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            MoTa_textbox.Text = row.Cells[0].Value.ToString();
            TaiXe_combobox.SelectedIndex = IDtaixe_combobox.FindStringExact(row.Cells[2].Value.ToString());
            TrangThai_combobox.Text = row.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            MoTa_textbox.Text = row.Cells[0].Value.ToString();
            TaiXe_combobox.SelectedIndex = IDtaixe_combobox.FindStringExact(row.Cells[2].Value.ToString());
            TrangThai_combobox.Text = row.Cells[3].Value.ToString();
        }

        private void TaiXe_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDtaixe_combobox.SelectedIndex = TaiXe_combobox.SelectedIndex;
            NgaySinh_combobox.SelectedIndex = TaiXe_combobox.SelectedIndex;
        }

        // Button Them
        private void Them_button_Click(object sender, EventArgs e)
        {
            if (BienSo_textbox.Text != "" & TaiXe_combobox.Text != "")
            {
                try
                {
                    String query = String.Format("Insert into Car (Id_car,Id_driver,State,Desciption) values ('{0}',{1},'{2}',N'{3}')", BienSo_textbox.Text, IDtaixe_combobox.Text, TrangThai_combobox.Text, MoTa_textbox.Text);
                    conn.Open();
                    SqlCommand com = new SqlCommand(query, conn);
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    MessageBox.Show("Thêm Thành Công");
                    ketnoi();
                    load_driver();
                }
                catch
                {
                    MessageBox.Show("Lỗi ");
                    conn.Close();
                }


            }
        }

        // Button Sua
        private void Sua_button_Click(object sender, EventArgs e)
        {
            String query = String.Format("Update Car Set Id_driver = {0}, State = '{1}', Desciption = N'{2}' where id_car = '{3}' ", IDtaixe_combobox.Text, TrangThai_combobox.Text, MoTa_textbox.Text, BienSo_textbox.Text);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
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
                TrangThai_combobox.Text = "";
                TaiXe_combobox.Text = "";
            }
            catch
            {
                MessageBox.Show("Không Thể Xóa Được");
            }
        }
    }
}
