namespace HotelManagement
{
    partial class Booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRoomNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.txtCusName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCusID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbRoomType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.inDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.outDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSrv = new Guna.UI2.WinForms.Guna2Button();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.txtBookingID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRoomNumber
            // 
            this.lbRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbRoomNumber.Location = new System.Drawing.Point(72, 12);
            this.lbRoomNumber.Name = "lbRoomNumber";
            this.lbRoomNumber.Size = new System.Drawing.Size(3, 2);
            this.lbRoomNumber.TabIndex = 0;
            this.lbRoomNumber.Text = null;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(72, 271);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = null;
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // lbType
            // 
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Location = new System.Drawing.Point(690, 12);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(3, 2);
            this.lbType.TabIndex = 3;
            this.lbType.Text = null;
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Location = new System.Drawing.Point(489, 12);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(3, 2);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = null;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(286, 320);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(180, 45);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Nhận phòng";
            this.btnCheckIn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(72, 320);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(180, 45);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // txtCusName
            // 
            this.txtCusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusName.DefaultText = "";
            this.txtCusName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Location = new System.Drawing.Point(235, 72);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.PasswordChar = '\0';
            this.txtCusName.PlaceholderText = "";
            this.txtCusName.SelectedText = "";
            this.txtCusName.Size = new System.Drawing.Size(491, 32);
            this.txtCusName.TabIndex = 10;
            // 
            // txtCusID
            // 
            this.txtCusID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusID.DefaultText = "";
            this.txtCusID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusID.Location = new System.Drawing.Point(235, 121);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.PasswordChar = '\0';
            this.txtCusID.PlaceholderText = "";
            this.txtCusID.SelectedText = "";
            this.txtCusID.Size = new System.Drawing.Size(491, 32);
            this.txtCusID.TabIndex = 16;
            // 
            // lbRoomType
            // 
            this.lbRoomType.BackColor = System.Drawing.Color.Transparent;
            this.lbRoomType.Location = new System.Drawing.Point(286, 12);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(3, 2);
            this.lbRoomType.TabIndex = 17;
            this.lbRoomType.Text = null;
            // 
            // inDate
            // 
            this.inDate.Checked = true;
            this.inDate.CustomFormat = "dd/MM/yyyy";
            this.inDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inDate.Location = new System.Drawing.Point(234, 177);
            this.inDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.inDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.inDate.Name = "inDate";
            this.inDate.Size = new System.Drawing.Size(200, 36);
            this.inDate.TabIndex = 18;
            this.inDate.Value = new System.DateTime(2023, 11, 16, 13, 57, 35, 983);
            // 
            // outDate
            // 
            this.outDate.Checked = true;
            this.outDate.CustomFormat = "dd/MM/yyyy";
            this.outDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.outDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.outDate.Location = new System.Drawing.Point(234, 239);
            this.outDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.outDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.outDate.Name = "outDate";
            this.outDate.Size = new System.Drawing.Size(200, 36);
            this.outDate.TabIndex = 19;
            this.outDate.Value = new System.DateTime(2023, 11, 16, 12, 20, 17, 995);
            this.outDate.ValueChanged += new System.EventHandler(this.outDate_ValueChanged);
            // 
            // btnSrv
            // 
            this.btnSrv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSrv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSrv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSrv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSrv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSrv.ForeColor = System.Drawing.Color.White;
            this.btnSrv.Location = new System.Drawing.Point(498, 177);
            this.btnSrv.Name = "btnSrv";
            this.btnSrv.Size = new System.Drawing.Size(180, 45);
            this.btnSrv.TabIndex = 23;
            this.btnSrv.Text = "Dịch vụ";
            this.btnSrv.Click += new System.EventHandler(this.txtSrv_Click);
            // 
            // btnPay
            // 
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(498, 320);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(180, 45);
            this.btnPay.TabIndex = 24;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.txtPay_Click);
            // 
            // txtBookingID
            // 
            this.txtBookingID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingID.DefaultText = "";
            this.txtBookingID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookingID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookingID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookingID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingID.Location = new System.Drawing.Point(727, 12);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.PasswordChar = '\0';
            this.txtBookingID.PlaceholderText = "";
            this.txtBookingID.SelectedText = "";
            this.txtBookingID.Size = new System.Drawing.Size(60, 50);
            this.txtBookingID.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Loại Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày Ra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ngày Vào";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "CMND/CCCD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tên Khách Hàng";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnSrv);
            this.Controls.Add(this.outDate);
            this.Controls.Add(this.inDate);
            this.Controls.Add(this.lbRoomType);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lbRoomNumber);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbRoomNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPrice;
        private Guna.UI2.WinForms.Guna2Button btnCheckIn;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2TextBox txtCusName;
        private Guna.UI2.WinForms.Guna2TextBox txtCusID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbRoomType;
        private Guna.UI2.WinForms.Guna2DateTimePicker inDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker outDate;
        private Guna.UI2.WinForms.Guna2Button btnSrv;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}