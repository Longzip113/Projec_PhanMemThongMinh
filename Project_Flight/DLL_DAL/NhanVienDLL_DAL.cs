using DLL_DAL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DAL
{
    public class NhanVienDLL_DAL:AbstractDLL_DAL<NhanVienModel>
    {
        public NhanVienDLL_DAL(String url):base(url)
        {
        }

        // chuc nang dang nhap
        public NhanVienModel login(NhanVienModel model)
        {
            _response = _client.GetAsync("nhanvien").Result;
            var user = _response.Content.ReadAsAsync<IEnumerable<NhanVienModel>>().Result;

            foreach(NhanVienModel item in user)
            {
                if (item.taiKhoan.Equals(model.taiKhoan) && item.matKhau.Equals(model.matKhau))
                {
                    return item;
                }
            }
            return null;
        }

        public NhanVienModel findNhanVienBycmnd(List<NhanVienModel> listNV, string cmnd)
        {
            foreach (NhanVienModel item in listNV)
            {
                if (item.cmnd.Equals(cmnd))
                {
                    return item;
                }
            }

            return null;
        }
    }
}

