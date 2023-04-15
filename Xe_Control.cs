using Guna.UI2.WinForms;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanlibaixe
{
    public partial class Xe_Control : UserControl
    {
        private bool buttonCT1Checked = false;
        private bool buttonCT2Checked = false;

        String ConectionString = "server = DESKTOP-O41267U; database = Detect_bienso; integrated security = true";
        SqlConnection conn = new SqlConnection();

        public Xe_Control()
        {
            InitializeComponent();
            //ketnoi();
            //load_driver();

            //Custom hover buttonCT1
            buttonCT1.MouseEnter += OnMouseEnterButtonCT1;
            buttonCT1.MouseLeave += OnMouseLeaveButtonCT1;

            //Custom hover buttonCT2
            buttonCT2.MouseEnter += OnMouseEnterButtonCT2;
            buttonCT2.MouseLeave += OnMouseLeaveButtonCT2;

            //Custom hover buttonCT3
            buttonCT3.MouseEnter += OnMouseEnterButtonCT3;
            buttonCT3.MouseLeave += OnMouseLeaveButtonCT3;
        }

        // kết nối data base SQL
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

        // Lấy dữ liệu tài xế
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
                        guna2ComboBox6.Items.Add(reader.GetValue(1).ToString());
                        guna2ComboBox1.Items.Add(reader.GetValue(0).ToString());
                        guna2ComboBox7.Items.Add(reader.GetValue(2).ToString().Substring(0, 10));

                        guna2ComboBox5.Items.Add(reader.GetValue(1).ToString());
                        guna2ComboBox4.Items.Add(reader.GetValue(0).ToString());
                        guna2ComboBox8.Items.Add(reader.GetValue(2).ToString().Substring(0, 10));


                    }
                    reader.Dispose();
                }
            }
            conn.Close();
        }

        //Custom hover buttonCT1
        private void OnMouseEnterButtonCT1(object sender, EventArgs e)
        {
            buttonCT1.ForeColor = Color.White;
        }
        private void OnMouseLeaveButtonCT1(object sender, EventArgs e)
        {

        }

        //Custom hover buttonCT2
        private void OnMouseEnterButtonCT2(object sender, EventArgs e)
        {
            buttonCT3.ForeColor = Color.White;
        }
        private void OnMouseLeaveButtonCT2(object sender, EventArgs e)
        {

        }

        //Custom hover buttonCT3
        private void OnMouseEnterButtonCT3(object sender, EventArgs e)
        {
            buttonCT2.ForeColor = Color.White;
        }
        private void OnMouseLeaveButtonCT3(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxCT9.Text = row.Cells[0].Value.ToString();
                guna2ComboBox5.SelectedIndex = guna2ComboBox4.FindStringExact(row.Cells[2].Value.ToString());
                guna2ComboBox3.Text = row.Cells[3].Value.ToString();
                textBoxCT12.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxCT9.Text = row.Cells[0].Value.ToString();
                guna2ComboBox5.SelectedIndex = guna2ComboBox4.FindStringExact(row.Cells[2].Value.ToString());
                guna2ComboBox3.Text = row.Cells[3].Value.ToString();
                textBoxCT12.Text = row.Cells[4].Value.ToString();
            }
        }

        // SỮA
        private void buttonCT3_Click(object sender, EventArgs e)
        {
            String query = String.Format("Update Car Set Id_driver = {0}, State = '{1}', Desciption = N'{2}' where id_car = '{3}' ", guna2ComboBox4.Text, guna2ComboBox3.Text, textBoxCT12.Text, textBoxCT9.Text);
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
            ketnoi();
            MessageBox.Show("Chỉnh thành công");
        }

        // XÓA
        private void buttonCT2_Click(object sender, EventArgs e)
        {
            try
            {
                String query = String.Format("Delete from Car where Id_Car = '{0}'", textBoxCT9.Text);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công");
                ketnoi();
                load_driver();
                guna2ComboBox3.Text = "";
                guna2ComboBox6.Text = "";
            }
            catch 
            {
                MessageBox.Show("Không Thể Xóa Được");            
            }
        }

        // THÊM
        private void buttonCT1_Click(object sender, EventArgs e)
        {
            if (textBoxCT1.Text != "" & guna2ComboBox6.Text != "")
            {
                try
                {
                    String query = String.Format("Insert into Car (Id_car,Id_driver,State,Desciption) values ('{0}',{1},'{2}',N'{3}')", textBoxCT1.Text, guna2ComboBox1.Text, guna2ComboBox2.Text, textBoxCT2.Text);
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
                    MessageBox.Show("Lỗi ! ");
                }


            }
        }

        private void guna2ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2ComboBox1.SelectedIndex = guna2ComboBox6.SelectedIndex;
            guna2ComboBox7.SelectedIndex = guna2ComboBox6.SelectedIndex;
        }

        private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2ComboBox4.SelectedIndex = guna2ComboBox5.SelectedIndex;
            guna2ComboBox8.SelectedIndex = guna2ComboBox5.SelectedIndex;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxCT9.Text = row.Cells[0].Value.ToString();
                guna2ComboBox5.SelectedIndex = guna2ComboBox4.FindStringExact(row.Cells[2].Value.ToString());
                guna2ComboBox3.Text = row.Cells[3].Value.ToString();
                textBoxCT12.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
