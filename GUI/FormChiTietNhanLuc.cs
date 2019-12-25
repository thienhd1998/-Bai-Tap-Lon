using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;


namespace GUI
{
    public partial class FormChiTietNhanLuc : Form
    {
        public FormChiTietNhanLuc()
        {
            InitializeComponent();
        }

       

        private void comboboxNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Nam = comboboxNam.SelectedItem.ToString();
            //Hiển thị nhân lực ban chủ nhiệm khoa
            NhanLucKhoaBLL nlkbll = new NhanLucKhoaBLL();
            List<NhanLucBanCNKhoa> nlKhoa = nlkbll.HienThiNhanLucKhoa(Nam);
            listViewCNKhoa.Items.Clear();
            foreach (NhanLucBanCNKhoa nlbcnk in nlKhoa)
            {
                
                ListViewItem lvi = new ListViewItem(nlbcnk.MaGV + "");
                lvi.SubItems.Add(nlbcnk.TenGV);
                lvi.SubItems.Add(nlbcnk.TenChucVu);
                lvi.SubItems.Add(nlbcnk.TenHocHam);
                lvi.SubItems.Add(nlbcnk.TenHocVi);
                
                listViewCNKhoa.Items.Add(lvi);  
            }

            //Hiển thị nhân lực bộ môn CNPM
            NhanLucCNPMbll cnpmBLL = new NhanLucCNPMbll();
            List<NhanLucBMCNPM> nlCNPM = cnpmBLL.HienThiNhanLucCNPM(Nam, "BM01");
            listViewCNPM.Items.Clear();
            foreach (NhanLucBMCNPM nlcnpm in nlCNPM)
            {
               
                ListViewItem lvi = new ListViewItem(nlcnpm.MaGV+ "");
                lvi.SubItems.Add(nlcnpm.TenGV);
                lvi.SubItems.Add(nlcnpm.TenChucVu);
                lvi.SubItems.Add(nlcnpm.TenHocHam);
                lvi.SubItems.Add(nlcnpm.TenHocVi);
                lvi.SubItems.Add(nlcnpm.MaGV);

                listViewCNPM.Items.Add(lvi);
            }

            //Hiển thị nhân lực bộ môn CNTT
            NhanLucCNTTbll cnttBLL = new NhanLucCNTTbll();
            List<NhanLucCNTT> nlCNTT = cnttBLL.HienThiNhanLucCNTT(Nam, "BM03");
            listViewCNTT.Items.Clear();
            foreach (NhanLucCNTT nlcntt in nlCNTT)
            {
                
                ListViewItem lvi = new ListViewItem(nlcntt.MaGV + "");
                lvi.SubItems.Add(nlcntt.TenGV);
                lvi.SubItems.Add(nlcntt.TenChucVu);
                lvi.SubItems.Add(nlcntt.TenHocHam);
                lvi.SubItems.Add(nlcntt.TenHocVi);
                lvi.SubItems.Add(nlcntt.MaGV);

                listViewCNTT.Items.Add(lvi);
            }

            //Hiển thị nhân lực bộ môn HTTT
            NhanLucHTTTbll htttBLL = new NhanLucHTTTbll();
            List<NhanLucHTTT> nlHTTT = htttBLL.HienThiNhanLucHTTT(Nam, "BM04");
            listViewHTTT.Items.Clear();
            foreach (NhanLucHTTT nlhttt in nlHTTT)
            {

                ListViewItem lvi = new ListViewItem(nlhttt.MaGV + "");
                lvi.SubItems.Add(nlhttt.TenGV);
                lvi.SubItems.Add(nlhttt.TenChucVu);
                lvi.SubItems.Add(nlhttt.TenHocHam);
                lvi.SubItems.Add(nlhttt.TenHocVi);
                lvi.SubItems.Add(nlhttt.MaGV);

                listViewHTTT.Items.Add(lvi);
            }

            //Hiển thị nhân lực bộ môn KHMT
            NhanLucKHMTbll khmtBLL = new NhanLucKHMTbll();
            List<NhanLucKHMT> nlKHMT = khmtBLL.HienThiNhanLucKHMT(Nam, "BM02");
            listViewKHMT.Items.Clear();
            foreach (NhanLucKHMT nlkhmt in nlKHMT)
            {
               
                ListViewItem lvi = new ListViewItem(nlkhmt.MaGV+ "");
                lvi.SubItems.Add(nlkhmt.TenGV);
                lvi.SubItems.Add(nlkhmt.TenChucVu);
                lvi.SubItems.Add(nlkhmt.TenHocHam);
                lvi.SubItems.Add(nlkhmt.TenHocVi);
                lvi.SubItems.Add(nlkhmt.MaGV);

                listViewKHMT.Items.Add(lvi);
            }

