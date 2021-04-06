using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Tổng quan";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new DoanhThu());
        }

        private void container(object _form)
        {

            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            label_val.Text = "Doanh thu";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new DoanhThu());
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            label_val.Text = "Danh sách sân bay";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new SanBay());
        }

    }
}
