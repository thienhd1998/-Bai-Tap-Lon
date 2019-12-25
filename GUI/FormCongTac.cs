using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL.TinhTai;
using BLL;
using System.Drawing.Printing;

namespace GUI
{
    public partial class FormCongTac : Form
    {
        public FormCongTac()
        {
            InitializeComponent();          
        }
        
        //code sự kiện đóng form công tác
        private void FormClosing_fct(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = new DialogResult();
            dl = MessageBox.Show("Bạn có chắc chăn muốn thoát không ?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
            //FormLogin flg = new FormLogin();
            //flg.Show();

        }

        //code lấy mã giáo viên từ textbox user đăng nhập
        public string GetMaGV(string magv)
        {
            return lblMaGV.Text = magv;
        }

        #region"Hiển thị thông tin các tải công tác"

        //Hiển from tải giảng dạy khi click
        private void button1_Click(object sender, EventArgs e)
                {
                    pnlnam.Visible = true;
                    pnlNCKH.Visible = false;
                    pnlTongHop.Visible = false;
                    pnlGiangday.Visible = true;
                    pnlGiangday.Dock = DockStyle.Fill;
                    tabControlGiangDay.Dock = DockStyle.Fill;          
                }

        //Hiện form tải NCKH khi click
        private void btnNCKH_Click(object sender, EventArgs e)
        {
            pnlGiangday.Visible = false;
            pnlNCKH.Visible = true;          
            pnlTongHop.Visible = false;
            pnlNCKH.Dock = DockStyle.Fill;
            tabControlNCKH.Dock = DockStyle.Fill;
        }    
 
        //Hiện form tổng hợp khi click
        private void btnTongHop_Click(object sender, EventArgs e)
        {
            GetTenGVBLL gt = new GetTenGVBLL();
            pnlnam.Visible = true;
            pnlGiangday.Visible = false;
            pnlNCKH.Visible = false;
            pnlTongHop.Visible = true;
            pnlTongHop.Dock = DockStyle.Fill;
            lblTenGV.Text = gt.GetTenGV(lblMaGV.Text);
        }

        //Hiển thị thông tin công tác theo năm
        private void comboBoxNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblnam.Text = comboBoxNam.SelectedItem.ToString();

            string nam = comboBoxNam.SelectedItem.ToString();
            int num = 1;
            TinhTaiBLL ttbll = new TinhTaiBLL();
            #region"Hiển thị thông tin tải giảng dạy đại học"
            List<ThongTinTaiGD> ttTaiGDDH = ttbll.HienThiTaiGD(lblMaGV.Text, "LHDT1000", nam);
            listViewGDDH.Items.Clear();
            foreach (ThongTinTaiGD tt in ttTaiGDDH)
            {
                ListViewItem lv = new ListViewItem("" + num);
                lv.SubItems.Add(tt.TenHP.ToString());
                lv.SubItems.Add(tt.SySo.ToString());
                lv.SubItems.Add(tt.HeDaoTao.ToString());
                lv.SubItems.Add(tt.TenLopHP.ToString());
                lv.SubItems.Add(tt.SoTC.ToString());
                lv.SubItems.Add(tt.SoTiet.ToString());
                lv.SubItems.Add(tt.GioChuan.ToString());
                lv.SubItems.Add(tt.GhiChu.ToString());

                listViewGDDH.Items.Add(lv);
                num++;
            }
            #endregion

            #region"Hiển thị thông tin tải giảng dạy cao học"
            int num1 = 1;
            List<ThongTinTaiGD> ttTaiGDCH = ttbll.HienThiTaiGD(lblMaGV.Text, "LHDT1001", nam);
            listViewGDCH.Items.Clear();
            foreach (ThongTinTaiGD tt in ttTaiGDCH)
            {
                ListViewItem lv = new ListViewItem("" + num1);
                lv.SubItems.Add(tt.TenHP.ToString());
                lv.SubItems.Add(tt.SySo.ToString());
                lv.SubItems.Add(tt.HeDaoTao.ToString());
                lv.SubItems.Add(tt.TenLopHP.ToString());
                lv.SubItems.Add(tt.SoTC.ToString());
                lv.SubItems.Add(tt.SoTiet.ToString());
                lv.SubItems.Add(tt.GioChuan.ToString());
                lv.SubItems.Add(tt.GhiChu.ToString());

                listViewGDCH.Items.Add(lv);
                num1++;
            }
            #endregion

            #region"Hiển thị thông tin tải giảng dạy NCS"
            int num2 = 1;
            List<ThongTinTaiGD> ttTaiGDNCS = ttbll.HienThiTaiGD(lblMaGV.Text, "LHDT1002", nam);
            listViewGDNCS.Items.Clear();
            foreach (ThongTinTaiGD tt in ttTaiGDNCS)
            {
                ListViewItem lv = new ListViewItem("" + num1);
                lv.SubItems.Add(tt.TenHP.ToString());
                lv.SubItems.Add(tt.SySo.ToString());
                lv.SubItems.Add(tt.HeDaoTao.ToString());
                lv.SubItems.Add(tt.TenLopHP.ToString());
                lv.SubItems.Add(tt.SoTC.ToString());
                lv.SubItems.Add(tt.SoTiet.ToString());
                lv.SubItems.Add(tt.GioChuan.ToString());
                lv.SubItems.Add(tt.GhiChu.ToString());

                listViewGDNCS.Items.Add(lv);
                num2++;
            }
            #endregion

            //Hiển thị số giờ giảng dạy đại học
            lbltaiGDDH.Text = ttbll.TinhTai(lblMaGV.Text, "LHDT1000", nam).ToString();

            //Hiển thị số giờ giảng dạy cao học
            lbltaiGDCH.Text= ttbll.TinhTai(lblMaGV.Text, "LHDT1001", nam).ToString();

            //Hiển thị số giờ giảng dạy NCS
            lbltaiGDNCS.Text = ttbll.TinhTai(lblMaGV.Text, "LHDT1002", nam).ToString();

            //Hiển thị tổng số giờ giảng dạy
            lblTongtaiGD.Text = ttbll.TongTaiGD(lblMaGV.Text, nam).ToString();
        }

