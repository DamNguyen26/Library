using System;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmPhieuNhacTra : Form
    {


        public frmPhieuNhacTra()
        {


        }

        private void PhieuNhacTra_Load(object sender, EventArgs e)
        {


        }
        #region hiện thị mã pnt
        private string taomapnt()
        {
            string mapnt;
            Random r = new Random();
            mapnt = "NV" + r.Next(50, 999).ToString();
            return mapnt;
        }
        #endregion
        #region bingding
        private void data_bingding()
        {
            txtmapnt.DataBindings.Add("Text", dgvttpnt.DataSource, "MaPNT");
            cbomanv.DataBindings.Add("Selectedvalue", dgvttpnt.DataSource, "MaNV");
            cbomasach.DataBindings.Add("Selectedvalue", dgvttpnt.DataSource, "MaSach");
            cbomathe.DataBindings.Add("Selectedvalue", dgvttpnt.DataSource, "MaThe");
            txtdgp.DataBindings.Add("Text", dgvttpnt.DataSource, "DonGiaPhat");
            txtghichu.DataBindings.Add("Text", dgvttpnt.DataSource, "GhiChu");
        }
        private void huy_bingding()
        {
            if (txtmapnt.DataBindings != null)
                txtmapnt.DataBindings.Clear();
            if (txtghichu.DataBindings != null)
                txtghichu.DataBindings.Clear();
            if (dtngaplap.DataBindings != null)
                dtngaplap.DataBindings.Clear();
            if (txtdgp.DataBindings != null)
                txtdgp.DataBindings.Clear();
            if (cbomasach.DataBindings != null)
                cbomasach.DataBindings.Clear();
            if (cbomanv.DataBindings != null)
                cbomanv.DataBindings.Clear();
            if (cbomathe.DataBindings != null)
                cbomathe.DataBindings.Clear();
        }
        #endregion
        #region tiêu đề cột
        private void hientieudecot()
        {
            dgvttpnt.Columns[0].HeaderText = "Mã PNT";
            dgvttpnt.Columns[1].HeaderText = "Mã The";
            dgvttpnt.Columns[2].HeaderText = "Ngày Lập";
            dgvttpnt.Columns[3].HeaderText = "Đơn Giám Phạt";
            dgvttpnt.Columns[4].HeaderText = "Mã NV";
            dgvttpnt.Columns[5].HeaderText = "Mã Sách";
        }
        #endregion
        #region load sach

        private void hiendlsach()
        {

        }
        #endregion
        #region load nhanvien

        private void hiendlnv()
        {

        }
        #endregion
        #region load thẻ thư viện

        private void hiendlthethuvien()
        {

        }
        #endregion
        #region doc len file


        private void loaddllenfile()
        {
        }
        #endregion
        #region them phiếu nhắc trả
        private void btnthemnv_Click(object sender, EventArgs e)
        {
            txtmapnt.Clear();
            txtghichu.Clear();
            //txttennv.Clear();
            txtdgp.Clear();
            txtmapnt.Text = taomapnt();
        }
        #endregion
        #region luuphieunhactra
        private void luuphieunhactra()
        {



        }
        private void btnluupnt_Click(object sender, EventArgs e)
        {
            huy_bingding();
            luuphieunhactra();
            loaddllenfile();
            data_bingding();
        }
        #endregion
        #region  sua phieu nhắc trả
        private void suaphieunhactra()
        {


        }
        private void btnsuapnt_Click(object sender, EventArgs e)
        {
            huy_bingding();
            suaphieunhactra();
            loaddllenfile();
            data_bingding();
        }
        #endregion
        #region xoaphieumuon
        private void xoaphieumuon()
        {


        }
        private void btnxoapnt_Click(object sender, EventArgs e)
        {
            huy_bingding();
            xoaphieumuon();
            loaddllenfile();
            data_bingding();
        }
        #endregion
        #region THOAT
        private void btn_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn Thật Sự Muốn Xóa", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
        private void txtdgp_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }




    }
}
