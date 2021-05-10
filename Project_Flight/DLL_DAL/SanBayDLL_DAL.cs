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
    public class SanBayDLL_DAL
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public SanBayDLL_DAL()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://6092bf0a85ff51001721390f.mockapi.io");
        }

        public List<SanBayModel> GetSanBayModels()
        {
            _response = _client.GetAsync("/SanBay").Result;
            var sanBays = _response.Content.ReadAsAsync<IEnumerable<SanBayModel>>().Result;
            List<SanBayModel> models = new List<SanBayModel>();
            foreach (SanBayModel item in sanBays)
            {
                models.Add(item);
            }
            return models;
        }

        public void saveSanBayModel(SanBayModel model)
        {
            var sanBay = JsonConvert.SerializeObject(model);
            var buffer = Encoding.UTF8.GetBytes(sanBay);
            var byteContext = new ByteArrayContent(buffer);
            byteContext.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            _client.PostAsync("/SanBay", byteContext);
        }

        public Boolean delete (long id)
        {
            try
            {
                _client.DeleteAsync($"/SanBay/{id}");
                return true;
            }catch
            {
                return false;
            }
        }

        public Boolean update(SanBayModel model, long id)
        {
            try
            {
                var sanBay = JsonConvert.SerializeObject(model);
                var buffer = Encoding.UTF8.GetBytes(sanBay);
                var byteContext = new ByteArrayContent(buffer);
                byteContext.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                _client.PutAsync($"/SanBay/{id}", byteContext);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
