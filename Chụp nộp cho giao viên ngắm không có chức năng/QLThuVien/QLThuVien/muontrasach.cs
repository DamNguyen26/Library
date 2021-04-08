using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class muontrasach : Form
    {
        public muontrasach()
        {
        }
        private void muontrasach_Load(object sender, EventArgs e)
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
        #region docthethuvien

        #endregion
        #region hiện thị mã thẻ
        private string taomathe()
        {
            string mapthe;
            Random r = new Random();
            mapthe = "NV" + r.Next(50, 999).ToString();
            return mapthe;
        }
        #endregion


        #region sinhvien MUON
        #region TTVdautien
        private void hiensvdautien()
        {
        }
        #endregion
        #region bingding
        private void data_bingding()
        {

        }
        private void huy_bingding()
        {
        }
        #endregion
        #region hiện mã pm
        #endregion        
        #region lam mới dữ liệu
        private void btnthem2_Click(object sender, EventArgs e)
        {
        }

        private void btnthem1_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region thêm vào sinh viên

        #endregion
        #region luu the thu vien 
        private void luuthethuvien()
        {
        }
        private void btnluu1_Click(object sender, EventArgs e)
        {
        }
        #endregion                        
        #region  sua thethuvien
        private void suathethuvien()
        {
        }
        private void btnsua1_Click(object sender, EventArgs e)
        {
            huy_bingding();
            suathethuvien();
            data_bingding();
        }
        #endregion
        #region xoanhanvien
        private void XoaNhanVien()
        {
        }
        private void btnxoa1_Click(object sender, EventArgs e)
        {
            huy_bingding();
            XoaNhanVien();
            data_bingding();
        }
        #endregion        
        #region lui
        private void btnlui1_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region toi
        private void btntoi1_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region cuoi
        private void btncuoi1_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region dau
        private void btndau1_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #endregion


        #region load SACH

        private void loaddlsach()
        {
        }
        #endregion


        #region XU LY PHIEU MUON
        #region thempm
        private void btnthempm_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region luuphieumuon
        private void luuphieumuon()
        {
        }
        private void btnluupm_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region docpm
        private void Hienbangpm(string mathe)
        {
        }
        #endregion
        #region bingdingkq
        private void bingdingketqua()
        {
            cbomasach.DataBindings.Add("SelectedValue", dgvds1.DataSource, "MaSach");
            txtMapm.DataBindings.Add("Text", dgvds1.DataSource, "MaPM");
        }
        private void huybingdingketqua()
        {
            if (cbomasach.DataBindings != null)
                cbomasach.DataBindings.Clear();
            if (txtMapm.DataBindings != null)
                txtMapm.DataBindings.Clear();
        }
        #endregion
        #region  sua phieu muon
        private void suaphieumuon()
        {
        }
        private void btnsuapm_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region xoa phieumuon
        private void xoaphieumuon()
        {
        }
        private void btnxoapm_Click(object sender, EventArgs e)
        {
            huybingdingketqua();
            xoaphieumuon();
            Hienbangpm(txtMa.Text);
        }
        #endregion
        #endregion

        #region SINH VIEN CẦN NHẮC TRẢ
        #region bingding
        private void data_bingding2()
        {

        }
        private void huy_bingding2()
        {
            if (dtngaysinh1.DataBindings != null)
                dtngaysinh1.DataBindings.Clear();
            if (txtdienthoai.DataBindings != null)
                txtdienthoai.DataBindings.Clear();
            if (txtmathe1.DataBindings != null)
                txtmathe1.DataBindings.Clear();
            if (txtten1.DataBindings != null)
                txtten1.DataBindings.Clear();
            if (dttao1.DataBindings != null)
                dttao1.DataBindings.Clear();
            if (dthethan1.DataBindings != null)
                dthethan1.DataBindings.Clear();
            if (txtdc1.DataBindings != null)
                txtdc1.DataBindings.Clear();
            if (cbogt.DataBindings != null)
                cbogt.DataBindings.Clear();
        }
        #endregion
        #region luu the thu vien 2
        private void luusinhvien2()
        {
        }
        private void btnluu2_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region  sua thethuvien trong NHẮC TRẢ
        private void suathethuvien2()
        {
        }
        private void btnsua2_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region xoathethuvien
        private void Xoasinhvien2()
        {
        }
        private void btnxoa2_Click(object sender, EventArgs e)
        {
        }
        #endregion        
        #region TTVdautien
        private void hiensvdautien2()
        {
        }
        #endregion
        #region lui 
        private void btnlui_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region dau
        private void btndau_Click(object sender, EventArgs e)
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
        #endregion



        #region PHIEU NHẮC TRẢ
        #region bingding
        private void data_bingding3()
        {
            txtmapnt.DataBindings.Add("Text", dgvds2.DataSource, "MaPNT");
            cbomanv.DataBindings.Add("Selectedvalue", dgvds2.DataSource, "MaNV");
            cbomasach.DataBindings.Add("Selectedvalue", dgvds2.DataSource, "MaSach");
            txtdgp.DataBindings.Add("Text", dgvds2.DataSource, "DonGiaPhat");
            txtghichu.DataBindings.Add("Text", dgvds2.DataSource, "GhiChu");
        }
        private void huy_bingding3()
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
        }
        #endregion
        private void btnthempnt_Click(object sender, EventArgs e)
        {
        }
        #region docpm
        private void Hienbangphieunhactra(string mathe)
        {
        }
        #endregion


        #endregion
        #region bat loi ten va dien thoai
        private void txtTensv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 45 && e.KeyChar < 57)
            {
                e.Handled = true;
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Không được nhập số";
            }
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
        #endregion


    }
}
