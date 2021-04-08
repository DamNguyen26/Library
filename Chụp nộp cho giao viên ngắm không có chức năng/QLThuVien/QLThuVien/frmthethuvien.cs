using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmthethuvien : Form
    {

        public frmthethuvien()
        {
        }
        private void frmthethuvien_Load(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            loaddllenfile();
            hientieudecot();
            hiensvdautien();
            data_bingding();
        }
        #region hiện thị mã thẻ
        private string taomathe()
        {
            string mapthe;
            Random r = new Random();
            mapthe = "NV" + r.Next(50, 999).ToString();
            return mapthe;
        }
        #endregion
        #region bingding
        private void data_bingding()
        {
            txtMa.DataBindings.Add("Text", dgvttttv.DataSource, "MaThe");
            txtTensv.DataBindings.Add("Text", dgvttttv.DataSource, "TenSV");
            txtdiachisv.DataBindings.Add("Text", dgvttttv.DataSource, "DiaChiSV");
            txtdt.DataBindings.Add("Text", dgvttttv.DataSource, "DienThoaiSV");
        }
        private void huy_bingding()
        {
            if (dtngaysinh.DataBindings != null)
                dtngaysinh.DataBindings.Clear();
            if (txtdt.DataBindings != null)
                txtdt.DataBindings.Clear();
            if (txtMa.DataBindings != null)
                txtMa.DataBindings.Clear();
            if (txtTensv.DataBindings != null)
                txtTensv.DataBindings.Clear();
            if (dtngaytao.DataBindings != null)
                dtngaytao.DataBindings.Clear();
            if (dtngayhethan.DataBindings != null)
                dtngayhethan.DataBindings.Clear();
            if (txtdiachisv.DataBindings != null)
                txtdiachisv.DataBindings.Clear();
            if (cboGioitinh.DataBindings != null)
                cboGioitinh.DataBindings.Clear();
        }
        #endregion
        #region tiêu đề cột
        private void hientieudecot()
        {
            dgvttttv.Columns[0].HeaderText = "Mã The";
            dgvttttv.Columns[1].HeaderText = "Tên SV";
            dgvttttv.Columns[2].HeaderText = "Giới Tính";
            dgvttttv.Columns[3].HeaderText = "Ngày Sinh";
            dgvttttv.Columns[4].HeaderText = "Địa Chỉ Sv";
            dgvttttv.Columns[5].HeaderText = "Điện Thoại";
            dgvttttv.Columns[6].HeaderText = "Ngày Tạo";
            dgvttttv.Columns[7].HeaderText = "Ngày Hết Hạn";
        }
        #endregion
        #region doc len file
        private void loaddllenfile()
        {
        }
        #endregion
        #region them thethuvien
        private void btnthemttv_Click_1(object sender, EventArgs e)
        {
            txtdt.Clear();
            txtMa.Clear();
            txtTensv.Clear();
            txtdiachisv.Clear();
            txtMa.Text = taomathe();
        }
        #endregion
        #region luu the thu vien
        private void luuthethuvien()
        {
        }
        private void btnluuttv_Click_1(object sender, EventArgs e)
        {
            huy_bingding();
            luuthethuvien();
            loaddllenfile();
            data_bingding();
        }
        #endregion
        #region  sua thethuvien
        private void suathethuvien()
        {
        }
        private void btnsuattv_Click_1(object sender, EventArgs e)
        {
            huy_bingding();
            suathethuvien();
            loaddllenfile();
            data_bingding();
        }
        #endregion
        #region xoathethuvien
        private void xoathethuvien()
        {
        }
        private void btnxoattv_Click(object sender, EventArgs e)
        {
            huy_bingding();
            xoathethuvien();
            loaddllenfile();
            data_bingding();
        }
        #endregion
        #region thoat the thu vien
        private void btnthoatttv_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn Thật Sự Muốn Thoát kg?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
        #region TTVdautien
        private void hiensvdautien()
        {
        }
        #endregion
        #region di lùi
        private void btnlui_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region di tới
        private void btntoi_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region di tới  cuối
        private void btncuoi_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region di đến đầu
        private void btndau_Click(object sender, EventArgs e)
        {
        }
        #endregion
        private void txtdt_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Không được nhập chữ";
            }
        }

        private void txtTensv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 45 && e.KeyChar < 57)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Không được nhập chữ";
            }
        }






    }
}
