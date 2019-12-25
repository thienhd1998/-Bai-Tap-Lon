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
    public partial class FormNhanLuc : Form
    {
        public FormNhanLuc()
        {
            InitializeComponent();
        }

        private void combBoxNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FormChiTietNhanLuc fctnl = new FormChiTietNhanLuc();
            //fctnl.ShowNam(cbbNam.Text);
            string Nam2 = cbbNam.SelectedItem.ToString();
            //int num = 1;

            NhanLucKhoaCNTTbll nlkcnttbll = new NhanLucKhoaCNTTbll();
            List<NhanLucKhoa> nlKhoa = nlkcnttbll.DisplayNhanLucKhoa("Kh01",Nam2);
            ltvNLKCNTT.Items.Clear();
            foreach(NhanLucKhoa nlK in nlKhoa)
            {
                ListViewItem lvi = new ListViewItem(nlK.TenKhoa+"") ;
                //lvi.SubItems.Add(nlK.TenKhoa);
                lvi.SubItems.Add(nlK.SoGS.ToString());
                lvi.SubItems.Add(nlK.SoPGS.ToString());
                lvi.SubItems.Add(nlK.SoTSKH.ToString());
                lvi.SubItems.Add(nlK.SoTS.ToString());
                lvi.SubItems.Add(nlK.SoThS.ToString());
                lvi.SubItems.Add(nlK.SoGVCC.ToString());
                lvi.SubItems.Add(nlK.SoGV.ToString());
                lvi.SubItems.Add(nlK.SoGVC.ToString());
                lvi.SubItems.Add(nlK.SoTrG.ToString());
                lvi.SubItems.Add(nlK.Tong.ToString());

                ltvNLKCNTT.Items.Add(lvi);
                
            }
        }

        private void FormNhanLuc_Load(object sender, EventArgs e)
        {

        }

        

        private void MouseClick_ltvNLK(object sender, MouseEventArgs e)
        {
            FormChiTietNhanLuc ctnl = new FormChiTietNhanLuc();
            ctnl.showNam(cbbNam.Text);
            
            string TenKhoa = ltvNLKCNTT.SelectedItems[0].Text;
            ctnl.showTen(TenKhoa);
            ctnl.ShowDialog();
        }
    }
}
