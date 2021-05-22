using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DAL
{
    public class AbstractDLL_DAL<T>
    {
        public HttpClient _client;
        public HttpResponseMessage _response;
        private String url;

        public AbstractDLL_DAL(String url)
        {
            this.url = url;
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://6092bf0a85ff51001721390f.mockapi.io");
        }

        public List<T> GetModels()
        {
            _response = _client.GetAsync($"/{url}").Result;
            var listModel = _response.Content.ReadAsAsync<IEnumerable<T>>().Result;
            List<T> models = new List<T>();
            foreach (T item in listModel)
            {
                models.Add(item);
            }
            return models;
        }


        public void saveModel(T model)
        {
            var jSON = JsonConvert.SerializeObject(model);
            var buffer = Encoding.UTF8.GetBytes(jSON);
            var byteContext = new ByteArrayContent(buffer);
            byteContext.Headers.ContentType = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json");
            _client.PostAsync($"/{url}", byteContext);
        }

        public Boolean delete(long id)
        {
            try
            {
                _client.DeleteAsync($"/{url}/{id}");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean update(T model, long id)
        {
            try
            {
                var Json = JsonConvert.SerializeObject(model);
                var buffer = Encoding.UTF8.GetBytes(Json);
                var byteContext = new ByteArrayContent(buffer);
                byteContext.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                _client.PutAsync($"/{url}/{id}", byteContext);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
