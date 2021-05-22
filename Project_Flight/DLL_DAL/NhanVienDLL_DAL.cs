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
            _response = _client.GetAsync("/USER").Result;
            var user = _response.Content.ReadAsAsync<IEnumerable<NhanVienModel>>().Result;

            foreach(NhanVienModel item in user)
            {
                if (item.TaiKhoan.Equals(model.TaiKhoan) && item.MatKhau.Equals(model.MatKhau))
                {
                    return item;
                }
            }
            return null;
        }
    }
}

