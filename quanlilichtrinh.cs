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
    public partial class quanlilichtrinh : Form
    {
        public quanlilichtrinh()
        {
            InitializeComponent();
            ketnoi();
            comboBox1.Text = "0";
            comboBox2.Text = "0";
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
            String query = "select Id_car, Driver_Name, Desciption from Car inner join Driver on Car.ID_driver =  Driver.ID_driver ";
            conn.Open();
            SqlCommand com = new SqlCommand(query, conn);
            using (DbDataReader reader = com.ExecuteReader())
            {

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        comboBox4.Items.Add(reader.GetValue(0).ToString());
                        comboBox3.Items.Add(reader.GetValue(1).ToString());
                        comboBox5.Items.Add(reader.GetValue(2).ToString());
                    }
                    reader.Dispose();
                }
            }
            conn.Close();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quanlilichtrinh_Load(object sender, EventArgs e)
        {

        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime iDate = dateTimePicker1.Value;
            string strDate = iDate.ToString("yyyyMMdd");
            string time = comboBox1.Text + ":" + comboBox2.Text;
            string id_schedule = GetTimestamp(DateTime.Now);
            string id_car = comboBox4.Text;
            string description = textBox1.Text;
            string id_action = "";
            if(time!="" && id_car!="" && description!="")
            {
                String query = String.Format("Insert into schedule (id_schedule,ngay,time,id_car,description,id_action) values ('{0}','{1}','{2}','{3}',N'{4}','{5}')", id_schedule, strDate, time, id_car, description, id_action);
                conn.Open();
                Console.WriteLine(query);
                MessageBox.Show(query);
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("THem thanh cong");
            }    



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = comboBox3.SelectedIndex;
            comboBox5.SelectedIndex = comboBox3.SelectedIndex;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = comboBox4.SelectedIndex;
            comboBox5.SelectedIndex = comboBox4.SelectedIndex;
        }

        private void lichXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
