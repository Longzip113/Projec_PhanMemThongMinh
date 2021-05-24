using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_sys.UserControls;
using DLL_DAL;
using DLL_DAL.Model;

namespace dental_sys
{
    public partial class QuyDinhVe : Form
    {
        ChuyenBayDLL_DAL chuyenBay = new ChuyenBayDLL_DAL("ChuyenBay");
        public QuyDinhVe()
        {
            InitializeComponent();
        }

        private void loadItem()
        {
            List<ChuyenBayModel> chuyenBayModels = chuyenBay.GetModels();

            itemdatve[] list = new itemdatve[chuyenBayModels.Count];

            for (int i = 0; i < chuyenBayModels.Count; i++)
            {
                list[i] = new itemdatve();
                list[i].Noiden = chuyenBayModels[i].thanhPhoDi +" (" + chuyenBayModels[i].codeSanDi + ")"; //"Hồ Chí Minh (SGN)";
                list[i].Noidi = chuyenBayModels[i].thanhPhoDen + " (" + chuyenBayModels[i].codeSanDen + ")";
                list[i].NgayDi = chuyenBayModels[i].ngay;
                //list[i].Gioden = int.Parse(chuyenBayModels[i].gio) + chuyenBayModels[i].thoiGianBay + "";
                list[i].Giodi = chuyenBayModels[i].gio;

                if (chuyenBayModels[i].hangVe.Equals("BambooAirline"))
                {
                    list[i].Img = Properties.Resources.logo_bamboo;
                }
                else if (chuyenBayModels[i].hangVe.Equals("VietJetAirline"))
                {
                    list[i].Img = Properties.Resources.logo_vietjet;
                }
                else
                {
                    list[i].Img = Properties.Resources.logo_vnairlines;
                }

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(list[i]);
                }
            }
        }

        private void QuyDinhVe_Load(object sender, EventArgs e)
        {
            loadItem();
        }
    }
}
