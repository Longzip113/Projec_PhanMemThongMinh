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
    public class NhanVienDLL_DAL
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public NhanVienDLL_DAL()
        {
            _client = new HttpClient();
            _client.BaseAddress = new  Uri("https://6092bf0a85ff51001721390f.mockapi.io");
        }

        public List<NhanVienModel> GetNhanVienModels()
        {
            _response = _client.GetAsync("/USER").Result;
            var nhanViens = _response.Content.ReadAsAsync<IEnumerable<NhanVienModel>>().Result;
            return (List<NhanVienModel>)nhanViens;

        }

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

