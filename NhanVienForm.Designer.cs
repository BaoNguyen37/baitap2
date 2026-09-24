namespace QuanLyNhanVien_WinForms
{
    partial class NhanVienForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMSNV;
        private Label lblTenNV;
        private Label lblLuongCB;
        private TextBox txtMSNV;
        private TextBox txtTenNV;
        private TextBox txtLuongCB;
        private Button btnDongY;
        private Button btnBoQua;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMSNV = new Label();
            lblTenNV = new Label();
            lblLuongCB = new Label();
            txtMSNV = new TextBox();
            txtTenNV = new TextBox();
            txtLuongCB = new TextBox();
            btnDongY = new Button();
            btnBoQua = new Button();
            SuspendLayout();

            // lblMSNV
            lblMSNV.AutoSize = true;
            lblMSNV.Location = new Point(22, 24);
            lblMSNV.Name = "lblMSNV";
            lblMSNV.Size = new Size(44, 15);
            lblMSNV.Text = "MSNV:";

            // txtMSNV
            txtMSNV.Location = new Point(95, 20);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.ReadOnly = true;
            txtMSNV.Size = new Size(150, 23);
            txtMSNV.TabIndex = 0;

            // lblTenNV
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(22, 61);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(67, 15);
            lblTenNV.Text = "Tên nhân viên:";

            // txtTenNV
            txtTenNV.Location = new Point(95, 57);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(250, 23);
            txtTenNV.TabIndex = 1;

            // lblLuongCB
            lblLuongCB.AutoSize = true;
            lblLuongCB.Location = new Point(22, 98);
            lblLuongCB.Name = "lblLuongCB";
            lblLuongCB.Size = new Size(69, 15);
            lblLuongCB.Text = "Lương cơ bản:";

            // txtLuongCB
            txtLuongCB.Location = new Point(95, 94);
            txtLuongCB.Name = "txtLuongCB";
            txtLuongCB.Size = new Size(150, 23);
            txtLuongCB.TabIndex = 2;
            txtLuongCB.KeyPress += txtLuongCB_KeyPress;

            // btnDongY
            btnDongY.Location = new Point(95, 135);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(75, 30);
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;

            // btnBoQua
            btnBoQua.Location = new Point(205, 135);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(75, 30);
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;

            // NhanVienForm
            AcceptButton = btnDongY;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBoQua;
            ClientSize = new Size(380, 190);
            Controls.Add(btnBoQua);
            Controls.Add(btnDongY);
            Controls.Add(txtLuongCB);
            Controls.Add(lblLuongCB);
            Controls.Add(txtTenNV);
            Controls.Add(lblTenNV);
            Controls.Add(txtMSNV);
            Controls.Add(lblMSNV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NhanVienForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhân viên";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
