using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInformation_Click(object sender, EventArgs e)
        {

            FormTraCuu traCuu = new FormTraCuu();
            traCuu.ShowDialog();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            //FormCongTac fct = new FormCongTac();
            //fct.ShowDialog();
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
        }

        private void btnTaiDonVi_Click(object sender, EventArgs e)
        {
            FormTaiDonVi ftdv = new FormTaiDonVi();
            ftdv.ShowDialog();
        }

        private void btnNhanLuc_Click(object sender, EventArgs e)
        {
            FormNhanLuc fnl = new FormNhanLuc();
            fnl.ShowDialog();
        }
    }
}
