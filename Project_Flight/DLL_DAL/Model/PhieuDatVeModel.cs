using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DAL.Model
{
    public class PhieuDatVeModel
    {
        private long Id;
        private int RoleDatVe;
        private float ThanhTien;
        private long NguoiDatVe_Id;
        private String HoTen;
        private String CMND;
        private String SoDienThoai;
        private String Email;

        public long id { get => Id; set => Id = value; }
        public int roleDatVe { get => RoleDatVe; set => RoleDatVe = value; }
        public float thanhTien { get => ThanhTien; set => ThanhTien = value; }
        public long nguoiDatVe_Id { get => NguoiDatVe_Id; set => NguoiDatVe_Id = value; }
        public string hoTen { get => HoTen; set => HoTen = value; }
        public string cmnd { get => CMND; set => CMND = value; }
        public string soDienThoai { get => SoDienThoai; set => SoDienThoai = value; }
        public string email { get => Email; set => Email = value; }
    }
}
