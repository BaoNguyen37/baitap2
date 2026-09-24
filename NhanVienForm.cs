namespace QuanLyNhanVien_WinForms
{
    public partial class NhanVienForm : Form
    {
        private readonly bool dangSua;

        public NhanVien? NhanVienKetQua { get; private set; }

        public NhanVienForm(NhanVien? nhanVien, string maNhanVien)
        {
            InitializeComponent();

            dangSua = nhanVien != null;
            txtMSNV.Text = maNhanVien;

            if (nhanVien != null)
            {
                Text = "Nhân viên - Sửa";
                txtTenNV.Text = nhanVien.TenNV;
                txtLuongCB.Text = nhanVien.LuongCB.ToString("0");
            }
            else
            {
                Text = "Nhân viên";
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string ma = txtMSNV.Text.Trim();
            string ten = txtTenNV.Text.Trim();

            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtLuongCB.Text.Trim(), out decimal luong) || luong < 0)
            {
                MessageBox.Show("Lương cơ bản phải là số không âm.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongCB.Focus();
                return;
            }

            NhanVienKetQua = new NhanVien
            {
                MSNV = ma,
                TenNV = ten,
                LuongCB = luong
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtLuongCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
