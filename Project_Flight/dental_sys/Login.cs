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

namespace dental_sys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://6092bf0a85ff51001721390f.mockapi.io");
            HttpResponseMessage resp = client.GetAsync("/USER/1").Result;
            UserModel user = resp.Content.ReadAsAsync<UserModel>().Result;
            MessageBox.Show(user.HoTen);

            Loading _load = new Loading();
            _load.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
