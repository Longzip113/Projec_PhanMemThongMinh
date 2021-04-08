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
            label_val.Text = "Doanh Thu";
            guna2PictureBox_val.Image = Properties.Resources.income;
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
            guna2PictureBox_val.Image = Properties.Resources.income;
            container(new DoanhThu());
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            label_val.Text = "Sân bay";
            guna2PictureBox_val.Image = Properties.Resources.flight__1_;
            container(new SanBay());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            label_val.Text = "Nhân viên";
            guna2PictureBox_val.Image = Properties.Resources.group;
            container(new NhanVien());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label_val.Text = "Tuyến bay";
            guna2PictureBox_val.Image = Properties.Resources.flight__2_;
            container(new TuyenBay());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label_val.Text = "Chuyến bay";
            guna2PictureBox_val.Image = Properties.Resources.flight__4_;
            container(new ChuyenBay());
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            label_val.Text = "Quy định giá";
            guna2PictureBox_val.Image = Properties.Resources.dollar;
            container(new QuyDinhVe());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            label_val.Text = "Bán vé";
            guna2PictureBox_val.Image = Properties.Resources.dollar;
            container(new BanVe());
        }

    }
}
