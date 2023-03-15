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
    public partial class Form_Driver : Form
    {
        public Form_Driver()
        {
            InitializeComponent();
            ketnoi();
            load_driver();
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
            try
            {
                day = Int32.Parse(x[0]);
                month = Int32.Parse(x[1]);
                year = Int32.Parse(x[2]);
            }
            catch (FormatException)
            {

            }
            finally
            {
                dateTimePicker2.Value = new DateTime(year, month, day);
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
            if(textBox1.Text != "")
            {
                String query2 = String.Format("Insert into Driver(ID_driver, Driver_Name,Dateofbirth) values ((Select max(ID_driver) +1 from Driver), N'{0}','{1}')", textBox1.Text, dateTimePicker1.Value.ToString("yyyyMMdd"));
                conn.Open();
                SqlCommand com2 = new SqlCommand(query2, conn);
                com2.CommandType = CommandType.Text;
                com2.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                conn.Close();
                load_driver();
            }    
        }

        private void Form_Driver_Load(object sender, EventArgs e)
        {

        }
    }
}
