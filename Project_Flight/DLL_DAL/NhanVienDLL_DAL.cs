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

        public async Task<List<UserModel>> GetUserModels()
        {
            _response = await _client.GetAsync("/USER");
            var json = await _response.Content.ReadAsStringAsync();
            List<UserModel> user = JsonConvert.DeserializeObject<List<UserModel>>(json);
            return user;

        }

        public Boolean login(String userName, String passWord)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://6092bf0a85ff51001721390f.mockapi.io");
            HttpResponseMessage resp = client.GetAsync("/USER").Result;
            var user = resp.Content.ReadAsAsync<IEnumerable<UserModel>>().Result;

            foreach(UserModel item in user)
            {
                if(item.TaiKhoan.Equals(userName) && item.MatKhau.Equals(passWord))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

