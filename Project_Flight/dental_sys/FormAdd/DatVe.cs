using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_DAL.Model;
using DLL_DAL;

namespace dental_sys.FormAdd
{
    public partial class DatVe : Form
    {
        long id, idNV;
        String gia;
        ChuyenBayDLL_DAL chuyenBay = new ChuyenBayDLL_DAL("chuyenbay");
        ChuyenBayModel chuyenBayItem;
        public DatVe(long id, String gia, long idNV)
        {
            InitializeComponent();
            this.id = id;
            this.gia = gia;
            this.idNV = idNV;
        }

        public ChuyenBayModel findOneChuyenBay(List<ChuyenBayModel> chuyenBayModels, long id)
        {
            foreach(ChuyenBayModel item in chuyenBayModels)
            {
                if(item.id == id)
                {
                    return item;
                }
            }
            return null;
        }

        private void DatVe_Load(object sender, EventArgs e)
        {
            List<ChuyenBayModel> chuyenBayModels = chuyenBay.GetModels();
            chuyenBayItem = findOneChuyenBay(chuyenBayModels, id);

            lblnoidi.Text = chuyenBayItem.thanhPhoDi;
            lblnoiden.Text = chuyenBayItem.thanhPhoDen;

            lblGioDI.Text = chuyenBayItem.gio;
            lblNgayDi.Text = chuyenBayItem.ngay;
            lblGia.Text = "Thành tiền: " + gia;

            if (chuyenBayItem.hangVe.Equals("BambooAirline"))
            {
                lblHinhAnh.Image = Properties.Resources.logo_bamboo;
            }
            else if (chuyenBayItem.hangVe.Equals("VietJetAirline"))
            {
                lblHinhAnh.Image = Properties.Resources.logo_vietjet;
            }
            else
            {
                lblHinhAnh.Image = Properties.Resources.logo_vnairlines;
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            PhieuDatVeModel phieuDatVeModel = new PhieuDatVeModel();
            phieuDatVeModel.cmnd = txtCMND.Text;
            phieuDatVeModel.email = txtEmail.Text;
            phieuDatVeModel.hoTen = txtHoTen.Text;
            phieuDatVeModel.soDienThoai = txtSDT.Text;
            phieuDatVeModel.thanhTien = float.Parse(gia.Replace("", " VNĐ"));
            phieuDatVeModel.nguoiDatVe_Id = idNV;
            phieuDatVeModel.roleDatVe = 1;
            


        }
    }
}
