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
    public class ChuyenBayDLL_DAL : AbstractDLL_DAL<ChuyenBayModel>
    {
        public ChuyenBayDLL_DAL(String url) : base(url)
        {
        }


        public ChuyenBayModel findChuyenBayBySanBay(List<ChuyenBayModel> listCB, string sanBaydi, string sanBayDen, string time)
        {
            foreach (ChuyenBayModel item in listCB)
            {
                String day = item.ngay + " - " + item.gio;
                if (item.tenSanBayDi.Equals(sanBaydi) && item.tenSanBayDen.Equals(sanBayDen) && day.Equals(time))
                {
                    return item;
                }
            }

            return null;
        }

        public List<ChuyenBayModel> searchChuyenBay(ChuyenBayModel model)
        {
            string url = "search-chuyenbay?sanBayDiId=" + model.sanBayDiId + "&sanBayDenId=" + model.sanBayDenId + "&ngayDi" + model.ngayDi + "&ngayVe" + model.ngayVe + "&loaiVe" + model.loaiVe;
            _response = _client.GetAsync($"/{url}").Result;
            var listModel = _response.Content.ReadAsAsync<IEnumerable<ChuyenBayModel>>().Result;
            List<ChuyenBayModel> models = new List<ChuyenBayModel>();
            foreach (ChuyenBayModel item in listModel)
            {
                models.Add(item);
            }
            return models;
        }

        public String isCheckChuyenBay(List<ChuyenBayModel> listCB, ChuyenBayModel model)
        {
            String day = model.ngay + " - " + model.gio;
            foreach (ChuyenBayModel item in listCB)
            {
                if (model.id != item.id)
                {
                    String time = item.ngay + " - " + item.gio;
                    if (item.tuyenBayId == model.tuyenBayId && day.Equals(time))
                    {
                        return "Chuyến bay cùng giờ đã tồn tại";
                    }
                }
            }

            return null;
        }
    }
}
