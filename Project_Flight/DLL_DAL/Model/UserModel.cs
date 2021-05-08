using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DAL.Model
{
    public class UserModel
    {
        private  String Id;
        public String id
        {
            get { return Id; }
            set { Id = value; }
        }


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
