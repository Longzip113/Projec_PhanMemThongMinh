using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using DLL_DAL.Model;
using Newtonsoft.Json;

namespace DLL_DAL
{
    public class TuyenBayDLL_DAL
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public TuyenBayDLL_DAL()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://6092bf0a85ff51001721390f.mockapi.io");
        }

        public List<TuyenBayModel> GetTuyenBayModels()
        {
            _response = _client.GetAsync("/TuyenBay").Result;
            var sanBays = _response.Content.ReadAsAsync<IEnumerable<TuyenBayModel>>().Result;
            List<TuyenBayModel> models = new List<TuyenBayModel>();
            foreach (TuyenBayModel item in sanBays)
            {
                models.Add(item);
            }
            return models;
        }
    }
}
