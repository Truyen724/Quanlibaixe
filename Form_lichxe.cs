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

namespace Quanlibaixe
{
    public partial class Form_lichxe : Form
    {
        public Form_lichxe()
        {
            InitializeComponent();
            ketnoi();
            load_data();
        }
        String ConectionString = infor.ConectionString;
        SqlConnection conn = new SqlConnection();
        String query_refresh = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
            comboBox3.SelectedIndex = comboBox1.SelectedIndex;
            String tatcacacxe = String.Format("select id_schedule, ngay, time , id_car,description, id_action from schedule where id_car='{0}'", comboBox1.Text);
            query_refresh = tatcacacxe;
            conn.Open();
            SqlCommand com = new SqlCommand(tatcacacxe, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView2.DataSource = dt;
            conn.Close();
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
            String query = "select Id_car, Driver_Name, Desciption from Car inner join Driver on Car.ID_driver =  Driver.ID_driver ";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            using (DbDataReader reader = com.ExecuteReader())
            {

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetValue(0).ToString());
                        comboBox2.Items.Add(reader.GetValue(1).ToString());
                        comboBox3.Items.Add(reader.GetValue(2).ToString());

                        comboBox6.Items.Add(reader.GetValue(0).ToString());
                        comboBox4.Items.Add(reader.GetValue(1).ToString());
                        comboBox5.Items.Add(reader.GetValue(2).ToString());
                    }
                    reader.Dispose();
                }
            }
            conn.Close();
        }
        public void load_data()
        {
            String tatcacacxe = "select id_schedule, ngay, time , id_car,description, id_action from schedule";
            query_refresh = tatcacacxe;
            conn.Open();
            SqlCommand com = new SqlCommand(tatcacacxe, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView2.DataSource = dt;
            conn.Close();
        }
        public void refresh_data()
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand(query_refresh, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                com.CommandType = CommandType.Text;
                dataGridView2.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            comboBox3.SelectedIndex = comboBox2.SelectedIndex;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //    string id = row.Cells[0].Value.ToString();
            //    string ngay = row.Cells[1].Value.ToString();
            //    string time = row.Cells[2].Value.ToString();
            //    string id_car = row.Cells[3].Value.ToString();
            //    string description = row.Cells[4].Value.ToString();
            //    string id_action = row.Cells[5].Value.ToString();

            //    string[] ngay_ = ngay.Split('/');

            //    int a = Int32.Parse(ngay_[0]);
            //    int b = Int32.Parse(ngay_[1]);

            //    string[] nam_ = ngay_[2].Split(' ');

            //    int c  = Int32.Parse(nam_[0]);
            //    //MessageBox.Show(ngay_[2]);
            //    dateTimePicker1.Value = new DateTime(c,b,a);
            //    string[] time_ = time.Split(':');
            //    comboBox8.Text = time_[0];
            //    comboBox7.Text = time_[1];
            //    comboBox6.Text = id_car;
            //    textBox2.Text = id;
            //    textBox1.Text = description;


            //}
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
        //        string id = row.Cells[0].Value.ToString();
        //        string ngay = row.Cells[1].Value.ToString();
        //        string time = row.Cells[2].Value.ToString();
        //        string id_car = row.Cells[3].Value.ToString();
        //        string description = row.Cells[4].Value.ToString();
        //        string id_action = row.Cells[5].Value.ToString();

        //        if (DateTime.TryParseExact(ngay, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
        //        {
        //            dateTimePicker1.Value = parsedDate;
        //        }
        //        else
        //        {
        //            //MessageBox.Show("Định dạng ngày tháng hợp lệ: " + ngay);
        //        }

        //        string[] time_ = time.Split(':');
        //        comboBox8.Text = time_[0];
        //        comboBox7.Text = time_[1];
        //        comboBox6.Text = id_car;
        //        textBox2.Text = id;
        //        textBox1.Text = description;
        //    }
        //}

        private void comboBox1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = comboBox6.SelectedIndex;
            comboBox5.SelectedIndex = comboBox6.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        // Khai bao lien ket giua form master va form lich xe
        public Form_Master CallerForm { get; set; }
        public Form_lichxe(Form_Master callerForm) : this()
        {
            this.CallerForm = callerForm;
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                string id = row.Cells[0].Value.ToString();
                string ngay = row.Cells[1].Value.ToString();
                string time = row.Cells[2].Value.ToString();
                string id_car = row.Cells[3].Value.ToString();
                string description = row.Cells[4].Value.ToString();
                string id_action = row.Cells[5].Value.ToString();

                if (DateTime.TryParseExact(ngay, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    dateTimePicker1.Value = parsedDate;
                }
                else
                {
                    //MessageBox.Show("Định dạng ngày tháng hợp lệ: " + ngay);
                }

                string[] time_ = time.Split(':');
                comboBox8.Text = time_[0];
                comboBox7.Text = time_[1];
                comboBox6.Text = id_car;
                txt_IDschedule.Text = id;
                txt_ND.Text = description;
            }
        }

        private void dataGridView2_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.White;
            style.BackColor = Color.FromArgb(26, 34, 65);
            if (e.RowIndex > -1)
            {
                dataGridView2.Rows[e.RowIndex].DefaultCellStyle = style;
            }
        }

        private void dataGridView2_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.Gray;
            style.BackColor = Color.White;
            if (e.RowIndex > -1)
            {
                dataGridView2.Rows[e.RowIndex].DefaultCellStyle = style;
            }
        }


        // Button Edit
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DateTime iDate = dateTimePicker1.Value;
            string strDate = iDate.ToString("yyyy/MM/dd");
            string time = comboBox8.Text + ":" + comboBox7.Text;
            string update = string.Format("update schedule set ngay = '{0}',time = '{1}',id_car='{2}', description = N'{3}' where id_schedule ='{4}'", strDate, time, comboBox6.Text, txt_ND.Text, txt_IDschedule.Text);
            conn.Open();
            SqlCommand com = new SqlCommand(update, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công");
            refresh_data();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string update = string.Format("Delete from schedule where id_schedule ='{0}'", txt_IDschedule.Text);
            conn.Open();
            SqlCommand com = new SqlCommand(update, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Xóa thành công");
            refresh_data();
        }

        private void btn_Refresh_MouseLeave(object sender, EventArgs e)
        {
            label13.Visible = false;
        }

        private void btn_Refresh_MouseHover(object sender, EventArgs e)
        {
            // Transiton HorizSlide cho label3.Visible = false thi animation moi chay
            guna2Transition1.ShowSync(label13);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //// Làm mới DataGridView
            //dataGridView1.Refresh();

            //// Lưu nguồn dữ liệu hiện tại
            //var dataSource = dataGridView2.DataSource;
            //// Đặt giá trị cho DataSource thành null
            //dataGridView2.DataSource = null;

            //// Thiết lập lại nguồn dữ liệu đã lưu
            //dataGridView2.DataSource = dataSource;

            txt_IDschedule.Text = "";
            comboBox8.Text = "";
            comboBox7.Text = "";
            comboBox6.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            txt_ND.Text = "";
            //ketnoi();
            this.Refresh();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
