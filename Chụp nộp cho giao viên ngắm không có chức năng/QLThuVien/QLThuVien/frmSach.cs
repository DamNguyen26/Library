using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmSach : Form
    {
        private void Sach_Load(object sender, EventArgs e)
        {
            //Download source code mien phi tai Sharecode.vn
            txtMasach.Enabled = false;
            loaddlsach();
            hiensachdautien();
            tieudecotsach();
            lbltieude.Text = "";
            data_bingding();
        }
        #region chạy chữ
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        #endregion
        #region load len luoi
        private void loaddlsach()
        {

        }
        #endregion
        #region xử lý bingding
        private void data_bingding()
        {
            txtMasach.DataBindings.Add("Text", dgvttsach.DataSource, "MaSach");
            txtTensach.DataBindings.Add("Text", dgvttsach.DataSource, "TenSach");
            txttheloaisach.DataBindings.Add("Text", dgvttsach.DataSource, "TheLoai");
            txttinhtrang.DataBindings.Add("Text", dgvttsach.DataSource, "TinhTrang");
            txtsoluong.DataBindings.Add("Text", dgvttsach.DataSource, "SoLuong");
            txtnxb.DataBindings.Add("Text", dgvttsach.DataSource, "NXB");
            txtnamxb.DataBindings.Add("Text", dgvttsach.DataSource, "NamXB");
            txttg.DataBindings.Add("Text", dgvttsach.DataSource, "TG");
            PICHINH.DataBindings.Add("Image", dgvttsach.DataSource, "HINH", true);
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
            dgvttsach.Columns[0].HeaderText = "Mã Sách";
            dgvttsach.Columns[1].HeaderText = "Tên Sách";
            dgvttsach.Columns[2].HeaderText = "Thể Loại";
            dgvttsach.Columns[3].HeaderText = "Tình Trạng";
            dgvttsach.Columns[4].HeaderText = "Số Lượng";
            dgvttsach.Columns[5].HeaderText = "Mã NXB";
            dgvttsach.Columns[6].HeaderText = "Năm NXB";
            dgvttsach.Columns[7].HeaderText = "Mã TG";
            dgvttsach.Columns[8].HeaderText = "Hình";
        }
        #endregion
        #region masach
        private string taomasach()
        {
            string masach;
            Random r = new Random();
            masach = "MS" + r.Next(50, 999).ToString();
            return masach;
        }
        #endregion
        #region Thêm
        private void btnthemsach_Click(object sender, EventArgs e)
        {
            txtMasach.Clear();
            txtTensach.Clear();
            txtsoluong.Clear();
            txttinhtrang.Clear();
            txttheloaisach.Clear();
            txtnamxb.Clear();
            txtnxb.Clear();
            txttg.Clear();
            txtMasach.Text = taomasach();
        }
        #endregion
        #region luu sach
        private void luusach()
        {
        }

        private void btnluusach_Click(object sender, EventArgs e)
        {
            huy_bingding();
            luusach();
            loaddlsach();
            data_bingding();
        }
        #endregion
        #region Xóa sach
        private void xoasach()
        {
        }
        private void btnxoasach_Click(object sender, EventArgs e)
        {
            huy_bingding();
            xoasach();
            loaddlsach();
            data_bingding();
        }
        #endregion        
        #region sua sach
        private void Suasach()
        {

        }
        private void btnsuasach_Click(object sender, EventArgs e)
        {
            huy_bingding();
            Suasach();
            loaddlsach();
            data_bingding();
        }
        #endregion
        #region thoát sách
        private void btnthoatsach_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn Thật Sự Muốn Thoát kg?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
        #region lay hình
        private void BTNHINH_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region sachdautien
        private void hiensachdautien()
        {

        }
        #endregion
        #region dau
        private void btndau_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region lui
        private void btnlui_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region toi
        private void btntoi_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region cuoi
        private void btncuoi_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region bat loi chu
        private void txtsoluong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Không được nhập chữ";
            }
        }
        private void txtnamxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Không được nhập chữ";
            }
        }
        #endregion

        private void btntimkiemttv_Click(object sender, EventArgs e)
        {

        }
        private void txtnamxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
