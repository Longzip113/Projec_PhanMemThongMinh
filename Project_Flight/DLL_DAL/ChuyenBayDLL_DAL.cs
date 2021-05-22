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
    public class ChuyenBayDLL_DAL:AbstractDLL_DAL<ChuyenBayModel>
    {
        public ChuyenBayDLL_DAL(String url):base(url)
        {
        }
    }
}
