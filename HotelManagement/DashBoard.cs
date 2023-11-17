using Guna.UI2.WinForms.Suite;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagement
{
    public partial class DashBoard : Form
    {
        public string RoomId { get; set; }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlDataReader dr;
        public DashBoard()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=Phuc-Thinkpad;Initial Catalog=QLKS;Persist Security Info=True;User ID=sa;Password=123456";
        }

        public void RemoveData()
        {
            listView1.Clear();
        }
        public void GetData()
        {
            Rooms room = new Rooms();
            conn.Open();
            string query = "Select RoomID, RoomNumber, b.RoomTypeName RoomType, PricePerNight, Availability from Rooms a join RoomType b on a.RoomTypeID = b.RoomTypeID";
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                room.RoomID = dr["RoomID"].ToString();
                room.RoomNumber = (int)dr["RoomNumber"];
                room.RoomTypeName = dr["RoomType"].ToString();
                room.PricePerNight = Convert.ToDouble(dr["PricePerNight"]);
                room.Availability = (bool)dr["Availability"];


                ImageList imgLst = new ImageList()
                {
                    ImageSize = new Size(150, 150)
                };
                string appDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                string projectPath = "";
                if (appDirectory != null)
                {
                    projectPath = Path.GetDirectoryName(Path.GetDirectoryName(appDirectory));

                }
                string imagePath = Path.Combine(projectPath, "room-1.png");
                imgLst.Images.Add(Image.FromFile(imagePath));

                ListViewItem item = new ListViewItem
                {
                    Text = $"Phòng: {room.RoomNumber}",
                    Font = new Font("Arial", 14, FontStyle.Regular),
                    BackColor = room.Availability ? Color.Green : Color.Red,
                    ImageIndex = 0
                };

                item.SubItems.Add(room.RoomID);
                item.SubItems.Add($"Loại Phòng: {room.RoomTypeName}");
                item.SubItems.Add($"Giá: {room.PricePerNight}");
                item.SubItems.Add($"Trạng thái: {{room.Availability ? \"Trống\" : \"Đang sử dụng\"}}");

                listView1.LargeImageList = imgLst;
                listView1.Items.Add(item);

            }
            conn.Close();
        }

        private EventHandler BookingDetail(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked");
            throw new NotImplementedException();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void ReCallBooking(string bookingID)
        {
            Booking booking = new Booking(RoomId, bookingID,this);
            booking.Show();
        }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                RoomId = listView1.SelectedItems[0].SubItems[1].Text;
                conn.Open();
                string query = $"select BookingID from Bookings where RoomID = {RoomId}";
                cmd = new SqlCommand(query,conn);
                dr = cmd.ExecuteReader();
                string getID = "";
                if(dr.Read())
                {
                    getID = dr["BookingID"].ToString();
                }
                Booking booking = new Booking(RoomId, getID, this);
                booking.Show();
                conn.Close();
            }
        }
    }
}
