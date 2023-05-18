using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlibaixe;
using System.Data.SqlClient;
using System.Data.Common;
namespace Quanlibaixe
{
    public partial class Form_Action : Form
    {
        public string id_xe;
        public string id_action;
        public Form_Action()
        {
            InitializeComponent();
        }
        public Form_Action(string id_xe)
        {
            InitializeComponent();
            this.id_xe = id_xe;
        }
        public Form_Action(string id_xe, string id_action)
        {
            InitializeComponent();
            this.id_xe = id_xe;
            this.id_action = id_action;
        }
        String ConectionString = infor.ConectionString;
        SqlConnection conn = new SqlConnection();
        private void Form_Action_Load(object sender, EventArgs e)
        {

            ketnoi();
        }

        public void ketnoi()
        {
            txt_IDxe.Text = id_xe;
            try
            {
                conn.ConnectionString = ConectionString;
                String query = String.Format("select id_schedule, ngay, time , id_car,description, id_action from schedule where id_car='{0}' order by id_schedule DESC ", this.id_xe);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                com.CommandType = CommandType.Text;
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string update = string.Format("Delete from schedule where id_schedule ='{0}'", id_action);
            conn.Open();
            SqlCommand com = new SqlCommand(update, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Không thực hiện thành công");
            
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Unaccep_Click(object sender, EventArgs e)
        {
            string update = string.Format("Delete from schedule where id_schedule ='{0}'", id_action);
            conn.Open();
            SqlCommand com = new SqlCommand(update, conn);
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Không thực hiện thành công");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
