using System;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmtimkiemsach : Form
    {

        public frmtimkiemsach()
        {
        }
        private void frmtimkiemsach_Load(object sender, EventArgs e)
        {
        }
        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
        }
        #region load len luoi
        private void loaddlsach()
        {

        }
        #endregion
        #region xử lý bingding
        private void data_bingding()
        {
            txtMasach.DataBindings.Add("Text", dgvthongtin.DataSource, "MaSach");
            txtTensach.DataBindings.Add("Text", dgvthongtin.DataSource, "TenSach");
            txttheloaisach.DataBindings.Add("Text", dgvthongtin.DataSource, "TheLoai");
            txttinhtrang.DataBindings.Add("Text", dgvthongtin.DataSource, "TinhTrang");
            txtsoluong.DataBindings.Add("Text", dgvthongtin.DataSource, "SoLuong");
            txtnxb.DataBindings.Add("Text", dgvthongtin.DataSource, "NXB");
            txtnamxb.DataBindings.Add("Text", dgvthongtin.DataSource, "NamXB");
            txttg.DataBindings.Add("Text", dgvthongtin.DataSource, "TG");
            PICHINH.DataBindings.Add("Image", dgvthongtin.DataSource, "Hinh", true);
        }
        private void huy_bingding()
        {
            if (txtMasach.DataBindings != null)
                txtMasach.DataBindings.Clear();
            if (txtTensach.DataBindings != null)
                txtTensach.DataBindings.Clear();
            if (txttheloaisach.DataBindings != null)
                txttheloaisach.DataBindings.Clear();
            if (txttinhtrang.DataBindings != null)
                txttinhtrang.DataBindings.Clear();
            if (txtsoluong.DataBindings != null)
                txtsoluong.DataBindings.Clear();
            if (txtnxb.DataBindings != null)
                txtnxb.DataBindings.Clear();
            if (txtnamxb.DataBindings != null)
                txtnamxb.DataBindings.Clear();
            if (txttg.DataBindings != null)
                txttg.DataBindings.Clear();
            if (PICHINH.DataBindings != null)
                PICHINH.DataBindings.Clear();
        }
        private void tieudecotsach()
        {
            dgvthongtin.Columns[0].HeaderText = "Mã Sách";
            dgvthongtin.Columns[1].HeaderText = "Tên Sách";
            dgvthongtin.Columns[2].HeaderText = "Thể Loại";
            dgvthongtin.Columns[3].HeaderText = "Tình Trạng";
            dgvthongtin.Columns[4].HeaderText = "Số Lượng";
            dgvthongtin.Columns[5].HeaderText = "Mã NXB";
            dgvthongtin.Columns[6].HeaderText = "Năm NXB";
            dgvthongtin.Columns[7].HeaderText = "Mã TG";
            dgvthongtin.Columns[8].HeaderText = "Hình";
        }
        #endregion
        #region Lấy hình
        private void BTNHINH_Click(object sender, EventArgs e)
        {
            PICHINH.SizeMode = PictureBoxSizeMode.Zoom;
        }
        #endregion

    }
}
