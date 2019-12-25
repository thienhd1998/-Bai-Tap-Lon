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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
           
            textBoxUser.ForeColor = Color.LightGray;          
            textBoxUser.Text = "Id or Username";         
            this.textBoxUser.Leave += new System.EventHandler(this.textBoxUser_Leave);
            this.textBoxUser.Enter += new System.EventHandler(this.textBoxUser_Enter);

            textBoxPassword.ForeColor = Color.LightGray;
            textBoxPassword.UseSystemPasswordChar =true;
            textBoxPassword.Text = "Password";
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if(textBoxUser.Text=="")
            {
                textBoxUser.Text = "Id or Username";
                textBoxUser.ForeColor = Color.Gray;
            }
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if(textBoxUser.Text=="Id or Username")
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Userbll UBLL = new Userbll();
            FormCongTac fct = new FormCongTac();
            string iD = UBLL.getID(textBoxUser.Text, textBoxPassword.Text);
            if(iD!= "")
            {
               
                this.Hide();
                fct.GetMaGV(textBoxUser.Text);
                fct.ShowDialog();
               

            }
            else
            {
                MessageBox.Show("Nhập sai thông tin đăng nhập !");
            }
            
        }
       
    }
}
