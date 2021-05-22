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
using Guna.UI2.WinForms;

namespace dental_sys
{
    public partial class FormThem : Form
    {
        SanBayDLL_DAL sanBay = new SanBayDLL_DAL("SanBay");
        TuyenBayDLL_DAL tuyenBay = new TuyenBayDLL_DAL("TuyenBay");
        public FormThem()
        {
            InitializeComponent();
            loadSanBay(null, guna2ComboBox1);
        }

        private void loadSanBay(SanBayModel model, Guna2ComboBox comboBox)
        {
            if (model == null)
            {
                List<SanBayModel> sanBayModels = sanBay.GetModels();
                comboBox.DataSource = sanBayModels;
                comboBox.DisplayMember = "TenSanBay";
                comboBox.ValueMember = "Code";
            }
            else
            {
                List<SanBayModel> sanBayModels = sanBay.GetModels();
                var itemToRemove = sanBayModels.Single(r => r.Code == model.Code);
                sanBayModels.Remove(itemToRemove);

                comboBox.DataSource = sanBayModels;
                comboBox.DisplayMember = "TenSanBay";
                comboBox.ValueMember = "Code";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanBayModel selected = (SanBayModel)guna2ComboBox1.SelectedItem;
            loadSanBay(selected, guna2ComboBox3);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SanBayModel sanBayDi = (SanBayModel)guna2ComboBox1.SelectedItem;
            SanBayModel sanBayDen = (SanBayModel)guna2ComboBox3.SelectedItem;

            TuyenBayModel tuyenBayModel = new TuyenBayModel();
            tuyenBayModel.SanBayDenID = sanBayDen.id;
            tuyenBayModel.SanBayDiID = sanBayDi.id;
            tuyenBayModel.TenSanBayDen = sanBayDen.TenSanBay;
            tuyenBayModel.TenSanBayDi = sanBayDi.TenSanBay;
            tuyenBayModel.ThanhPhoDen = sanBayDen.TenThanhPho;
            tuyenBayModel.ThanhPhoDi = sanBayDi.TenThanhPho;
            tuyenBayModel.TinhTrang = true;

            tuyenBay.saveModel(tuyenBayModel);
            this.Close();

        }
    }
}
