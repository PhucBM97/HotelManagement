using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement
{
    public partial class Pay : Form
    {
        private DashBoard _dashBoard;
        public string BookingID { get; set; }
        public string RoomID { get; set; }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlDataReader dr;
        public Pay(string BookingID, string roomID, DashBoard dashBoard)
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=Phuc-Thinkpad;Initial Catalog=QLKS;Persist Security Info=True;User ID=sa;Password=123456;MultipleActiveResultSets=true";
            this.BookingID = BookingID;
            RoomID = roomID;
            _dashBoard = dashBoard;
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private string Display_Current(double value)
        {
            string formatCrr = value.ToString("C", new CultureInfo("vi-VN"));
            return formatCrr;
        }
        private void Pay_Load(object sender, EventArgs e)
        {
            bool hasRow = this.LoadListView();
            this.LoadData(hasRow);
        }
        private bool LoadListView()
        {
            conn.Open();
            string query = $"select a.ServiceName, a.Price, b.Quantity, b.TotalCost from Services a join ServiceDetails b on a.ServiceID = b.ServiceID where BookingID = {BookingID}";
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    listViewService.Columns.Add(dr.GetName(i), 120);
                }
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    for (int i = 1; i < dr.FieldCount; i++)
                    {
                        item.SubItems.Add(dr[i].ToString());
                    }

                    listViewService.Items.Add(item);
                }
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
            
        }
        private void LoadData(bool hasServices)
        {
            string query = "";
            conn.Open();
            if (hasServices)
            {
                query = $"\r\nselect d.CustomerID, d.FullName, a.CheckInDate, a.CheckOutDate, \r\nISNULL(a.TotalCost,0) RoomCost, ISNULL(SUM(b.TotalCost), 0) ServiceCost, \r\n(ISNULL(a.TotalCost,0) + ISNULL(SUM(b.TotalCost), 0)) TotalPay \r\nfrom Bookings a join ServiceDetails b on a.BookingID = b.BookingID \r\njoin Services c on b.ServiceID = c.ServiceID \r\njoin Customers d on a.CustomerID = d.CustomerID \r\nwhere a.BookingID = {BookingID}\r\ngroup by  d.CustomerID, d.FullName, a.CheckInDate, a.CheckOutDate, a.TotalCost";
            }
            else
            {
                query = $"select d.CustomerID, d.FullName, a.CheckInDate, a.CheckOutDate, ISNULL(a.TotalCost,0) RoomCost, ISNULL(a.TotalCost,0) TotalPay from BookingHistories a join Customers d on a.CustomerID = d.CustomerID where a.BookingHisID = {BookingID}";
            }
            
            cmd = new SqlCommand(query, conn);
            dr =  cmd.ExecuteReader();
            if (dr.Read())
            {
                txtCusId.Text = dr["CustomerID"].ToString();
                txtCusName.Text = dr["FullName"].ToString();
                PickerDateIN.Value = (DateTime)dr["CheckInDate"];
                PickerDateOUT.Value = (DateTime)dr["CheckOutDate"];
                txtRoomCost.Text = Display_Current(Convert.ToDouble(dr["RoomCost"]));
                txtTotalCost.Text = Display_Current(Convert.ToDouble(dr["TotalPay"]));
                if (hasServices)
                {
                    txtServiceCost.Text = Display_Current(Convert.ToDouble(dr["ServiceCost"]));
                }
            }
            conn.Close();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryDel = $"DELETE FROM Bookings Where BookingID = {BookingID}";
            SqlCommand cmdDel = new SqlCommand(queryDel, conn);
            int resultDel = cmdDel.ExecuteNonQuery();
            if (resultDel > 0)
            {
                string queryAvailable = $"UPDATE Rooms SET Availability = 1 Where RoomID = {RoomID}";
                SqlCommand cmdAvailable = new SqlCommand(queryAvailable, conn);
                int resultAvailable = cmdAvailable.ExecuteNonQuery();
                if (resultAvailable > 0)
                {
                    MessageBox.Show("Thanh toán thành công !!!");
                    this._dashBoard.RemoveData();
                    this._dashBoard.GetData();
                }
            }

            conn.Close();
        }

        private void listViewService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
