namespace GymManagement
{
    partial class NewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMember));
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpNgayDangKi = new System.Windows.Forms.DateTimePicker();
            this.rtbDiaChi = new System.Windows.Forms.RichTextBox();
            this.cbbThoiGianTap = new System.Windows.Forms.ComboBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNgayDangki = new System.Windows.Forms.Label();
            this.lblThoiGianTap = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(239, 214);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(126, 22);
            this.txtHoTen.TabIndex = 0;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(239, 277);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 20);
            this.rdbNam.TabIndex = 2;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(320, 277);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
            this.rdbNu.TabIndex = 3;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(236, 332);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(129, 22);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(239, 393);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(126, 22);
            this.txtSDT.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(587, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // dtpNgayDangKi
            // 
            this.dtpNgayDangKi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDangKi.Location = new System.Drawing.Point(587, 272);
            this.dtpNgayDangKi.Name = "dtpNgayDangKi";
            this.dtpNgayDangKi.Size = new System.Drawing.Size(146, 22);
            this.dtpNgayDangKi.TabIndex = 7;
            // 
            // rtbDiaChi
            // 
            this.rtbDiaChi.Location = new System.Drawing.Point(587, 395);
            this.rtbDiaChi.Name = "rtbDiaChi";
            this.rtbDiaChi.Size = new System.Drawing.Size(132, 96);
            this.rtbDiaChi.TabIndex = 9;
            this.rtbDiaChi.Text = "";
            // 
            // cbbThoiGianTap
            // 
            this.cbbThoiGianTap.FormattingEnabled = true;
            this.cbbThoiGianTap.Items.AddRange(new object[] {
            "1 Tháng ",
            "2 Tháng ",
            "3 Tháng ",
            "6 Tháng ",
            "12 Tháng ",
            "15 Tháng"});
            this.cbbThoiGianTap.Location = new System.Drawing.Point(587, 329);
            this.cbbThoiGianTap.Name = "cbbThoiGianTap";
            this.cbbThoiGianTap.Size = new System.Drawing.Size(146, 24);
            this.cbbThoiGianTap.TabIndex = 10;
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Image = ((System.Drawing.Image)(resources.GetObject("lblHoTen.Image")));
            this.lblHoTen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHoTen.Location = new System.Drawing.Point(27, 203);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(189, 43);
            this.lblHoTen.TabIndex = 12;
            this.lblHoTen.Text = "Họ và tên ";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Image = ((System.Drawing.Image)(resources.GetObject("lblGioiTinh.Image")));
            this.lblGioiTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGioiTinh.Location = new System.Drawing.Point(41, 266);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(157, 37);
            this.lblGioiTinh.TabIndex = 14;
            this.lblGioiTinh.Text = "Giới tính";
            this.lblGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Image = ((System.Drawing.Image)(resources.GetObject("lblNgaySinh.Image")));
            this.lblNgaySinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNgaySinh.Location = new System.Drawing.Point(41, 320);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(169, 44);
            this.lblNgaySinh.TabIndex = 15;
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSDT
            // 
            this.lblSDT.BackColor = System.Drawing.Color.Transparent;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSDT.Image = ((System.Drawing.Image)(resources.GetObject("lblSDT.Image")));
            this.lblSDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSDT.Location = new System.Drawing.Point(41, 383);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(192, 40);
            this.lblSDT.TabIndex = 16;
            this.lblSDT.Text = "Số điện thoại";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Image = ((System.Drawing.Image)(resources.GetObject("lblEmail.Image")));
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Location = new System.Drawing.Point(389, 198);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(123, 52);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNgayDangki
            // 
            this.lblNgayDangki.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayDangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDangki.Image = ((System.Drawing.Image)(resources.GetObject("lblNgayDangki.Image")));
            this.lblNgayDangki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNgayDangki.Location = new System.Drawing.Point(390, 266);
            this.lblNgayDangki.Name = "lblNgayDangki";
            this.lblNgayDangki.Size = new System.Drawing.Size(181, 37);
            this.lblNgayDangki.TabIndex = 18;
            this.lblNgayDangki.Text = "Ngày đăng kí";
            this.lblNgayDangki.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblThoiGianTap
            // 
            this.lblThoiGianTap.BackColor = System.Drawing.Color.Transparent;
            this.lblThoiGianTap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianTap.Image = ((System.Drawing.Image)(resources.GetObject("lblThoiGianTap.Image")));
            this.lblThoiGianTap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblThoiGianTap.Location = new System.Drawing.Point(389, 325);
            this.lblThoiGianTap.Name = "lblThoiGianTap";
            this.lblThoiGianTap.Size = new System.Drawing.Size(182, 29);
            this.lblThoiGianTap.TabIndex = 19;
            this.lblThoiGianTap.Text = "Thời gian tập";
            this.lblThoiGianTap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Image = ((System.Drawing.Image)(resources.GetObject("lblDiaChi.Image")));
            this.lblDiaChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiaChi.Location = new System.Drawing.Point(390, 383);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(139, 45);
            this.lblDiaChi.TabIndex = 20;
            this.lblDiaChi.Text = "Địa chỉ";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.Silver;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(261, 526);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 39);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.BackColor = System.Drawing.Color.Silver;
            this.btnLamLai.Image = ((System.Drawing.Image)(resources.GetObject("btnLamLai.Image")));
            this.btnLamLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamLai.Location = new System.Drawing.Point(394, 526);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(101, 39);
            this.btnLamLai.TabIndex = 23;
            this.btnLamLai.Text = "&Làm lại";
            this.btnLamLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamLai.UseVisualStyleBackColor = false;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(218, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 44);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tập Gym Cùng Đạt";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 112);
            this.label1.TabIndex = 25;
            // 
            // NewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblThoiGianTap);
            this.Controls.Add(this.lblNgayDangki);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.cbbThoiGianTap);
            this.Controls.Add(this.rtbDiaChi);
            this.Controls.Add(this.dtpNgayDangKi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.txtHoTen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKi;
        private System.Windows.Forms.RichTextBox rtbDiaChi;
        private System.Windows.Forms.ComboBox cbbThoiGianTap;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNgayDangki;
        private System.Windows.Forms.Label lblThoiGianTap;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label label1;
    }
}