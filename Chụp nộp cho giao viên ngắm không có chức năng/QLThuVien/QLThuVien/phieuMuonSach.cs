using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class phieuMuonSach : Form
    {
        public phieuMuonSach()
        {
        }
        private void SachMuon_Load(object sender, EventArgs e)
        {
        }
        #region bingding
        private void data_bingding()
        {
        }
        private void huy_bingding()
        {
        }
        #endregion
        #region tiêu đề cột
        private void hientieudecot()
        {
            dgvsachmuon.Columns[0].HeaderText = "Mã PM";
            dgvsachmuon.Columns[1].HeaderText = "Mã Sách";
            dgvsachmuon.Columns[2].HeaderText = "Tình Trạng";
            dgvsachmuon.Columns[3].HeaderText = "SL Sách Mượn";
            dgvsachmuon.Columns[4].HeaderText = "Ngày Trả";
        }
        #endregion
        #region load sach
        private void hiendlsach()
        {
        }
        #endregion
        #region load phieumuon
        private void hiendlphieumuon()
        {
        }
        #endregion
        #region doc len file
        private void loaddllenfile()
        {
        }
        #endregion
        #region them sachmuon
        private void btnthemnv_Click(object sender, EventArgs e)
        {
            huy_bingding();
            txtsoluongsm.Clear();
            txttinhtrang.Clear();
            data_bingding();
        }
        #endregion
        #region luusachmuon
        private void luusachmuon()
        {
        }
        private void btnluunv_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region  sua sachmuon
        private void suasachmuon()
        {
        }
        private void btnsuanv_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region xoasachmuon
        private void xoasachmuon()
        {
        }
        private void btnxoanv_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region thoatsachmuon
        private void btnthoatnv_Click(object sender, EventArgs e)
        {
        }
        #endregion

        private void btnlui_Click(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
