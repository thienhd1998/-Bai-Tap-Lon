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
    public partial class FormLyLichCaNhan : Form
    {
        public FormLyLichCaNhan()
        {
            InitializeComponent();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void pnlNow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLyLichCaNhan_Load(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }

        public void HienThiTTCNK(string magv, string nam)
        {
            ThongTinCNKhoabll ttcnkbll = new ThongTinCNKhoabll();
            List<ThongTinCNKhoa> TTCNK = ttcnkbll.DisplayTTCNKhoa(magv,nam);
            lblName.Text = string.Empty;
            lblNgaySinh.Text = string.Empty;
            lblGT.Text = string.Empty;
            lblChucVu.Text = string.Empty;
            lblDonVi.Text = string.Empty;
            lblQueQuan.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblDT.Text = string.Empty;

            foreach(ThongTinCNKhoa ttcnk in TTCNK)
            {
                lblName.Text = ttcnk.TenGV;
                lblGT.Text = ttcnk.GT;
                lblNgaySinh.Text =ttcnk.NgaySinh.ToString();
                lblQueQuan.Text = ttcnk.QueQuan;
                lblChucVu.Text = ttcnk.TenChucVu;
                lblDonVi.Text = ttcnk.TenBM;
                lblEmail.Text = ttcnk.Email;
                lblDT.Text = ttcnk.DienThoai;
            }

        }

        public void HienThiTTGVBM(string magv, string nam)
        {
            ThongTinGVBMbll ttgvbmnll = new ThongTinGVBMbll();
            List<ThongTinGVBM> TTGVBM = ttgvbmnll.DisplayTTGVBM(magv, nam);
            lblName.Text = string.Empty;
            lblNgaySinh.Text = string.Empty;
            lblGT.Text = string.Empty;
            lblChucVu.Text = string.Empty;
            lblDonVi.Text = string.Empty;
            lblQueQuan.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblDT.Text = string.Empty;

            foreach(ThongTinGVBM ttgvbm in TTGVBM)
            {
                lblName.Text = ttgvbm.TenGV;
                lblGT.Text = ttgvbm.GT;
                lblNgaySinh.Text = ttgvbm.NgaySinh.ToString();
                lblQueQuan.Text = ttgvbm.QueQuan;
                lblChucVu.Text = ttgvbm.TenChucVu;
                lblDonVi.Text = ttgvbm.TenBM;
                lblEmail.Text = ttgvbm.Email;
                lblDT.Text = ttgvbm.DienThoai;
            }

        }

        public void HienThiHH(string nam, string magv)
        {
            HocHamMaxbll hhmbll = new HocHamMaxbll();
            List<HocHamMax> HHm = hhmbll.DisplayHH(nam, magv);
            lblHocHam.Text = string.Empty;
            
            foreach(HocHamMax hhm in HHm)
            {
                lblHocHam.Text = hhm.TenHH;
            }
        }

        public void HienThiHV(string nam, string magv)
        {
            HocViMaxbll hvmbll = new HocViMaxbll();
            List<HocViMax> HVm = hvmbll.DisplayHV(nam, magv);
            lblHocVi.Text = string.Empty;

            foreach(HocViMax hvm in HVm)
            {
                lblHocVi.Text = hvm.TenHV;
            }
        }

        public void HienThiDetailHPGD(string magv, string nam)
        {
            int num = 1;
            GiangDayDetailbll gddbll = new GiangDayDetailbll();
            List<GiangDayDetail> giangdayDetail = gddbll.DisplayMonHoc(magv, nam);
            ltvGDdetail.Items.Clear();

            foreach(GiangDayDetail gdD in giangdayDetail)
            {
                ListViewItem lvi = new ListViewItem("" + num);
                lvi.SubItems.Add(gdD.NamHoc);
                lvi.SubItems.Add(gdD.TenHP);
                lvi.SubItems.Add(gdD.DoiTuong);

                ltvGDdetail.Items.Add(lvi);
                num++;
            }
        }

        public void SoLATSdaHD(string magv,string nam)
        {
            SoLATSdaHDbll LATSBLL = new SoLATSdaHDbll();
            List<SoLATSdahd> solatsdahd = LATSBLL.SoLATSDAHD(magv, nam);
            lblLATSdaHD.Text = string.Empty;
            foreach(SoLATSdahd SOlats in solatsdahd)
            {
                lblLATSdaHD.Text = SOlats.SoLATSdaHD.ToString();
            }
        }

        public void SoLATSdangHD(string magv, string nam)
        {
            SoLATSdangHDbll LATS1BLL = new SoLATSdangHDbll();
            List<SoLATSdanghd> solatsdanghd = LATS1BLL.SoLATSDANGHD(magv, nam);
            lblLATSdangHD.Text = string.Empty;
            foreach(SoLATSdanghd SOlatsd in solatsdanghd)
            {
                lblLATSdangHD.Text = SOlatsd.SoLATSdangHD.ToString();
            }
        }

        public void SoLVCHdaHD(string magv, string nam)
        {
            SoLVCHbll LVCHBLL = new SoLVCHbll();
            List<SoLVCH> solvch = LVCHBLL.SoLVCH(magv, nam);
            lblSoLVCH.Text = string.Empty;
            foreach(SoLVCH SOlvch in solvch)
            {
                lblSoLVCH.Text = SOlvch.soLVCH.ToString();
            }
        }

        public void ChiTietLATS(string magv, string nam)
        {
            int num = 1;
            DetailLATSbll DLATSBLL = new DetailLATSbll();
            List<DetailLATS> listDLATS = DLATSBLL.detailLATS(magv, nam);
            ltvDetailLATS.Items.Clear();
            foreach(DetailLATS LATS in listDLATS)
            {
                ListViewItem lvi = new ListViewItem("" + num);
                lvi.SubItems.Add(LATS.TenDT);
                lvi.SubItems.Add(LATS.VaiTro);
                lvi.SubItems.Add(LATS.TenHV);
                lvi.SubItems.Add(LATS.NienKhoa);

                ltvDetailLATS.Items.Add(lvi);
                num++;
            }
        }

        public void ChiTietLVCH(string magv, string nam)
        {
            int num = 1;
            DetailLVCHbll DLVCHBLL = new DetailLVCHbll();
            List<DetailLVCH> listDLVCH = DLVCHBLL.detailLVCH(magv, nam);
            ltvDetailLVCH.Items.Clear();
            foreach (DetailLVCH LATS in listDLVCH)
            {
                ListViewItem lvi = new ListViewItem("" + num);
                lvi.SubItems.Add(LATS.TenDT);
                lvi.SubItems.Add(LATS.VaiTro);
                lvi.SubItems.Add(LATS.TenHV);
                lvi.SubItems.Add(LATS.NienKhoa);

                ltvDetailLVCH.Items.Add(lvi);
                num++;
            }
        }

        public void HienThiSachCK(string magv, string nam)
        {
            int num = 1;
            SachCKbll SCKBLL = new SachCKbll();
            List<SachCK> listSCK = SCKBLL.DisplaySachCK(magv, nam);
            ltvSachCK.Items.Clear();
            foreach(SachCK sck in listSCK)
            {
                ListViewItem lvi = new ListViewItem("" + num);
                lvi.SubItems.Add(sck.TenSach);
                lvi.SubItems.Add(sck.VaiTro);
                lvi.SubItems.Add(sck.NoiXB);
                lvi.SubItems.Add(sck.NamXB);

                ltvSachCK.Items.Add(lvi);
                num++;
            }
        }
        public void HienThiSachGT(string magv, string nam)
        {
            int num = 1;
            SachGTbll SGTBLL = new SachGTbll();
            List<SachGT> listSGT = SGTBLL.DisplaySachGT(magv, nam);
            ltvSachGT.Items.Clear();
            foreach (SachGT sgt in listSGT)
            {
                ListViewItem lvi = new ListViewItem("" + num);
                lvi.SubItems.Add(sgt.TenSach);
                lvi.SubItems.Add(sgt.VaiTro);
                lvi.SubItems.Add(sgt.NoiXB);
                lvi.SubItems.Add(sgt.NamXB);

                ltvSachGT.Items.Add(lvi);
                num++;
            }
        }
        public void HienThiTLKhac(string magv, string nam)
        {
            int num = 1;
            TLKhacbll TLKBLL = new TLKhacbll();
            List<TLKhac> listTLK = TLKBLL.DisplayTLKhac(magv, nam);
            ltvTLKhac.Items.Clear();
            foreach (TLKhac tlk in listTLK)
            {
                ListViewItem lvi = new ListViewItem("" + num);
                lvi.SubItems.Add(tlk.TenSach);
                lvi.SubItems.Add(tlk.VaiTro);
                lvi.SubItems.Add(tlk.NoiXB);
                lvi.SubItems.Add(tlk.NamXB);

                ltvTLKhac.Items.Add(lvi);
                num++;
            }
        }

        
        

        public void HienThiHHFull(string magv, string nam)
        {
            int numm = 1;
            HocHamFullbll HHFBLL = new HocHamFullbll();
            List<HocHamFull> listHHF = HHFBLL.DisplayHHFull(magv,nam);
            ltvHocHamFull.Items.Clear();
            foreach(HocHamFull hhf in listHHF)
            {
                ListViewItem lvi = new ListViewItem("" + numm);
                lvi.SubItems.Add(hhf.TenHocHam);
                lvi.SubItems.Add(hhf.TimeNhan);
                lvi.SubItems.Add(hhf.NoiBoNhiem);

                ltvHocHamFull.Items.Add(lvi);
                numm++;
            }
        }

        public void HienThiHVFull(string magv, string nam)
        {
            int numm = 1;
            HocViFullbll HVFBLL = new HocViFullbll();
            List<HocViFull> listHVF = HVFBLL.DisplayHVFull(magv, nam);
            ltvHocViFull.Items.Clear();
            foreach (HocViFull hvf in listHVF)
            {
                ListViewItem lvi = new ListViewItem("" + numm);
                lvi.SubItems.Add(hvf.TenHV);
                lvi.SubItems.Add(hvf.NamNhan);

                ltvHocViFull.Items.Add(lvi);
                numm++;
            }
        }

        public void HienThiSoBBQuocTe(string magv, string nam)
        {
            SoBBbll sBBBLL = new SoBBbll();
            List<SoBaiBao> listSoBB = sBBBLL.DisplaySoBB(magv, nam);
            lblBBQuocTe.Text = string.Empty;
            foreach(SoBaiBao sbb in listSoBB)
            {
                lblBBQuocTe.Text = sbb.SoBB.ToString();
            }
        }

        public void HienThiSoBBTrongNuoc(string magv, string nam)
        {
            SoBBTrongNuocbll SBBin = new SoBBTrongNuocbll();
            List<SoBaiBao> listSoBB = SBBin.DisplaySoBB(magv, nam);
            lblBBTrongNuoc.Text = string.Empty;
            foreach (SoBaiBao sbb in listSoBB)
            {
                lblBBTrongNuoc.Text = sbb.SoBB.ToString();
            }
        }

        public void HienThiAllBB(string magv, string nam)
        {
            int num = 1;
            LietKeBBbll LKBBbll = new LietKeBBbll();
            List<LietKeBB> listLKBB = LKBBbll.DisplayLietKeBB(magv, nam);
            ltvBaiBao.Items.Clear();
            foreach(LietKeBB lkbb in listLKBB)
            {
                ListViewItem lvi = new ListViewItem("" + num);
                lvi.SubItems.Add(lkbb.TenBB);
                lvi.SubItems.Add(lkbb.VaiTro);
                lvi.SubItems.Add(lkbb.TenTC);
                lvi.SubItems.Add(lkbb.NgayDang);

                ltvBaiBao.Items.Add(lvi);
                num++;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ltvHocHamFull_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
