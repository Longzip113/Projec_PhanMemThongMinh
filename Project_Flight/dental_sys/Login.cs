using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.NetworkInformation;
using dental_sys.Model;
using System.Reflection;
using Newtonsoft.Json;
using DLL_DAL;

namespace dental_sys
{
    public partial class Login : Form
    {
        NhanVienDLL_DAL nhanviens = new NhanVienDLL_DAL();

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
        public void login(String userName, String passWord)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Boolean check = nhanviens.login(guna2TextBox1.Text, guna2TextBox2.Text);
            if(check)
            {
                Loading _load = new Loading();
                _load.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tai Khoan sai !!");
            }

            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
