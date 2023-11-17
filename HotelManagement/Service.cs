using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace HotelManagement
{
    public partial class Service : Form
    {
        string BookingID {  get; set; }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlDataReader dr;
        public Service(string BookingID)
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=Phuc-Thinkpad;Initial Catalog=QLKS;Persist Security Info=True;User ID=sa;Password=123456;MultipleActiveResultSets=true";
            this.BookingID = BookingID;
        }

        private void GetData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                Services service = new Services();
                string query = "Select ServiceID, ServiceName, Price from Services";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    listView1.Columns.Add(dr.GetName(i), 120);
                }
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    for (int i = 1; i < dr.FieldCount; i++)
                    {
                        item.SubItems.Add(dr[i].ToString());
                    }

                    listView1.Items.Add(item);
                }

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void LoadComboBox()
        {
            conn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM SERVICES", conn);
            da1.SelectCommand = cmd1;
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "SERVICES");
            comboBoxSrv.DataSource = ds1;
            comboBoxSrv.DisplayMember = "SERVICES.ServiceName";
            comboBoxSrv.ValueMember = "SERVICES.ServiceID";
            conn.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Service_Load(object sender, EventArgs e)
        {
            GetData();
            LoadComboBox();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string inputText = txtQuantity.Text;

            if (int.TryParse(inputText, out _))
            {
                int Quantity = Convert.ToInt32(inputText);
                double priceService = 0;
                conn.Open();
                string queryGetService = $"select * from Services where ServiceID = {comboBoxSrv.SelectedValue.ToString()}";
                cmd = new SqlCommand(queryGetService, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    priceService = Convert.ToDouble(dr["Price"]);
                }
                var totalCost = priceService * Quantity;
                string query = $"Insert into ServiceDetails(BookingID, ServiceID, Quantity, TotalCost) Values({BookingID}, {comboBoxSrv.SelectedValue.ToString()}, {txtQuantity.Text}, {totalCost} )";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                int result = cmd1.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thành công, Tổng dịch vụ là :" + totalCost);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số");
            }
            conn.Close();
        }
    }
}
