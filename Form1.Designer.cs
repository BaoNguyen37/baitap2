namespace QuanLyNhanVien_WinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvNhanVien;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnDong;
        private DataGridViewTextBoxColumn colMSNV;
        private DataGridViewTextBoxColumn colTenNV;
        private DataGridViewTextBoxColumn colLuongCB;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvNhanVien = new DataGridView();
            colMSNV = new DataGridViewTextBoxColumn();
            colTenNV = new DataGridViewTextBoxColumn();
            colLuongCB = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnDong = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();

            // dgvNhanVien
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AllowUserToResizeRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.FixedSingle;
            dgvNhanVien.ColumnHeadersHeight = 32;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] {
                colMSNV, colTenNV, colLuongCB
            });
            dgvNhanVien.Location = new Point(18, 18);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowTemplate.Height = 30;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(470, 365);
            dgvNhanVien.TabIndex = 0;

            // colMSNV
            colMSNV.DataPropertyName = "MSNV";
            colMSNV.HeaderText = "MSNV";
            colMSNV.FillWeight = 28;
            colMSNV.Name = "colMSNV";
            colMSNV.ReadOnly = true;

            // colTenNV
            colTenNV.DataPropertyName = "TenNV";
            colTenNV.HeaderText = "Tên NV";
            colTenNV.FillWeight = 48;
            colTenNV.Name = "colTenNV";
            colTenNV.ReadOnly = true;

            // colLuongCB
            colLuongCB.DataPropertyName = "LuongCB";
            colLuongCB.HeaderText = "Lương CB";
            colLuongCB.FillWeight = 38;
            colLuongCB.Name = "colLuongCB";
            colLuongCB.ReadOnly = true;
            colLuongCB.DefaultCellStyle.Format = "N0";

            // btnThem
            btnThem.Location = new Point(505, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 38);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // btnSua
            btnSua.Location = new Point(505, 75);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 38);
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;

            // btnXoa
            btnXoa.Location = new Point(505, 125);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 38);
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // btnDong
            btnDong.Location = new Point(505, 175);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(95, 38);
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 405);
            Controls.Add(btnDong);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvNhanVien);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List View - Quản lý nhân viên";

            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }
    }
}
