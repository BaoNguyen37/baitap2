using System.ComponentModel;

namespace QuanLyNhanVien_WinForms
{
    public partial class Form1 : Form
    {
        private readonly BindingList<NhanVien> danhSachNhanVien = new();

        public Form1()
        {
            InitializeComponent();

            // Dữ liệu mẫu giống đề bài
            danhSachNhanVien.Add(new NhanVien
            {
                MSNV = "NV001",
                TenNV = "Nguyễn Thị Thu Hiền",
                LuongCB = 8500000
            });

            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = danhSachNhanVien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMoi = TaoMaNhanVien();

            using var frm = new NhanVienForm(null, maMoi);
            if (frm.ShowDialog() == DialogResult.OK && frm.NhanVienKetQua != null)
            {
                danhSachNhanVien.Add(frm.NhanVienKetQua);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow?.DataBoundItem is not NhanVien nv)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var frm = new NhanVienForm(nv, nv.MSNV);
            if (frm.ShowDialog() == DialogResult.OK && frm.NhanVienKetQua != null)
            {
                nv.TenNV = frm.NhanVienKetQua.TenNV;
                nv.LuongCB = frm.NhanVienKetQua.LuongCB;

                dgvNhanVien.Refresh();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow?.DataBoundItem is not NhanVien nv)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa nhân viên {nv.TenNV} ({nv.MSNV}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                danhSachNhanVien.Remove(nv);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string TaoMaNhanVien()
        {
            int max = 0;

            foreach (var nv in danhSachNhanVien)
            {
                if (nv.MSNV.StartsWith("NV") &&
                    int.TryParse(nv.MSNV[2..], out int so) &&
                    so > max)
                {
                    max = so;
                }
            }

            return $"NV{max + 1:000}";
        }
    }
}
