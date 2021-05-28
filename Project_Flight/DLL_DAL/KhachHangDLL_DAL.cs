﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_DAL.Model;

namespace DLL_DAL
{
    public class KhachHangDLL_DAL : AbstractDLL_DAL<KhachHangModel>
    {
        public KhachHangDLL_DAL(String url) : base(url)
        {
        }

        private float setVeKhachHang(ref int sl ,long id, List<PhieuDatVeModel> listPDV)
        {
            
            float chiTieu = 0;
            KhachHangModel khachHang = new KhachHangModel();
            foreach (PhieuDatVeModel item in listPDV)
            {
                if(item.khachHangID == id)
                {
                    sl++;
                    chiTieu += item.thanhTien;
                }
            }
            return chiTieu;
        }

        public List<KhachHangModel> findAll()
        {
            PhieuDatVeDLL_DAL phieuDatVe = new PhieuDatVeDLL_DAL("phieudatve");
            List<PhieuDatVeModel> listPDV = phieuDatVe.GetModels();
            List<KhachHangModel> listKH = GetModels();

            foreach (KhachHangModel item in listKH)
            {
                int sl = 0;
                float chitieu = setVeKhachHang(ref sl ,item.id, listPDV);
                item.SoVeDaBan = sl;
                item.TongChiPhi = chitieu;
            }
            return listKH;
        }
    }
}
