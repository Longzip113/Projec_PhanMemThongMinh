using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dental_sys.Model
{
    class UserModel
    {
        private String hoTen;

        public String HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private String sDT;

        public String SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        private String taiKhoan;

        public String TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        private String matKhau;

        public String MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
    }
}
