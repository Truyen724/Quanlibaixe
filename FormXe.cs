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
            load_driver();
        }
        String ConectionString = infor.ConectionString;
        SqlConnection conn = new SqlConnection();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox4.Text = row.Cells[0].Value.ToString();
                comboBox4.SelectedIndex = comboBox8.FindStringExact(row.Cells[2].Value.ToString());
                comboBox3.Text = row.Cells[3].Value.ToString();
                textBox2.Text = row.Cells[4].Value.ToString();
            }
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
            String tatcacacxe = "select Id_car, Driver.Driver_Name, Driver.Id_driver, Car.State, Car.Desciption from Car left join Driver on Car.Id_driver = Driver.ID_driver";
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
                        comboBox1.Items.Add(reader.GetValue(1).ToString());
                        comboBox5.Items.Add(reader.GetValue(0).ToString());
                        //comboBox6.Items.Add(reader.GetValue(2).ToString().Substring(0, 10));

                        comboBox4.Items.Add(reader.GetValue(1).ToString());
                        comboBox8.Items.Add(reader.GetValue(0).ToString());
                        //comboBox7.Items.Add(reader.GetValue(2).ToString().Substring(0, 10));
                        
             
                    }
                    reader.Dispose();
                }
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.SelectedIndex = comboBox1.SelectedIndex;
            //comboBox6.SelectedIndex = comboBox1.SelectedIndex;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox3.Text!="" && comboBox1.Text!= "")
            {
                try
                {
                    // "Insert into Car (Id_car,Id_driver,State,Desciption) values ('{0}',{1},'{2}',N'{3}')" sử dụng các tham số để thay thế vào chuỗi truy vấn SQL.
                    // lỗ hổng bảo mật
                    // rất nguy hiểm bạn có thể gặp các cuộc tấn công SQL Injection.
                    //String query = String.Format("Insert into Car (Id_car,Id_driver,State,Desciption) values ('{0}',{1},'{2}',N'{3}')", textBox3.Text, comboBox5.Text, comboBox2.Text, textBox1.Text);

                    // sử dụng cơ chế tham số hóa "parameterization mechanism"
                    String query = "Insert into Car (Id_car,Id_driver,State,Desciption) values (@Id_car,@Id_driver,@State,@Desciption)";
                    SqlCommand com = new SqlCommand(query, conn);
                    com.Parameters.AddWithValue("@Id_car", textBox3.Text);
                    com.Parameters.AddWithValue("@Id_driver", comboBox5.Text);
                    com.Parameters.AddWithValue("@State", comboBox2.Text);
                    com.Parameters.AddWithValue("@Desciption", textBox1.Text);

                    conn.Open();
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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox8.SelectedIndex = comboBox4.SelectedIndex;
            //comboBox7.SelectedIndex = comboBox4.SelectedIndex;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = String.Format("Update Car Set Id_driver = {0}, State = '{1}', Desciption = N'{2}' where id_car = '{3}' " , comboBox8.Text, comboBox3.Text, textBox2.Text, textBox4.Text);
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
                textBox4.Text = row.Cells[0].Value.ToString();
                comboBox4.SelectedIndex = comboBox8.FindStringExact(row.Cells[2].Value.ToString());
                comboBox3.Text = row.Cells[3].Value.ToString();
                textBox2.Text = row.Cells[4].Value.ToString();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox4.Text = row.Cells[0].Value.ToString();
                comboBox4.SelectedIndex = comboBox8.FindStringExact(row.Cells[2].Value.ToString());
                comboBox3.Text = row.Cells[3].Value.ToString();
                textBox2.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String query = String.Format("Delete from Car where Id_Car = '{0}'", textBox4.Text);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công");
                ketnoi();
                load_driver();
                comboBox3.Text = "";
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Không Thể Xóa Được");
            }
        }

        private void FormXe_Load(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            // Làm mới DataGridView
            //dataGridView1.Refresh();

            // Lưu nguồn dữ liệu hiện tại
            var dataSource = dataGridView1.DataSource;
            // Đặt giá trị cho DataSource thành null
            dataGridView1.DataSource = null;

            // Thiết lập lại nguồn dữ liệu đã lưu
            dataGridView1.DataSource = dataSource;           

            textBox4.Text = "";
            comboBox8.Text = "";
            comboBox4.Text = "";
            comboBox3.Text = "";
            textBox2.Text = "";

            this.Refresh();
        }
    }
}
