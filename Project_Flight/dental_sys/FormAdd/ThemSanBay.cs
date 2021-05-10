using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_DAL;
using DLL_DAL.Model;

namespace dental_sys
{
    
    public partial class ThemSanBay : Form
    {
        SanBayDLL_DAL sanBay = new SanBayDLL_DAL();
        SanBayModel model;
        public ThemSanBay(SanBayModel model)
        {
            InitializeComponent();
            this.model = model;
            if(model != null)
            {
                load();
                guna2Button2.Text = "Sua";
            }
        }

        private void load()
        {
            txtMaCode.Text = model.Code;
            txtQuocGia.Text = model.QuocGia;
            txtTenSanBay.Text = model.TenSanBay;
            txtThanhPho.Text = model.TenThanhPho;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ThemSanBay_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SanBayModel sanBayModel = new SanBayModel();
            sanBayModel.Code = txtMaCode.Text.Trim();
            sanBayModel.TenSanBay = txtTenSanBay.Text.Trim();
            sanBayModel.TenThanhPho = txtThanhPho.Text.Trim();
            sanBayModel.QuocGia = txtQuocGia.Text.Trim();
            sanBayModel.TinhTrang = true;
            if (guna2Button2.Text.Equals("Thêm"))
            {
                sanBay.saveSanBayModel(sanBayModel);
            }
            else
            {
                sanBay.update(sanBayModel, model.id);
            }
            this.Close();
        }
    }
}