            //Hiển thị nhân lực bộ môn ATTT
            NhanLucATTTbll atttBLL = new NhanLucATTTbll();
            List<NhanLucATTT> nlATTT = atttBLL.HienThiNhanLucATTT(Nam, "BM05");
            listViewATTT.Items.Clear();
            foreach (NhanLucATTT nlattt in nlATTT)
            {

                ListViewItem lvi = new ListViewItem(nlattt.MaGV + "");
                lvi.SubItems.Add(nlattt.TenGV);
                lvi.SubItems.Add(nlattt.TenChucVu);
                lvi.SubItems.Add(nlattt.TenHocHam);
                lvi.SubItems.Add(nlattt.TenHocVi);
                lvi.SubItems.Add(nlattt.MaGV);

                listViewATTT.Items.Add(lvi);
            }
        }

        private void ltvCNKhoa_MouseClick(object sender, MouseEventArgs e)
        {
            string Nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewCNKhoa.SelectedItems[0].Text;

            
            
            FormLyLichCaNhan llCaNhan = new FormLyLichCaNhan();
            llCaNhan.HienThiTTCNK(magv, Nam1);
            llCaNhan.HienThiHH(Nam1, magv);
            llCaNhan.HienThiHV(Nam1, magv);
            llCaNhan.SoLATSdaHD(magv, Nam1);
            llCaNhan.SoLATSdangHD(magv, Nam1);
            llCaNhan.SoLVCHdaHD(magv, Nam1);
            llCaNhan.ChiTietLATS(magv, Nam1);
            llCaNhan.ChiTietLVCH(magv, Nam1);
            llCaNhan.HienThiDetailHPGD(magv, Nam1);
            llCaNhan.HienThiHHFull(magv, Nam1);
            llCaNhan.HienThiHVFull(magv, Nam1);
            llCaNhan.HienThiSachCK(magv, Nam1);
            llCaNhan.HienThiSachGT(magv, Nam1);
            llCaNhan.HienThiTLKhac(magv, Nam1);
            llCaNhan.HienThiAllBB(magv, Nam1);
            llCaNhan.HienThiSoBBQuocTe(magv, Nam1);
            llCaNhan.HienThiSoBBTrongNuoc(magv, Nam1);
            llCaNhan.ShowDialog();

        }

        private void ltvCNPM_MouseClick(object sender, MouseEventArgs e)
        {
            string Nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewCNPM.SelectedItems[0].Text;

            FormLyLichCaNhan llCaNhan = new FormLyLichCaNhan();
            llCaNhan.HienThiTTGVBM(magv, Nam1);
            llCaNhan.HienThiHH(Nam1, magv);
            llCaNhan.SoLATSdaHD(magv, Nam1);
            llCaNhan.SoLATSdangHD(magv, Nam1);
            llCaNhan.ChiTietLATS(magv, Nam1);
            llCaNhan.ChiTietLVCH(magv, Nam1);
            llCaNhan.SoLVCHdaHD(magv, Nam1);
            llCaNhan.HienThiSachCK(magv, Nam1);
            llCaNhan.HienThiSachGT(magv, Nam1);
            llCaNhan.HienThiTLKhac(magv, Nam1);
            llCaNhan.HienThiAllBB(magv, Nam1);
            llCaNhan.HienThiHV(Nam1, magv);
            llCaNhan.HienThiSoBBQuocTe(magv, Nam1);
            llCaNhan.HienThiSoBBTrongNuoc(magv, Nam1);
            llCaNhan.HienThiHHFull(magv, Nam1);
            llCaNhan.HienThiHVFull(magv, Nam1);
            llCaNhan.HienThiDetailHPGD(magv, Nam1);
            llCaNhan.ShowDialog();
        }

        private void ltvKHMT_MouseClick(object sender, MouseEventArgs e)
        {
            string Nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewKHMT.SelectedItems[0].Text;

            FormLyLichCaNhan llCaNhan = new FormLyLichCaNhan();
            llCaNhan.HienThiTTGVBM(magv, Nam1);
            llCaNhan.HienThiHH(Nam1, magv);
            llCaNhan.HienThiHV(Nam1, magv);
            llCaNhan.SoLATSdaHD(magv, Nam1);
            llCaNhan.SoLATSdangHD(magv, Nam1);
            llCaNhan.HienThiSoBBQuocTe(magv, Nam1);
            llCaNhan.HienThiSoBBTrongNuoc(magv, Nam1);
            llCaNhan.HienThiHHFull(magv, Nam1);
            llCaNhan.HienThiHVFull(magv, Nam1);
            llCaNhan.ChiTietLVCH(magv, Nam1);
            llCaNhan.HienThiSachCK(magv, Nam1);
            llCaNhan.HienThiAllBB(magv, Nam1);
            llCaNhan.HienThiSachGT(magv, Nam1);
            llCaNhan.HienThiTLKhac(magv, Nam1);
            llCaNhan.ChiTietLATS(magv, Nam1);
            llCaNhan.SoLVCHdaHD(magv, Nam1);

            llCaNhan.HienThiDetailHPGD(magv, Nam1);
            llCaNhan.ShowDialog();
        }

