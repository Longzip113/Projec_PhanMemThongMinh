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
    public class TuyenBayDLL_DAL : AbstractDLL_DAL<TuyenBayModel>
    {
        public TuyenBayDLL_DAL(String url):base(url)
        {}
    }
}
