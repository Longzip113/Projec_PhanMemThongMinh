﻿using System;
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

        private String converIntegerToDay(int date)
        {
            DateTime dt;
            if (DateTime.TryParseExact(date.ToString(), "yyyyMMddhhmm",
                                      CultureInfo.InvariantCulture,
                                      DateTimeStyles.None, out dt))
            {
                Console.WriteLine(dt);
            }
            return dt.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
        }

        private String converIntegerToTime(int date)
        {
            DateTime dt;
            if (DateTime.TryParseExact(date.ToString(), "yyyyMMddhhmm",
                                      CultureInfo.InvariantCulture,
                                      DateTimeStyles.None, out dt))
            {
                Console.WriteLine(dt);
            }
            return dt.ToString("hh:mm", CultureInfo.InvariantCulture);
        }

        private void loadItem()
        {
            List<ChuyenBayModel> chuyenBayModels = chuyenBay.GetModels();

            itemdatve[] list = new itemdatve[chuyenBayModels.Count];

            for (int i = 0; i < chuyenBayModels.Count; i++)
            {
                list[i] = new itemdatve();
                list[i].Noiden = chuyenBayModels[i].ThanhPhoDi +" (" + chuyenBayModels[i].CodeDi + ")"; //"Hồ Chí Minh (SGN)";
                list[i].Noidi = chuyenBayModels[i].ThanhPhoDen + " (" + chuyenBayModels[i].CodeDen + ")";
                list[i].NgayDi = converIntegerToDay(chuyenBayModels[i].NgayGio);
                list[i].Gioden = converIntegerToTime(chuyenBayModels[i].NgayGio);
                list[i].Giodi = converIntegerToTime(chuyenBayModels[i].NgayGio);

                if (chuyenBayModels[i].HangBay.Equals("BambooAirline"))
                {
                    list[i].Img = Properties.Resources.logo_bamboo;
                }
                else if (chuyenBayModels[i].HangBay.Equals("VietJetAirline"))
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