        #endregion

        #region"Nhập tải"

        #region"Nhập tải giảng dạy"

        //Hiện form nhập tải giảng dạy
        private void btntaiGangDay_Click(object sender, EventArgs e)
        {
            BangTamFbll BTBLL = new BangTamFbll();
            pnlNhapTaiGD.Visible = true;
            pnlNhapTaiNCKH.Visible = false;
            pnlNhapTaiGD.Dock = DockStyle.Fill;
            tabControlNhapTaiGD.Dock = DockStyle.Fill;
            dataGridViewGDDH.DataSource = BTBLL.HienThi(lblMaGV.Text, "LHDT1000");
            dataGridViewGDCH.DataSource = BTBLL.HienThi(lblMaGV.Text, "LHDT1001");
            dataGridViewGDNCS.DataSource = BTBLL.HienThi(lblMaGV.Text, "LHDT1002");
            
        }

        #region "Nhập tải giảng dạy đại học"  
        //Hiển thị thông tin
        

        //Code sự kiện làm sạch text box để nhập
        private void btnClearDH_Click(object sender, EventArgs e)
        {

            txtbMaLopDH.Text = string.Empty;
            txtbSoTietDH.Text = string.Empty;
            txtbGhiChuDH.Text = string.Empty;
        }

        //Code thêm thông tin giảng dạy đại học của 1 GV (trong bảng tạm)
        private void btnSubmitGDDH_Click(object sender, EventArgs e)
        {

            string magv = lblMaGV.Text;
            //FormThongBaoSure ftb = new FormThongBaoSure();
            try
            {
                //Kiểm tra nếu các textbox cần thiết bị trống
                if (txtbMaLopDH.Text == string.Empty || txtbSoTietDH.Text == string.Empty)
                {
                    MessageBox.Show("Chưa đủ thông tin cần thiết, vui lòng nhập lại !");
                }
                else
                {
                    //Khởi tạo đối tượng BLL
                    BangTamFbll BTBLL = new BangTamFbll();
                    //lấy ra mã lớp học phần theo magv và mã lớp hp để kiểm tra gv đã nhập hay chưa ?
                    string malophp = BTBLL.getMaLopHP(txtbMaLopDH.Text, magv);

                    //Lấy ra mã lớp học phần trong hệ thống để kiểm tra mã lớp hp có tồn tại trong hệ thống hay k
                    string malophp1 = BTBLL.getAllMaLopHP(txtbMaLopDH.Text);

                    if (malophp == "" && malophp1 != "")
                    {
                        BTBLL.Insert(magv, txtbMaLopDH.Text, txtbSoTietDH.Text, txtbGhiChuDH.Text);
                        dataGridViewGDDH.DataSource = BTBLL.HienThi(magv, "LHDT1000");
                    }

                    else
                    {
                        MessageBox.Show("Đã tồn tại thông tin về lớp này hoặc không tồn tại lớp học phần trong hệ thống, bạn có thể sửa lại !");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        //Code xóa thông tin giảng dạy ĐH của 1 gv (trong bảng tạm)
        private void btnDeleteGDDH_Click(object sender, EventArgs e)
        {
            DialogResult dl = new DialogResult();
            dl = MessageBox.Show("Bạn có chắc chăn muốn xóa không ?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                
                BangTamFbll bll = new BangTamFbll();
                bll.Delete(txtbMaLopDH.Text);
                dataGridViewGDDH.DataSource = bll.HienThi(lblMaGV.Text, "LHDT1000");
            }                      
        }

        //Code sửa thông tin giảng dạy đh của gv (trong bảng tạm)
        private void btnEditGDDH_Click(object sender, EventArgs e)
        {
            BangTamFbll bll = new BangTamFbll();
            bll.Edit(lblMaGV.Text, txtbMaLopDH.Text, txtbSoTietDH.Text, txtbGhiChuDH.Text);
            dataGridViewGDDH.DataSource = bll.HienThi(lblMaGV.Text, "LHDT1000");
        }

        //Hiện thông tin lên text box khi nhấn chuột vào từng dòng thông tin
        private void MC_DTDH(object sender, MouseEventArgs e)
        {
            txtbMaLopDH.Text = dataGridViewGDDH.CurrentRow.Cells[1].Value.ToString();
            txtbSoTietDH.Text = dataGridViewGDDH.CurrentRow.Cells[3].Value.ToString();
            txtbGhiChuDH.Text = dataGridViewGDDH.CurrentRow.Cells[4].Value.ToString();
        }
        #endregion

        #region"Nhập tải giảng dạy cao học"

        //Làm sạch các ô text box
        private void btnClearCH_Click(object sender, EventArgs e)
        {
            txtbMaLopCH.Text = string.Empty;
            txtbSoTietCH.Text = string.Empty;
            txtbGhiChuCH.Text = string.Empty;
        }

        //Thêm thông tin
        private void btnSubmitCH_Click(object sender, EventArgs e)
        {
            string magv = lblMaGV.Text;
            
            try
            {
                //Kiểm tra nếu các textbox cần thiết bị trống
                if (txtbMaLopCH.Text == string.Empty || txtbSoTietCH.Text == string.Empty)
                {
                    MessageBox.Show("Chưa đủ thông tin cần thiết, vui lòng nhập lại !");
                }
                else
                {
                    //Khởi tạo đối tượng BLL
                    BangTamFbll BTBLL = new BangTamFbll();
                    //lấy ra mã lớp học phần theo magv và mã lớp hp để kiểm tra gv đã nhập hay chưa ?
                    string malophp = BTBLL.getMaLopHP(txtbMaLopCH.Text, magv);

                    //Lấy ra mã lớp học phần trong hệ thống để kiểm tra mã lớp hp có tồn tại trong hệ thống hay k
                    string malophp1 = BTBLL.getAllMaLopHP(txtbMaLopCH.Text);

                    if (malophp == "" && malophp1 != "")
                    {
                        BTBLL.Insert(magv, txtbMaLopCH.Text, txtbSoTietCH.Text, txtbGhiChuCH.Text);
                        dataGridViewGDCH.DataSource = BTBLL.HienThi(magv, "LHDT1001");
                    }

                    else
                    {
                        MessageBox.Show("Đã tồn tại thông tin về lớp này hoặc không tồn tại lớp học phần trong hệ thống, bạn có thể sửa lại !");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        //Xóa thông tin
        private void btnDeleteCH_Click(object sender, EventArgs e)
        {
            DialogResult dl = new DialogResult();
            dl = MessageBox.Show("Bạn có chắc chăn muốn xóa không ?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                
                BangTamFbll bll = new BangTamFbll();
                bll.Delete(txtbMaLopCH.Text);
                dataGridViewGDCH.DataSource = bll.HienThi(lblMaGV.Text, "LHDT1001");
            }
        }

        //Sửa thông tin
        private void btnEditCH_Click(object sender, EventArgs e)
        {
            BangTamFbll bll = new BangTamFbll();
            bll.Edit(lblMaGV.Text, txtbMaLopCH.Text, txtbSoTietCH.Text, txtbGhiChuCH.Text);
            dataGridViewGDCH.DataSource = bll.HienThi(lblMaGV.Text, "LHDT1001");
        }

        //Hiện thông tin lên text box khi nhấn chuột vào từng dòng thông tin
        private void MC_GDCH(object sender, MouseEventArgs e)
        {
            txtbMaLopCH.Text = dataGridViewGDCH.CurrentRow.Cells[1].Value.ToString();
            txtbSoTietCH.Text = dataGridViewGDCH.CurrentRow.Cells[3].Value.ToString();
            txtbGhiChuCH.Text = dataGridViewGDCH.CurrentRow.Cells[4].Value.ToString();

        }

        #endregion

        #region"Nhập tải giảng dạy NCS"

        //Làm sạch textbox
        private void btnClearNCS_Click_1(object sender, EventArgs e)
        {
            txtbMaLopNCS.Text = string.Empty;
            txtbSoTietNCS.Text = string.Empty;
            txtbGhiChuNCS.Text = string.Empty;
        }

        //Thêm thông tin 
        private void btnSubmitNCS_Click(object sender, EventArgs e)
        {
            string magv = lblMaGV.Text;
            //FormThongBaoSure ftb = new FormThongBaoSure();
            try
            {
                //Kiểm tra nếu các textbox cần thiết bị trống
                if (txtbMaLopNCS.Text == string.Empty || txtbSoTietNCS.Text == string.Empty)
                {
                    MessageBox.Show("Chưa đủ thông tin cần thiết, vui lòng nhập lại !");
                }
                else
                {
                    //Khởi tạo đối tượng BLL
                    BangTamFbll BTBLL = new BangTamFbll();
                    //lấy ra mã lớp học phần theo magv và mã lớp hp để kiểm tra gv đã nhập hay chưa ?
                    string malophp = BTBLL.getMaLopHP(txtbMaLopNCS.Text, magv);

                    //Lấy ra mã lớp học phần trong hệ thống để kiểm tra mã lớp hp có tồn tại trong hệ thống hay k
                    string malophp1 = BTBLL.getAllMaLopHP(txtbMaLopNCS.Text);

                    if (malophp == "" && malophp1 != "")
                    {
                        BTBLL.Insert(magv, txtbMaLopNCS.Text, txtbSoTietNCS.Text, txtbGhiChuNCS.Text);
                        dataGridViewGDNCS.DataSource = BTBLL.HienThi(magv, "LHDT1002");
                    }

                    else
                    {
                        MessageBox.Show("Đã tồn tại thông tin về lớp này hoặc không tồn tại lớp học phần trong hệ thống, bạn có thể sửa lại !");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        //Xóa thông tin
        private void btnDeleteNCS_Click(object sender, EventArgs e)
        {
            DialogResult dl = new DialogResult();
            dl = MessageBox.Show("Bạn có chắc chăn muốn xóa không ?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                
                BangTamFbll bll = new BangTamFbll();
                bll.Delete(txtbMaLopNCS.Text);
                dataGridViewGDNCS.DataSource = bll.HienThi(lblMaGV.Text, "LHDT1002");
            }
        }

        //Sửa thông tin
        private void btnEditNCS_Click(object sender, EventArgs e)
        {
            BangTamFbll bll = new BangTamFbll();
            bll.Edit(lblMaGV.Text, txtbMaLopNCS.Text, txtbSoTietNCS.Text, txtbGhiChuNCS.Text);
            dataGridViewGDNCS.DataSource = bll.HienThi(lblMaGV.Text, "LHDT1002");
        }

        //Hiện thông tin lên textbox khi nhấn click vào 1 dòng
        private void MC_NCS(object sender, MouseEventArgs e)
        {
            txtbMaLopNCS.Text = dataGridViewGDNCS.CurrentRow.Cells[1].Value.ToString();
            txtbSoTietNCS.Text = dataGridViewGDNCS.CurrentRow.Cells[3].Value.ToString();
            txtbGhiChuNCS.Text = dataGridViewGDNCS.CurrentRow.Cells[4].Value.ToString();
        }


        #endregion

        #endregion

        #region"Nhập tải NCKH"

        //Hiện form nhập tải NCKH
        private void btntaiNCKH_Click(object sender, EventArgs e)
        {
            pnlNhapTaiNCKH.Visible = true;
            pnlNhapTaiGD.Visible = false;
            pnlNhapTaiNCKH.Dock = DockStyle.Fill;
            tabControlNhapTaiNCKH.Dock = DockStyle.Fill;
        }

        #endregion

        #endregion


        private void comboBoxLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBoxLoaiSach.SelectedItem.ToString();
            if(item=="Sách chuyên khảo")
            {
                txtSoTrang.Enabled = true;
            }
            else
            {
                txtSoTrang.Enabled = false;
            }
        }      
              

        private void btnClearBB_BCKH_Click(object sender, EventArgs e)
        {
            txtbTenBB_BCKH.Text = string.Empty;
            txtbMaBB_BCKH.Text = string.Empty;
            txtbVaiTro.Text = string.Empty;
        }

        private void btnClearDT_Click(object sender, EventArgs e)
        {
            txtbTenDT.Text = string.Empty;
            txtbMaDT.Text = string.Empty;
            txtbVaiTroDT.Text = string.Empty;
        }

        private void btnClearSach_Click(object sender, EventArgs e)
        {
            txtbTenSach.Text = string.Empty;
            txtbMaSach.Text = string.Empty;
            comboBoxLoaiSach.Text = string.Empty;

            comboBoxVaiTroSach.Text = string.Empty;
            txtSoTrang.Text = string.Empty;
            txtSoTrang.Enabled = false;

        }

        private void FormCongTac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quản_lý_giáo_viên_đại_họcDataSet2.NamHoc' table. You can move, or remove it, as needed.
            this.namHocTableAdapter.Fill(this.quản_lý_giáo_viên_đại_họcDataSet2.NamHoc);
            // TODO: This line of code loads data into the 'quản_lý_giáo_viên_đại_họcDataSet1.LopHP' table. You can move, or remove it, as needed.
            this.lopHPTableAdapter.Fill(this.quản_lý_giáo_viên_đại_họcDataSet1.LopHP);

        }

  
        private void cbbHocHam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbHocHam.SelectedItem.ToString()=="Giảng viên")
            {
                txtbDMdaotao.Text = "280";
            }
            else if(cbbHocHam.SelectedItem.ToString()=="Giáo sư" || cbbHocHam.SelectedItem.ToString()=="Giảng viên cao cấp")
            {
                txtbDMdaotao.Text = "360";
            }
            else if(cbbHocHam.SelectedItem.ToString()=="Phó giáo sư"||cbbHocHam.SelectedItem.ToString()=="Giảng viên chính")
            {
                txtbDMdaotao.Text = "320";
            }
        }

       
    }
      
  
  
}
