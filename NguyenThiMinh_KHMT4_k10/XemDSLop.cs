using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThiMinh_KHMT4_k10
{
    public partial class XemDSLop : Form
    {
        public XemDSLop()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings
             ["KETNOIQLHS"].ToString());
        LopBUL myLopBUL = new LopBUL();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void XemDSLop_Load(object sender, EventArgs e)
        {
            cbXemLop.DataSource = myLopBUL.LayDsLop();
            cbXemLop.DisplayMember = "TenLop";
            cbXemLop.ValueMember = "TenLop";
            dataGridView1.DataSource = myLopBUL.LayDsLop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox1.Text)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select MaLop,TenLop,NienKhoa,SiSo,GiaoVienChuNhiem from Lop where  MaLop like '" + textBox1.Text + "%' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
                dataGridView1.DataSource = myLopBUL.LayDsLop();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbXemLop.Text == (string)cbXemLop.SelectedValue)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select  MaLop,TenLop,NienKhoa,SiSo,GiaoVienChuNhiem from Lop where  TenLop like '" + cbXemLop.Text + "%' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
                dataGridView1.DataSource = myLopBUL.LayDsLop();
            conn.Close();
        }
    }
}
