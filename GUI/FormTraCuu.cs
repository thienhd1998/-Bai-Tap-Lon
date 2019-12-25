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
using BLL;

namespace GUI
{
    public partial class FormTraCuu : Form
    {
        public FormTraCuu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void FormTraCuu_Load(object sender, EventArgs e)
        {

        }

        private void HienThiResult(string tengv)
        {
            
            SearchGVbll SGVBLL = new SearchGVbll();
            List<SearchGV> listSGV = SGVBLL.DisplaySearchGV(tengv);
            ltvSearch.Items.Clear();
            foreach(SearchGV sGV in listSGV)
            {
                ListViewItem lvi = new ListViewItem("" +sGV.ID);
                lvi.SubItems.Add(sGV.TenGv);

                ltvSearch.Items.Add(lvi);
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HienThiResult(txtbSearch.Text);
        }

        private void MouseClick_ltvSearch(object sender, MouseEventArgs e)
        {
            FormLyLichCaNhan llCaNhan = new FormLyLichCaNhan();
            
            string Nam1 = DateTime.Now.Year.ToString();
            string magv = ltvSearch.SelectedItems[0].Text;
            if(magv=="GV01"||magv=="GV02"||magv=="GV26"||magv=="GV34")
            {
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
            else
            {
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
        }
    }
}
