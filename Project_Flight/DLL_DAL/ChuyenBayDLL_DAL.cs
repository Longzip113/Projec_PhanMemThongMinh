using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using DLL_DAL.Model;

namespace DLL_DAL
{
    public class ChuyenBayDLL_DAL
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public ChuyenBayDLL_DAL()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://6092bf0a85ff51001721390f.mockapi.io");
        }

        public List<ChuyenBayModel> GetChuyenBayModels()
        {
            _response = _client.GetAsync("/ChuyenBay").Result;
            var chuyenBays = _response.Content.ReadAsAsync<IEnumerable<ChuyenBayModel>>().Result;
            return (List<ChuyenBayModel>)chuyenBays;
        }
    }
}
