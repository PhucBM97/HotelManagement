using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Booking : Form
    {
        private DashBoard frmDash;
        private string RoomID { get; set; }
        private string BookingID { get; set; }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlDataReader dr;
        public Booking(string RoomID, string BookingID, DashBoard frmDash)
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=Phuc-Thinkpad;Initial Catalog=QLKS;Persist Security Info=True;User ID=sa;Password=123456";
            this.RoomID = RoomID;
            this.frmDash = frmDash;
            this.BookingID = BookingID;
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtCusID.Text) || string.IsNullOrEmpty(txtCusName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!");
                return false;
            }
            return true;
        }
        private void LoadData()
        {
            if (string.IsNullOrEmpty(txtBookingID.Text)) txtBookingID.Text = this.BookingID;
            bool isAvailable = true;
            conn.Open();
            string query = $"select a.RoomNumber, a.PricePerNight, b.RoomTypeName Roomtype, a.Availability from Rooms a join RoomType b on a.RoomTypeID = b.RoomTypeID where RoomID = {this.RoomID}";
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbRoomNumber.Text += dr["RoomNumber"];
                lbRoomType.Text += dr["RoomType"];
                lbPrice.Text += dr["PricePerNight"];
                isAvailable = (bool)dr["Availability"];
                
            }
            conn.Close();
            CheckAvailable(isAvailable);
            lbPrice.Font = new Font(Font, FontStyle.Bold);
            lbRoomNumber.Font = new Font(Font, FontStyle.Bold);
            lbRoomType.Font = new Font(Font, FontStyle.Bold);
            lbType.Font = new Font(Font, FontStyle.Bold);

        }
        private void CheckAvailable(bool isAvailable)
        {
            if (isAvailable)
            {
                txtCusID.Text = "";
                txtCusName.Text = "";
                inDate.Text = "";
                outDate.Text = "";
                btnCheckIn.Enabled = true;
                btnCheckout.Enabled = false;
                btnSrv.Enabled = false;
                btnPay.Enabled = false;
                
            }
            else
            {
                btnCheckIn.Enabled = false;
                btnCheckout.Enabled = true;
                btnSrv.Enabled = true;
                btnPay.Enabled = false;
                conn.Open();
                string query = $"select a.CustomerID, b.FullName CustomerName, a.CheckInDate, a.CheckOutDate from Bookings a join Customers b on a.CustomerID = b.CustomerID where RoomID = {RoomID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtCusID.Text = dr["CustomerID"].ToString();
                    txtCusName.Text = dr["CustomerName"].ToString();
                    inDate.Value = (DateTime)dr["CheckinDate"];
                    outDate.Value = (DateTime)dr["CheckoutDate"];
                }
                conn.Close();
            }
        }
        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            var price = Convert.ToDouble(lbPrice.Text);
            var day = (outDate.Value - inDate.Value).Days == 0 ? 1 : (outDate.Value - inDate.Value).Days;

            var totalCost = price * day;
            string queryUpdate = $"Update Bookings Set CheckOutDate = '{outDate.Value.ToString("yyyy-MM-dd")}', TotalCost = {totalCost} where RoomID = {RoomID}";
            SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn);
            int resultUpdate = cmdUpdate.ExecuteNonQuery();
            if (resultUpdate > 0)
            {
                string queryHis = $"Update BookingHistories Set CheckOutDate = '{outDate.Value.ToString("yyyy-MM-dd")}', TotalCost = {totalCost} where RoomID = {RoomID}";
                SqlCommand cmdHis = new SqlCommand(queryHis, conn);
                int resultHis = cmdHis.ExecuteNonQuery();
                if (resultHis > 0)
                {
                    MessageBox.Show("Checkout Thành công");
                            btnPay.Enabled = true;
                            string query = $"SELECT BookingID FROM Bookings where RoomID = {RoomID}";
                            cmd = new SqlCommand(query, conn);
                            dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                this.BookingID = dr["BookingID"].ToString();
                                txtBookingID.Text = this.BookingID;
                            }
                    
                }
            }
            conn.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }
            conn.Open();
            string query = $"Insert into Customers(CustomerID, FullName) Values('{txtCusID.Text}', N'{txtCusName.Text}')";
            cmd = new SqlCommand (query, conn);
            int resultCus = cmd.ExecuteNonQuery();
            
            if (resultCus > 0)
            {
                string dateIn = inDate.Value.ToString("yyyy-MM-dd");
                string dateOut = outDate.Value.ToString("yyyy-MM-dd");
                query = $"Insert into Bookings(CustomerID, RoomID, CheckinDate, CheckoutDate) values('{txtCusID.Text}', '{this.RoomID}', '{dateIn}', '{dateOut}')";

                cmd = new SqlCommand (query, conn);

                int resultBooking = cmd.ExecuteNonQuery();

                if (resultBooking > 0)
                {
                    query = $"Update Rooms Set Availability = 0 where RoomID = {this.RoomID}";
                    cmd = new SqlCommand (query, conn);
                    int resultRoom = cmd.ExecuteNonQuery();
                    
                    if (resultRoom > 0)
                    {
                        string queryHis = $"INSERT INTO BookingHistories(BookingHisID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalCost) SELECT BookingID, CustomerID, RoomID, CheckInDate, CheckOutDate, TotalCost FROM Bookings where RoomID = {RoomID}";
                        SqlCommand cmdHis = new SqlCommand(queryHis, conn);
                        int resultHis = cmdHis.ExecuteNonQuery();
                        if (resultHis > 0)
                        {
                            MessageBox.Show("Nhận phòng thành công");
                            query = $"SELECT BookingID FROM Bookings where RoomID = {RoomID}";
                            cmd = new SqlCommand(query, conn);
                            dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                this.BookingID = dr["BookingID"].ToString();
                                txtBookingID.Text = this.BookingID;
                            }
                            frmDash.RemoveData();
                            frmDash.GetData();
                            this.Close();
                            frmDash.ReCallBooking(BookingID);
                        }

                    }
                }

            }
        }

        private void txtSrv_Click(object sender, EventArgs e)
        {
            Service srv = new Service(this.BookingID);
            srv.Show();
        }

        private void txtPay_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay(BookingID, RoomID, this.frmDash);
            pay.Show();
        }

        private void outDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
