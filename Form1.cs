using System;
using System.Windows.Forms;

namespace DemoMyClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nhấn btnXuatThongTin: đọc dữ liệu đã nhập và hiển thị MessageBox
        private void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string gioiTinh = rbNam.Checked ? "Nam" : "Nữ";
            string ngaySinh = dtpNgaySinh.Value.ToString();

            string soThich = "";
            if (chkTheThao.Checked) soThich += ", Thể thao";
            if (chkPhimAnh.Checked) soThich += ", Phim ảnh";
            if (chkDuLich.Checked) soThich += ", Du lịch";

            string thongTin = "Họ tên:" + hoTen
                + ", Giới tính: " + gioiTinh
                + ", Ngày sinh: " + ngaySinh
                + ", Sở thích: " + soThich + ".";

            MessageBox.Show(thongTin, "Thông tin người dùng.");
        }
    }
}
