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
        // đoạn mã được đặt form_Xe Nhằm lien ket giua form master va form Xe li du lieu
        public Form_Master CallerForm { get; set; }
        public Form_Main(Form_Master callerForm) : this()
        {
            this.CallerForm = callerForm;
        }
        public Form_Main()
        {
            InitializeComponent();
            ketnoi();
            
        }
        String ConectionString = infor.ConectionString;
        SqlConnection conn = new SqlConnection();
        public void ketnoi()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.Gray;
            dataGridView1.DefaultCellStyle = style;

            try
            {
                conn.ConnectionString = ConectionString;
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại");
            }
            String tatcacacxe = "select Id_car, Driver_Name, Car.State, Car.Desciption from Car left join Driver on Car.Id_driver = Driver.ID_driver";
            conn.Open();
            SqlCommand com = new SqlCommand(tatcacacxe, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView1.DataSource = dt;
            conn.Close();

            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily, 12);
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


        private void guna2Button2_Click(object sender, EventArgs e)
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

        // Button
        private void guna2Button1_Click(object sender, EventArgs e)
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

        // Button
        private void guna2Button3_Click(object sender, EventArgs e)
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
                txt_IDcar.Text = id;
                txt_TaiXe.Text = row.Cells[1].Value.ToString();
                string query = String.Format("select ID_action, ID_car,In_or_out, Time, Id_parkinglot from Action where ID_car = '{0}'  order by ID_action desc", id);
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

        public Image LoadImage(String base64)
        {

            //data:image/gif;base64,
            //this image is a single pixel (black)
            byte[] bytes = Convert.FromBase64String(base64);

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
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string id = row.Cells[0].Value.ToString();
                txt_IDcar.Text = id;
                txt_TaiXe.Text = row.Cells[1].Value.ToString();
                string query = String.Format("select ID_action, ID_car,In_or_out, Time, Id_parkinglot from Action where ID_car = '{0}' order by ID_action desc", id);
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
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                Image no = null;
                pictureBox1.Image = no;
                pictureBox2.Image = no;
                //MessageBox.Show(row.Cells[1].Value.ToString());
                string id = row.Cells[1].Value.ToString();
                string query = String.Format("select Image,Image2 from Action where ID_action = '{0}'", id);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                using (DbDataReader reader = com.ExecuteReader())
                {

                    if (reader.HasRows)
                    {

                        String img = "";
                        String img2 = "";
                        while (reader.Read())
                        {
                            img = reader.GetValue(0).ToString();
                            img2 = reader.GetValue(1).ToString();
                            //MessageBox.Show(img);
                        }
                        try
                        {
                            Image image = LoadImage(img);
                            image = resizeImage(image, new Size(256, 256));
                            pictureBox1.Image = image;
                            Image image2 = LoadImage(img2);
                            image2 = resizeImage(image2, new Size(256, 256));
                            pictureBox2.Image = image2;
                            //Console.WriteLine(img);
                        }
                        catch
                        {

                        }

                        reader.Dispose();
                    }
                }
                conn.Close();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                Image no = null;
                pictureBox1.Image = no;
                pictureBox2.Image = no;
                //MessageBox.Show(row.Cells[1].Value.ToString());
                string id = row.Cells[1].Value.ToString();
                string query = String.Format("select Image,Image2 from Action where ID_action = '{0}'", id);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                using (DbDataReader reader = com.ExecuteReader())
                {

                    if (reader.HasRows)
                    {

                        String img = "";
                        String img2 = "";
                        while (reader.Read())
                        {
                            img = reader.GetValue(0).ToString();
                            img2 = reader.GetValue(1).ToString();
                            //MessageBox.Show(img);
                        }
                        try
                        {
                            Image image = LoadImage(img);
                            image = resizeImage(image, new Size(256, 256));
                            pictureBox1.Image = image;
                            Image image2 = LoadImage(img2);
                            image2 = resizeImage(image2, new Size(256, 256));
                            pictureBox2.Image = image2;
                            //Console.WriteLine(img);
                        }
                        catch
                        {

                        }

                        reader.Dispose();
                    }
                }
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            /* String query = "Select max(ID_driver) from Driver";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            int id = 0;
            using (DbDataReader reader = com.ExecuteReader())
            {

                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {
                        id = unchecked((int)Convert.ToInt64(reader.GetValue(0)))+1;
                        MessageBox.Show(id.ToString());
                    }
                    reader.Dispose();
                }
                conn.Close();
            }
            */
            /*String query2 = String.Format("Insert into Driver(ID_driver, Driver_Name,Dateofbirth) values ((Select max(ID_driver) +1 from Driver), N'{0}','{1}')", textBox4.Text, dateTimePicker1.Value.ToString("yyyyMMdd"));
            conn.Open();
            SqlCommand com2 = new SqlCommand(query2, conn);
            com2.CommandType = CommandType.Text;
            com2.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            conn.Close();*/
        }

        private void quảnLíXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXe f = new FormXe();
            f.ShowDialog();
        }

        private void quảnLíTàiXếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Driver f = new Form_Driver();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = String.Format("select ID_action, ID_car,In_or_out, Time, Id_parkinglot from Action where ID_car not in(select Id_car from Car)  order by ID_action desc");
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        // Button
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string query = String.Format("select ID_action, ID_car,In_or_out, Time, Id_parkinglot from Action where ID_car not in(select Id_car from Car)  order by ID_action desc");
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = String.Format("select ID_action, ID_car,In_or_out, Time, Id_parkinglot from Action where ID_car not in(select Id_car from Car) and In_or_out = 'in'  order by ID_action desc");
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        // Button
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string query = String.Format("select ID_action, ID_car,In_or_out, Time, Id_parkinglot from Action where ID_car not in(select Id_car from Car) and In_or_out = 'in'  order by ID_action desc");
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string query = String.Format("select ID_action, ID_car,In_or_out, Time, Id_parkinglot from Action where ID_car not in(select Id_car from Car) and In_or_out = 'out'  order by ID_action desc");
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        // Button
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string query = String.Format("select ID_action, ID_car,In_or_out, Time, Id_parkinglot from Action where ID_car not in(select Id_car from Car) and In_or_out = 'out'  order by ID_action desc");
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            com.CommandType = CommandType.Text;
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           /* 
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WorkingDirectory = Application.StartupPath+@"\Detect_BienSo";
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C conda activate base && python main.py";
            process.StartInfo = startInfo;
            process.Start();
            MessageBox.Show("Khởi động thành công");
            button7.Enabled = false;
           */
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.White;
            style.BackColor = Color.FromArgb(0, 13, 66);
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle = style;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.ForeColor = Color.Gray;
            style1.BackColor = Color.White;
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle = style1;
            }
        }

        private void dataGridView2_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.White;
            style.BackColor = Color.FromArgb(0, 13, 66);
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


    }
}
