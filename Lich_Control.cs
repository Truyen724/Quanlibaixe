using Guna.UI2.WinForms;
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
    public partial class Lich_Control : UserControl
    {
        String ConectionString = "server = DESKTOP-O41267U; database = Detect_bienso; integrated security = true";
        SqlConnection conn = new SqlConnection();
        public Lich_Control()
        {
            InitializeComponent();
            //ketnoi();
            guna2ComboBox1.Text = "0";
            guna2ComboBox3.Text = "0";

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

        //
        private void ketnoi()
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
                        guna2ComboBox4.Items.Add(reader.GetValue(0).ToString());
                        guna2ComboBox2.Items.Add(reader.GetValue(1).ToString());
                        guna2ComboBox5.Items.Add(reader.GetValue(2).ToString());
                    }
                    reader.Dispose();
                }
            }
            conn.Close();


        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
        private void buttonCT3_Click(object sender, EventArgs e)
        {
            DateTime iDate = guna2DateTimePicker1.Value;
            string strDate = iDate.ToString("yyyyMMdd");
            string time = guna2ComboBox1.Text + ":" + guna2ComboBox3.Text;
            string id_schedule = GetTimestamp(DateTime.Now);
            string id_car = guna2ComboBox4.Text;
            string description = textBoxCT2.Text;
            string id_action = "";
            if (time != "" && id_car != "" && description != "")
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

        private void buttonCT1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCT2_Click(object sender, EventArgs e)
        {
            
        }
        //
        private void OnMouseEnterButtonCT1(object sender, EventArgs e)
        {
            buttonCT1.ForeColor = Color.White;
        }
        private void OnMouseLeaveButtonCT1(object sender, EventArgs e)
        {

        }

        //
        private void OnMouseEnterButtonCT2(object sender, EventArgs e)
        {
            buttonCT2.ForeColor = Color.White;
        }
        private void OnMouseLeaveButtonCT2(object sender, EventArgs e)
        {

        }

        //
        private void OnMouseEnterButtonCT3(object sender, EventArgs e)
        {
            buttonCT3.ForeColor = Color.White;
        }
        private void OnMouseLeaveButtonCT3(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2ComboBox4.SelectedIndex = guna2ComboBox2.SelectedIndex;
            guna2ComboBox5.SelectedIndex = guna2ComboBox2.SelectedIndex;
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2ComboBox2.SelectedIndex = guna2ComboBox3.SelectedIndex;
            guna2ComboBox5.SelectedIndex = guna2ComboBox3.SelectedIndex;
        }
    }
}
