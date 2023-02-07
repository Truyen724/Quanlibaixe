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
using System.IO;

namespace Quanlibaixe
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            ketnoi();
            
        }
        String ConectionString = "server = DESKTOP-O41267U; database = Detect_bienso; integrated security = true";
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
            String tatcacacxe = "select Id_car, Driver_Name, Car.State from Car left join Driver on Car.Id_driver = Driver.ID_driver";
            conn.Open();
            SqlCommand com = new SqlCommand(tatcacacxe, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void thêmXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String tatcacacxe = "select Id_car, Driver_Name, Car.State from Car left join Driver on Car.Id_driver = Driver.ID_driver where Car.State = 'in'";
            conn.Open();
            SqlCommand com = new SqlCommand(tatcacacxe, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);

            da.Fill(dt);

            com.CommandType = CommandType.Text;
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String tatcacacxe = "select Id_car, Driver_Name, Car.State from Car left join Driver on Car.Id_driver = Driver.ID_driver";
            conn.Open();
            SqlCommand com = new SqlCommand(tatcacacxe, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);

            da.Fill(dt);

            com.CommandType = CommandType.Text;
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String tatcacacxe = "select Id_car, Driver_Name, Car.State from Car left join Driver on Car.Id_driver = Driver.ID_driver where Car.State = 'out'";
            conn.Open();
            SqlCommand com = new SqlCommand(tatcacacxe, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView1.DataSource = dt;
            conn.Close();
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                
                string id = row.Cells[0].Value.ToString();
                textBox1.Text = id;
                textBox2.Text = row.Cells[1].Value.ToString();
                string query = String.Format("select ID_action, ID_car,In_or_out, Time, Id_parkinglot from Action where ID_car = '{0}'", id);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                com.CommandType = CommandType.Text;
                dataGridView2.DataSource = dt;
                conn.Close();
                
            }    
        }
        public Image LoadImage()
        {
            //data:image/gif;base64,
            //this image is a single pixel (black)
            byte[] bytes = Convert.FromBase64String("R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==");

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = System.Drawing.Image.FromStream(ms);
            }

            return image;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                
                string id = row.Cells[0].Value.ToString();
                string query = String.Format("select ID_action, ID_car,In_or_out, Time, Id_parkinglot from Action where ID_car = '{0}'", id);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                com.CommandType = CommandType.Text;
                dataGridView2.DataSource = dt;
                conn.Close();
                */

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                MessageBox.Show(row.Cells[2].Value.ToString());
            }    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
