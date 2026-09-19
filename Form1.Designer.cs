namespace DemoMyClass
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.lblSoThich = new System.Windows.Forms.Label();
            this.chkTheThao = new System.Windows.Forms.CheckBox();
            this.chkPhimAnh = new System.Windows.Forms.CheckBox();
            this.chkDuLich = new System.Windows.Forms.CheckBox();
            this.btnXuatThongTin = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            //
            // grpThongTin
            //
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.lblGioiTinh);
            this.grpThongTin.Controls.Add(this.rbNam);
            this.grpThongTin.Controls.Add(this.rbNu);
            this.grpThongTin.Controls.Add(this.lblSoThich);
            this.grpThongTin.Controls.Add(this.chkTheThao);
            this.grpThongTin.Controls.Add(this.chkPhimAnh);
            this.grpThongTin.Controls.Add(this.chkDuLich);
            this.grpThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(660, 160);
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin";
            //
            // lblHoTen
            //
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 33);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(55, 20);
            this.lblHoTen.Text = "Họ tên";
            //
            // txtHoTen
            //
            this.txtHoTen.Location = new System.Drawing.Point(90, 30);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 27);
            //
            // lblNgaySinh
            //
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(300, 33);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 20);
            this.lblNgaySinh.Text = "ngày sinh";
            //
            // dtpNgaySinh
            //
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(380, 30);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(190, 27);
            //
            // lblGioiTinh
            //
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 78);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(70, 20);
            this.lblGioiTinh.Text = "Giới tính";
            //
            // rbNam
            //
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Location = new System.Drawing.Point(100, 76);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(60, 24);
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            //
            // rbNu
            //
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(180, 76);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(50, 24);
            this.rbNu.Text = "Nữ";
            //
            // lblSoThich
            //
            this.lblSoThich.AutoSize = true;
            this.lblSoThich.Location = new System.Drawing.Point(300, 78);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(70, 20);
            this.lblSoThich.Text = "Sở thích";
            //
            // chkTheThao
            //
            this.chkTheThao.AutoSize = true;
            this.chkTheThao.Location = new System.Drawing.Point(380, 76);
            this.chkTheThao.Name = "chkTheThao";
            this.chkTheThao.Size = new System.Drawing.Size(90, 24);
            this.chkTheThao.Text = "Thể thao";
            //
            // chkPhimAnh
            //
            this.chkPhimAnh.AutoSize = true;
            this.chkPhimAnh.Location = new System.Drawing.Point(480, 76);
            this.chkPhimAnh.Name = "chkPhimAnh";
            this.chkPhimAnh.Size = new System.Drawing.Size(85, 24);
            this.chkPhimAnh.Text = "Phim ảnh";
            //
            // chkDuLich
            //
            this.chkDuLich.AutoSize = true;
            this.chkDuLich.Location = new System.Drawing.Point(575, 76);
            this.chkDuLich.Name = "chkDuLich";
            this.chkDuLich.Size = new System.Drawing.Size(75, 24);
            this.chkDuLich.Text = "Du lịch";
            //
            // btnXuatThongTin
            //
            this.btnXuatThongTin.Location = new System.Drawing.Point(542, 185);
            this.btnXuatThongTin.Name = "btnXuatThongTin";
            this.btnXuatThongTin.Size = new System.Drawing.Size(130, 35);
            this.btnXuatThongTin.Text = "Xuất thông tin";
            this.btnXuatThongTin.UseVisualStyleBackColor = true;
            this.btnXuatThongTin.Click += new System.EventHandler(this.btnXuatThongTin_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 240);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnXuatThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo myclass";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Label lblSoThich;
        private System.Windows.Forms.CheckBox chkTheThao;
        private System.Windows.Forms.CheckBox chkPhimAnh;
        private System.Windows.Forms.CheckBox chkDuLich;
        private System.Windows.Forms.Button btnXuatThongTin;
    }
}
