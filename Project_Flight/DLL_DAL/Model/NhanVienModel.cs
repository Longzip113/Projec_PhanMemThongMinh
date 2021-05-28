using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DAL.Model
{
    public class NhanVienModel
    {
        private long Id;
        private long ChucVuID;
        private String HoTen;
        private String SoDienThoai;
        private String DiaChi;
        private String TaiKhoan;
        private String MatKhau;
        private Boolean TinhTrang;
        private String Cmnd;
        private int soVeBan;
        private long tongDoanhThu;
    
        public long id { get => Id; set => Id = value; }
        public String diaChi { get => DiaChi; set => DiaChi = value; }
        public long chucVuID { get => ChucVuID; set => ChucVuID = value; }
        public string hoTen { get => HoTen; set => HoTen = value; }
        public string soDienThoai { get => SoDienThoai; set => SoDienThoai = value; }
        public string taiKhoan { get => TaiKhoan; set => TaiKhoan = value; }
        public string matKhau { get => MatKhau; set => MatKhau = value; }
        public Boolean tinhTrang { get => TinhTrang; set => TinhTrang = value; }
        public string cmnd { get => Cmnd; set => Cmnd = value; }
        public int SoVeBan { get => soVeBan; set => soVeBan = value; }
        public long TongDoanhThu { get => tongDoanhThu; set => tongDoanhThu = value; }
    }
}
