using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=Phuc-Thinkpad;Initial Catalog=QLKS;Persist Security Info=True;User ID=sa;Password=123456";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUserName.Text = "PhucBM";
            txtPassword.Text = "123456";
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userNm = txtUserName.Text;
                string pass = txtPassword.Text;
                if (string.IsNullOrEmpty(userNm) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!");
                    return;
                }
                conn.Open();
                string query = $"select * from [User] where UserName = '{userNm}' and Password = '{pass}'";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Đăng nhập thành công");
                    labelErr.Visible = false;
                    DashBoard ds = new DashBoard();
                    this.Hide();
                    ds.Show();
                }
                else
                {
                    labelErr.Visible = true;
                    txtPassword.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
                throw ex;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