        private void ltvCNTT_MouseClick(object sender, MouseEventArgs e)
        {
            string nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewCNTT.SelectedItems[0].Text;

            FormLyLichCaNhan llcanhan = new FormLyLichCaNhan();
            llcanhan.HienThiHH(nam1, magv);
            llcanhan.HienThiTTGVBM(magv, nam1);
            llcanhan.SoLATSdangHD(magv, nam1);
            llcanhan.HienThiHV(nam1, magv);
            llcanhan.ChiTietLATS(magv, nam1);
            llcanhan.ChiTietLVCH(magv, nam1);
            llcanhan.SoLATSdaHD(magv, nam1);
            llcanhan.HienThiSachCK(magv, nam1);
            llcanhan.HienThiSoBBQuocTe(magv, nam1);
            llcanhan.HienThiSoBBTrongNuoc(magv, nam1);
            llcanhan.HienThiHHFull(magv, nam1);
            llcanhan.HienThiHVFull(magv, nam1);
            llcanhan.HienThiSachGT(magv, nam1);
            llcanhan.HienThiAllBB(magv, nam1);
            llcanhan.HienThiTLKhac(magv, nam1);
            llcanhan.SoLVCHdaHD(magv, nam1);
            llcanhan.HienThiDetailHPGD(magv, nam1);
            llcanhan.ShowDialog();
        }

        private void ltvHTTT_MouseClick(object sender, MouseEventArgs e)
        {
            string Nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewHTTT.SelectedItems[0].Text;

            FormLyLichCaNhan llCaNhan = new FormLyLichCaNhan();
            llCaNhan.HienThiTTGVBM(magv, Nam1);
            llCaNhan.HienThiHH(Nam1, magv);
            llCaNhan.HienThiHV(Nam1, magv);
            llCaNhan.SoLATSdaHD(magv, Nam1);
            llCaNhan.ChiTietLVCH(magv, Nam1);
            llCaNhan.SoLATSdangHD(magv, Nam1);
            llCaNhan.ChiTietLATS(magv, Nam1);
            llCaNhan.HienThiSachGT(magv, Nam1);
            llCaNhan.HienThiSoBBQuocTe(magv, Nam1);
            llCaNhan.HienThiSoBBTrongNuoc(magv, Nam1);
            llCaNhan.HienThiHHFull(magv, Nam1);
            llCaNhan.HienThiHVFull(magv, Nam1);
            llCaNhan.HienThiAllBB(magv, Nam1);
            llCaNhan.HienThiTLKhac(magv, Nam1);
            llCaNhan.HienThiSachCK(magv, Nam1);
            llCaNhan.SoLVCHdaHD(magv, Nam1);
            llCaNhan.HienThiDetailHPGD(magv, Nam1);
            llCaNhan.ShowDialog();
        }

        private void ltvATTT_MouseClick(object sender, MouseEventArgs e)
        {
            string Nam1 = comboboxNam.SelectedItem.ToString();
            string magv = listViewATTT.SelectedItems[0].Text;

            FormLyLichCaNhan llCaNhan = new FormLyLichCaNhan();
            llCaNhan.HienThiTTGVBM(magv, Nam1);
            llCaNhan.HienThiHH(Nam1, magv);
            llCaNhan.SoLATSdaHD(magv, Nam1);
            llCaNhan.SoLATSdangHD(magv, Nam1);
            llCaNhan.ChiTietLVCH(magv, Nam1);
            llCaNhan.ChiTietLATS(magv, Nam1);
            llCaNhan.HienThiDetailHPGD(magv, Nam1);
            llCaNhan.SoLVCHdaHD(magv, Nam1);
            llCaNhan.HienThiAllBB(magv, Nam1);
            llCaNhan.HienThiSachCK(magv, Nam1);
            llCaNhan.HienThiSachGT(magv, Nam1);
            llCaNhan.HienThiTLKhac(magv, Nam1);
            llCaNhan.HienThiSoBBQuocTe(magv, Nam1);
            llCaNhan.HienThiSoBBTrongNuoc(magv, Nam1);
            llCaNhan.HienThiHHFull(magv, Nam1);
            llCaNhan.HienThiHVFull(magv, Nam1);
            llCaNhan.HienThiHV(Nam1, magv);
            llCaNhan.ShowDialog();
        }

        

        public void showNam(string nam)
        {
            comboboxNam.Text = nam;
        }

        public void showTen(string ten)
        {
            lblTenKhoa.Text = "Chi tiết khoa "+ten ;
        }

        
    }
}
